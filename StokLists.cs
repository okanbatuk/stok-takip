using LayFlatfunctions;
using System;

namespace StokTakip
{
    public partial class StokLists : DevExpress.XtraEditors.XtraForm
    {
        public bool isValid = false;
        public StokLists()
        {
            InitializeComponent();
            con.ConnectionString = sabitDegiskenler.vtsYolu;
        }

        private void StokLists_Load(object sender, EventArgs e)
        {
            genel.DataTableDoldur(myDataSet.tblStok, "select * from tblStok");
        }

        private void dgvStok_DoubleClick(object sender, EventArgs e)
        {
            if (bsStok.Count <= 0)
            {
                return;
            }
            isValid = true;
            this.Close();
        }
    }
}