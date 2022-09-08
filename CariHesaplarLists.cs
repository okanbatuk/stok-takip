using LayFlatfunctions;
using System;

namespace StokTakip
{
    public partial class CariHesaplarLists : DevExpress.XtraEditors.XtraForm
    {
        public bool isValid = false;
        public CariHesaplarLists()
        {
            InitializeComponent();
            con.ConnectionString = sabitDegiskenler.vtsYolu;
        }
        private void CariHesaplarLists_Load(object sender, EventArgs e)
        {
            genel.DataTableDoldur(myDataSet.tblCariHesaplar, "Select * from tblCariHesaplar");
        }
        private void dgvCariHesaplar_DoubleClick(object sender, EventArgs e)
        {
            if (bsCariHesaplar.Count <= 0)
            {
                return;
            }
            isValid = true;
            this.Close();
        }


    }
}