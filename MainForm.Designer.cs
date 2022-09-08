
namespace StokTakip
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.btnCariHesaplar = new DevExpress.XtraEditors.SimpleButton();
            this.con = new System.Data.SqlClient.SqlConnection();
            this.btnBirimler = new DevExpress.XtraEditors.SimpleButton();
            this.btnStok = new DevExpress.XtraEditors.SimpleButton();
            this.btnCreateFatura = new DevExpress.XtraEditors.SimpleButton();
            this.btnFaturaList = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(901, 193);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 419);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(901, 30);
            // 
            // btnCariHesaplar
            // 
            this.btnCariHesaplar.Location = new System.Drawing.Point(12, 107);
            this.btnCariHesaplar.Name = "btnCariHesaplar";
            this.btnCariHesaplar.Size = new System.Drawing.Size(94, 29);
            this.btnCariHesaplar.TabIndex = 2;
            this.btnCariHesaplar.Text = "Cari Hesaplar";
            this.btnCariHesaplar.Click += new System.EventHandler(this.btnCariHesaplar_Click);
            // 
            // con
            // 
            this.con.FireInfoMessageEventOnUserErrors = false;
            // 
            // btnBirimler
            // 
            this.btnBirimler.Location = new System.Drawing.Point(130, 107);
            this.btnBirimler.Name = "btnBirimler";
            this.btnBirimler.Size = new System.Drawing.Size(94, 29);
            this.btnBirimler.TabIndex = 5;
            this.btnBirimler.Text = "Birimler";
            this.btnBirimler.Click += new System.EventHandler(this.btnBirimler_Click);
            // 
            // btnStok
            // 
            this.btnStok.Location = new System.Drawing.Point(253, 107);
            this.btnStok.Name = "btnStok";
            this.btnStok.Size = new System.Drawing.Size(94, 29);
            this.btnStok.TabIndex = 8;
            this.btnStok.Text = "Stoklar";
            this.btnStok.Click += new System.EventHandler(this.btnStok_Click);
            // 
            // btnCreateFatura
            // 
            this.btnCreateFatura.Location = new System.Drawing.Point(677, 107);
            this.btnCreateFatura.Name = "btnCreateFatura";
            this.btnCreateFatura.Size = new System.Drawing.Size(94, 29);
            this.btnCreateFatura.TabIndex = 11;
            this.btnCreateFatura.Text = "Fatura Oluştur";
            this.btnCreateFatura.Click += new System.EventHandler(this.btnCreateFatura_Click);
            // 
            // btnFaturaList
            // 
            this.btnFaturaList.Location = new System.Drawing.Point(787, 107);
            this.btnFaturaList.Name = "btnFaturaList";
            this.btnFaturaList.Size = new System.Drawing.Size(94, 29);
            this.btnFaturaList.TabIndex = 11;
            this.btnFaturaList.Text = "Fatura Listesi";
            this.btnFaturaList.Click += new System.EventHandler(this.btnFaturaList_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 449);
            this.Controls.Add(this.btnFaturaList);
            this.Controls.Add(this.btnCreateFatura);
            this.Controls.Add(this.btnStok);
            this.Controls.Add(this.btnBirimler);
            this.Controls.Add(this.btnCariHesaplar);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.SimpleButton btnCariHesaplar;
        private System.Data.SqlClient.SqlConnection con;
        private DevExpress.XtraEditors.SimpleButton btnBirimler;
        private DevExpress.XtraEditors.SimpleButton btnStok;
        private DevExpress.XtraEditors.SimpleButton btnCreateFatura;
        private DevExpress.XtraEditors.SimpleButton btnFaturaList;
    }
}