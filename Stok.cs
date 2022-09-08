using FunctionsDevExpress14;
using LayFlatfunctions;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class Stok : DevExpress.XtraEditors.XtraForm
    {
        public bool save = true;
        public Stok()
        {
            InitializeComponent();
            con.ConnectionString = sabitDegiskenler.vtsYolu;
        }

        private void Stok_Load(object sender, EventArgs e)
        {
            genel.DataTableDoldur(myDataSet.tblStok, "Select * from tblStok");
            genel.DataTableDoldur(myDataSet.tblBirim, "Select * from tblBirim");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // kontroller yazilacak
            if (lookUpEdit1.EditValue == null || txtBarkod.Text == "" || txtStokAdi.Text == "" || txtStokKodu.Text == "" || txtFiyat.Text == "" || txtKdvOrani.Text == "")
            {
                FrameWork4D13.hataMesajTimer("Lütfen boş alanlara geçerli bilgiler giriniz.", false);
                return;
            }
            if (save)
            {
                bsStok.AddNew();
            }
            DataRow drowStok = ((DataRowView)bsStok.Current).Row;
            drowStok["BirimID"] = lookUpEdit1.EditValue;
            drowStok["Barkod"] = txtBarkod.EditValue;
            drowStok["StokAdi"] = txtStokAdi.EditValue;
            drowStok["StokKod"] = txtStokKodu.EditValue;
            drowStok["StokFiyat"] = txtFiyat.EditValue;
            drowStok["StokKdvOrani"] = txtKdvOrani.EditValue;

            bsStok.EndEdit();

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlTransaction trans = con.BeginTransaction();
            SqlDataAdapter adpStok = ProjectAdapters.adpStok(con, trans, false);

            try
            {
                adpStok.Update(myDataSet.tblStok);
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
            lookUpEdit1.EditValue = null;
            txtBarkod.Text = "";
            txtStokAdi.Text = "";
            txtStokKodu.Text = "";
            txtFiyat.Text = "";
            txtKdvOrani.Text = "";
            btnSave.Text = "Save";
            save = true;
            dgvStok.Enabled = true;
            txtBarkod.Focus();
        }

        private void dgvMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == menuChange.Name)
            {
                if (bsStok.Count <= 0)
                {
                    return;
                }
                btnSave.Text = "Change";
                save = false;
                DataRow drowStok = ((DataRowView)bsStok.Current).Row;
                lookUpEdit1.EditValue = drowStok["BirimID"];
                txtBarkod.EditValue = drowStok["Barkod"];
                txtStokAdi.EditValue = drowStok["StokAdi"];
                txtStokKodu.EditValue = drowStok["StokKod"];
                txtFiyat.EditValue = drowStok["StokFiyat"];
                txtKdvOrani.EditValue = drowStok["StokKdvOrani"];
            }
            else if (e.ClickedItem.Name == menuDelete.Name)
            {
                if (bsStok.Count == 0)
                {
                    return;
                }
                if (!FrameWork4D13.HataMesaji("Are you sure you want to delete the record?"))
                {
                    return;
                }
                bsStok.RemoveCurrent();

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlTransaction trans = con.BeginTransaction();
                SqlDataAdapter adpBirim = ProjectAdapters.adpBirim(con, trans, false);

                try
                {
                    adpBirim.Update(myDataSet.tblCariHesaplar);
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