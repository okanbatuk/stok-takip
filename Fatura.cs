using FunctionsDevExpress14;
using LayFlatfunctions;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class Fatura : DevExpress.XtraEditors.XtraForm
    {
        public int CariID, FaturaID = 0;
        public bool save = true;
        private decimal AraToplam, KdvToplam, GenelToplam = 0;
        public Fatura()
        {
            InitializeComponent();
            con.ConnectionString = sabitDegiskenler.vtsYolu;

            myDataSet.Relations.Add(myDataSet.tblFatura.FaturaIDColumn, myDataSet.tblStokHareket.FaturaIDColumn);
        }
        private void Fatura_Load(object sender, EventArgs e)
        {
            //
            if (!save)
            {
                genel.DataTableDoldur(myDataSet.tblFatura, "Select * from tblFatura where FaturaID =" + FaturaID);
                genel.DataTableDoldur(myDataSet.tblStokHareket, "Select * from tblStokHareket where FaturaID =" + FaturaID);

                DataRow drowFatura = ((DataRowView)bsFatura[0]).Row;
                txtFaturaNo.EditValue = drowFatura["FaturaNo"];
                CariID = Convert.ToInt32(drowFatura["CariID"]);
                txtCariHesap.EditValue = genel.ExeCuteScalarStr("select Unvan from tblCariHesaplar where CariID =" + CariID);
                Hesapla();
            }
        }

        /*void Temizle()
        {
            txtFaturaNo.Text = "";
            txtCariHesap.Text = "";
            txtAraToplam.Text = "";
            txtGenelToplam.Text = "";
            txtKdvToplam.Text = "";
        }*/

        private void dgvMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == menuStokSec.Name)
            {
                StokLists f = new StokLists();
                f.ShowDialog();
                if (f.isValid)
                {
                    DataRow drowStokSec = ((DataRowView)f.bsStok.Current).Row;
                    bsStokHareket.AddNew();
                    DataRow drowStokHareket = ((DataRowView)bsStokHareket.Current).Row;
                    drowStokHareket["StokID"] = drowStokSec["StokID"];
                    drowStokHareket["BirimID"] = drowStokSec["BirimID"];
                    drowStokHareket["StokKod"] = drowStokSec["StokKod"];
                    drowStokHareket["Barkod"] = drowStokSec["Barkod"];
                    drowStokHareket["Fiyat"] = drowStokSec["StokFiyat"];
                    drowStokHareket["KdvOrani"] = drowStokSec["StokKdvOrani"];
                    bsStokHareket.EndEdit();
                }
            }
            else if (e.ClickedItem.Name == menuStokCikart.Name)
            {
                if (bsStokHareket.Count <= 0)
                {
                    return;
                }
                if (!FrameWork4D13.HataMesaji("Stok çıkarmak istediğinize emin misiniz?"))
                {
                    return;
                }
                bsStokHareket.RemoveCurrent();
                if (bsStokHareket.Count >= 0)
                {
                    Hesapla();
                    return;
                }

            }
            else if (e.ClickedItem.Name == menuCariHesapSec.Name)
            {
                CariHesaplarLists f = new CariHesaplarLists();
                f.ShowDialog();
                if (f.isValid)
                {
                    DataRow drowCariHesapSec = ((DataRowView)f.bsCariHesaplar.Current).Row;
                    CariID = Convert.ToInt32(drowCariHesapSec["CariID"]);
                    txtCariHesap.EditValue = drowCariHesapSec["Unvan"];
                }
            }
            else if (e.ClickedItem.Name == menuCariHesapCikart.Name)
            {
                if (CariID == 0)
                {
                    return;
                }
                if (!FrameWork4D13.HataMesaji("Cari hesabı çıkarmak istediğinize emin misiniz?"))
                {
                    return;
                }
                CariID = 0;
                txtCariHesap.EditValue = "";
                FrameWork4D13.hataMesajTimer("Cari hesap çıkarıldı", true);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (bsStokHareket.Count <= 0)
            {
                FrameWork4D13.hataMesajTimer("Stok seçiniz.", false);
                return;
            }
            else if (CariID == 0)
            {
                FrameWork4D13.hataMesajTimer("Cari Hesap seçiniz.", false);
                return;
            }
            else if (txtFaturaNo.Text == "")
            {
                FrameWork4D13.hataMesajTimer("Fatura Numarasi giriniz.", false);
                return;
            }
            if (save)
            {
                bsFatura.AddNew();

            }
            DataRow drowFatura = ((DataRowView)bsFatura.Current).Row;
            drowFatura["CariID"] = CariID;
            drowFatura["FaturaTarihi"] = DateTime.Now;
            drowFatura["FaturaNo"] = txtFaturaNo.EditValue;
            drowFatura["AraToplam"] = AraToplam;
            drowFatura["GenelToplam"] = GenelToplam;
            drowFatura["KdvToplam"] = KdvToplam;
            bsFatura.EndEdit();

            for (int i = 0; i < bsStokHareket.Count; i++)
            {
                DataRow drowStokHareket = ((DataRowView)bsStokHareket[i]).Row;
                drowStokHareket.SetParentRow(drowFatura);
                bsStokHareket.EndEdit();
            }

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlTransaction trans = con.BeginTransaction();

            try
            {
                SqlDataAdapter adpFatura = ProjectAdapters.adpFatura(con, trans, false);
                SqlDataAdapter adpStokHareket = ProjectAdapters.adpStokHareket(con, trans, false);
                adpFatura.Update(myDataSet.tblFatura);
                adpStokHareket.Update(myDataSet.tblStokHareket);

                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                con.Close();
                FrameWork4D13.hataMesajTimer(ex.ToString(), false);
                return;
            }

            if (save)
            {
                FrameWork4D13.hataMesajTimer("Create successfully", true);
                save = false;
            }
            else
            {
                FrameWork4D13.hataMesajTimer("Update Successfully", true);
            }
        }
        private void gridViewStokHareket_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            Hesapla();
        }
        void Hesapla()
        {
            for (int i = 0; i < bsStokHareket.Count; i++)
            {
                DataRow drowStokHareket = ((DataRowView)bsStokHareket[i]).Row;

                drowStokHareket["Tutar"] = (Convert.ToDecimal(drowStokHareket["Fiyat"]) * Convert.ToDecimal(drowStokHareket["Miktar"])).ToString();
                drowStokHareket["KdvTutari"] = (Convert.ToDecimal(drowStokHareket["Tutar"]) / 100) * (Convert.ToDecimal(drowStokHareket["KdvOrani"]));
            }
            if (!DBNull.Value.Equals(myDataSet.tblStokHareket.Compute("Sum(Tutar)", "")))
            {
                AraToplam = Convert.ToDecimal(myDataSet.tblStokHareket.Compute("Sum(Tutar)", ""));
                txtAraToplam.EditValue = AraToplam.ToString();
            }
            else
            {
                AraToplam = 0;
                txtAraToplam.EditValue = AraToplam.ToString();
            }
            if (!DBNull.Value.Equals(myDataSet.tblStokHareket.Compute("Sum(KdvTutari)", "")))
            {
                KdvToplam = Convert.ToDecimal(myDataSet.tblStokHareket.Compute("Sum(KdvTutari)", ""));
                txtKdvToplam.EditValue = KdvToplam.ToString();
            }
            else
            {
                KdvToplam = 0;
                txtKdvToplam.EditValue = KdvToplam.ToString();
            }
            txtGenelToplam.EditValue = (KdvToplam + AraToplam).ToString();
            GenelToplam = KdvToplam + AraToplam;
        }
    }
}