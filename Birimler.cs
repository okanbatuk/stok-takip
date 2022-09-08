using FunctionsDevExpress14;
using LayFlatfunctions;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class Birimler : DevExpress.XtraEditors.XtraForm
    {
        public bool save = true;
        public Birimler()
        {
            InitializeComponent();
            con.ConnectionString = sabitDegiskenler.vtsYolu;
        }

        private void Birimler_Load(object sender, EventArgs e)
        {
            genel.DataTableDoldur(myDataSet.tblBirim, "Select * from tblBirim");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // kontroller yapilacak
            if (txtBirim.Text == "")
            {
                FrameWork4D13.hataMesajTimer("Geçerli bir birim adı giriniz.", false);
                return;
            }
            if (save)
            {
                bsBirim.AddNew();
            }
            DataRow drowBirim = ((DataRowView)bsBirim.Current).Row;
            drowBirim["BirimAdi"] = txtBirim.EditValue;

            bsBirim.EndEdit();

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlTransaction trans = con.BeginTransaction();
            SqlDataAdapter adpBirim = ProjectAdapters.adpBirim(con, trans, false);

            try
            {
                adpBirim.Update(myDataSet.tblBirim);
                trans.Commit();
            }
            catch (Exception ex)
            {
                FrameWork4D13.hataMesajTimer(ex.ToString(), false);
                trans.Rollback();
                con.Close();
                return;
            }
            if (save)
            {
                FrameWork4D13.hataMesajTimer("Create successfully", true);
            }
            else
            {
                FrameWork4D13.hataMesajTimer("Update Successfully", true);
            }
            Temizle();
        }
        void Temizle()
        {
            txtBirim.Text = "";
            btnSave.Text = "Save";
            save = true;
            dgvBirim.Enabled = true;
            txtBirim.Focus();
        }

        private void dgvMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == menuChange.Name)
            {
                if (bsBirim.Count <= 0)
                {
                    return;
                }
                btnSave.Text = "Change";
                save = false;
                DataRow drowBirimler = ((DataRowView)bsBirim.Current).Row;
                txtBirim.EditValue = drowBirimler["BirimAdi"];
            }
            else if (e.ClickedItem.Name == menuDelete.Name)
            {
                if (bsBirim.Count <= 0)
                {
                    return;
                }
                if (!FrameWork4D13.HataMesaji("Are you sure you want to delete the record?"))
                {
                    return;
                }

                bsBirim.RemoveCurrent();

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlTransaction trans = con.BeginTransaction();
                SqlDataAdapter adpBirim = ProjectAdapters.adpBirim(con, trans, false);

                try
                {
                    adpBirim.Update(myDataSet.tblBirim);
                    trans.Commit();
                }
                catch (Exception ex)
                {

                    FrameWork4D13.hataMesajTimer(ex.ToString(), false);
                    trans.Rollback();
                    con.Close();
                    return;
                }
                FrameWork4D13.hataMesajTimer("Delete successfully", true);

            }
        }
    }
}