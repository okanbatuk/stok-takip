using FunctionsDevExpress14;
using LayFlatfunctions;
using System;

namespace StokTakip
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public bool isExit = false;
        public Login()
        {
            InitializeComponent();
            con.ConnectionString = sabitDegiskenler.vtsYolu;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                FrameWork4D13.hataMesajTimer("User name or password should not empty", false);
                return;
            }
            if (genel.ExeCuteScalar(@"select * from tblKullanici where KullaniciAdi = '" + txtUserName.EditValue + "' and Sifre = '" + txtPassword.EditValue + "'"))
            {
                isExit = true;
                this.Close();
            }
            else
            {
                FrameWork4D13.hataMesajTimer("User name or password is invalid", false);
                return;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }
    }
}
