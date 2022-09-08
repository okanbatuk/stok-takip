using FunctionsDevExpress14;
using LayFlatfunctions;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class CariHesaplar : DevExpress.XtraEditors.XtraForm
    {
        public bool save = true;
        public CariHesaplar()
        {
            InitializeComponent();
            con.ConnectionString = sabitDegiskenler.vtsYolu;
        }

        private void CariHesaplar_Load(object sender, EventArgs e)
        {
            genel.DataTableDoldur(myDataSet.tblCariHesaplar, "select * from tblCariHesaplar");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // kontroller yapilacak
            if (txtAdres.Text == "" || txtMail.Text == "" || txtTelefon.Text == "" || txtUnvan.Text == "" || txtVergiDairesi.Text == "" || txtVergiNo.Text == "")
            {
                FrameWork4D13.hataMesajTimer("Lütfen boş alanlara geçerli bilgiler giriniz.", false);
                return;
            }
            if (save)
            {
                bsCariHesaplar.AddNew();
            }
            DataRow drowCariHesaplar = ((DataRowView)bsCariHesaplar.Current).Row;
            drowCariHesaplar["Unvan"] = txtUnvan.EditValue;
            drowCariHesaplar["VergiNo"] = txtVergiNo.EditValue;
            drowCariHesaplar["VergiDairesi"] = txtVergiDairesi.EditValue;
            drowCariHesaplar["Adres"] = txtAdres.EditValue;
            drowCariHesaplar["Telefon"] = txtTelefon.EditValue;
            drowCariHesaplar["Mail"] = txtMail.EditValue;

            bsCariHesaplar.EndEdit();

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlTransaction trans = con.BeginTransaction();
            SqlDataAdapter adpCariHesaplar = ProjectAdapters.adpCariHesaplar(con, trans, false);

            try
            {
                adpCariHesaplar.Update(myDataSet.tblCariHesaplar);
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
            txtAdres.Text = "";
            txtMail.Text = "";
            txtTelefon.Text = "";
            txtUnvan.Text = "";
            txtVergiDairesi.Text = "";
            txtVergiNo.Text = "";
            btnSave.Text = "Save";
            save = true;
            dgvCariHesaplar.Enabled = true;
            txtUnvan.Focus();
        }

        private void dgvListe_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == menuChange.Name)
            {
                if (bsCariHesaplar.Count <= 0)
                {
                    return;
                }
                btnSave.Text = "Change";
                save = false;
                DataRow drowCariHesaplar = ((DataRowView)bsCariHesaplar.Current).Row;
                txtUnvan.EditValue = drowCariHesaplar["Unvan"];
                txtAdres.EditValue = drowCariHesaplar["Adres"];
                txtMail.EditValue = drowCariHesaplar["Mail"];
                txtTelefon.EditValue = drowCariHesaplar["Telefon"];
                txtVergiDairesi.EditValue = drowCariHesaplar["VergiDairesi"];
                txtVergiNo.EditValue = drowCariHesaplar["VergiNo"];
            }
            else if (e.ClickedItem.Name == menuDelete.Name)
            {
                if (bsCariHesaplar.Count == 0)
                {
                    return;
                }
                if (!FrameWork4D13.HataMesaji("Are you sure you want to delete the record?"))
                {
                    return;
                }
                bsCariHesaplar.RemoveCurrent();

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlTransaction trans = con.BeginTransaction();
                SqlDataAdapter adpCariHesaplar = ProjectAdapters.adpCariHesaplar(con, trans, false);

                try
                {
                    adpCariHesaplar.Update(myDataSet.tblCariHesaplar);
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