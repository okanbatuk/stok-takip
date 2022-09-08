using FunctionsDevExpress14;
using LayFlatfunctions;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace StokTakip
{
    public partial class FaturaLists : DevExpress.XtraEditors.XtraForm
    {
        public int FaturaID = 0;
        public bool isUpdate = false;
        public FaturaLists()
        {
            InitializeComponent();
            con.ConnectionString = sabitDegiskenler.vtsYolu;
        }

        private void FaturaLists_Load(object sender, EventArgs e)
        {
            genel.DataTableDoldur(myDataSet.tblFatura, "Select * from tblFatura");
        }

        private void dgvMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == menuUpdate.Name)
            {
                if (bsFatura.Count <= 0)
                {
                    return;
                }
                DataRow drowFatura = ((DataRowView)bsFatura.Current).Row;
                Fatura f = new Fatura
                {
                    save = false,
                    FaturaID = Convert.ToInt32(drowFatura["FaturaID"])
                };
                f.ShowDialog();
                genel.DataTableDoldur(myDataSet.tblFatura, "select * from tblFatura");
            }
            else if (e.ClickedItem.Name == menuDelete.Name)
            {
                if (bsFatura.Count <= 0)
                {
                    return;
                }
                if (!FrameWork4D13.HataMesaji("Silmek istediğinize emin misiniz?"))
                {
                    return;
                }
                bsFatura.RemoveCurrent();

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlTransaction trans = con.BeginTransaction();
                SqlDataAdapter adpFatura = ProjectAdapters.adpFatura(con, trans, false);

                try
                {
                    adpFatura.Update(myDataSet.tblFatura);
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    FrameWork4D13.hataMesajTimer(ex.ToString(), false);
                    trans.Rollback();
                    con.Close();
                    return;
                }

                FrameWork4D13.hataMesajTimer("Kayıt silindi", true);
            }
            else if (e.ClickedItem.Name == menuPrint.Name)
            {
                if (bsFatura.Count <= 0)
                {
                    return;
                }
                //
                DataRow drowFatura = ((DataRowView)bsFatura.Current).Row;

                FaturaID = Convert.ToInt32(drowFatura["FaturaID"]);

                if (FaturaID != 0)
                {
                    genel.DataTableDoldur(myDataSet.View_Fatura, "select * from View_Fatura where FaturaID =" + FaturaID);
                    //FaturaPrint report = new FaturaPrint
                    //{
                    //    DataSource = myDataSet,
                    //    DataMember = (myDataSet.View_Print_Fatura).ToString()
                    //};
                    FaturaPrint report = new FaturaPrint
                    {
                        DataSource = myDataSet
                    };

                    report.ShowPreview();
                }
            }
        }
    }
}