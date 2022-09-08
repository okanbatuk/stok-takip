
namespace StokTakip
{
    partial class Fatura
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtCariHesap = new DevExpress.XtraEditors.TextEdit();
            this.textEdit9 = new DevExpress.XtraEditors.TextEdit();
            this.txtKdvToplam = new DevExpress.XtraEditors.TextEdit();
            this.txtGenelToplam = new DevExpress.XtraEditors.TextEdit();
            this.txtAraToplam = new DevExpress.XtraEditors.TextEdit();
            this.txtFaturaNo = new DevExpress.XtraEditors.TextEdit();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dgvMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStokSec = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStokCikart = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCariHesapSec = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCariHesapCikart = new System.Windows.Forms.ToolStripMenuItem();
            this.bsStokHareket = new System.Windows.Forms.BindingSource(this.components);
            this.myDataSet = new StokTakip.myDataSet();
            this.gridViewStokHareket = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHareketID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFaturaID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKdvOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKdvTutari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.con = new System.Data.SqlClient.SqlConnection();
            this.bsFatura = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariHesap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKdvToplam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGenelToplam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAraToplam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.dgvMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsStokHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStokHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFatura)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSave);
            this.splitContainer1.Panel1.Controls.Add(this.txtCariHesap);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit9);
            this.splitContainer1.Panel1.Controls.Add(this.txtKdvToplam);
            this.splitContainer1.Panel1.Controls.Add(this.txtGenelToplam);
            this.splitContainer1.Panel1.Controls.Add(this.txtAraToplam);
            this.splitContainer1.Panel1.Controls.Add(this.txtFaturaNo);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit4);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit3);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit2);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainer1.Size = new System.Drawing.Size(831, 448);
            this.splitContainer1.SplitterDistance = 132;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(647, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 64);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCariHesap
            // 
            this.txtCariHesap.Location = new System.Drawing.Point(162, 51);
            this.txtCariHesap.Name = "txtCariHesap";
            this.txtCariHesap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.txtCariHesap.Properties.Appearance.Options.UseFont = true;
            this.txtCariHesap.Properties.ReadOnly = true;
            this.txtCariHesap.Size = new System.Drawing.Size(125, 22);
            this.txtCariHesap.TabIndex = 9;
            // 
            // textEdit9
            // 
            this.textEdit9.EditValue = "Cari Hesap";
            this.textEdit9.Location = new System.Drawing.Point(21, 51);
            this.textEdit9.Name = "textEdit9";
            this.textEdit9.Properties.ReadOnly = true;
            this.textEdit9.Size = new System.Drawing.Size(125, 22);
            this.textEdit9.TabIndex = 8;
            // 
            // txtKdvToplam
            // 
            this.txtKdvToplam.EditValue = "0";
            this.txtKdvToplam.Location = new System.Drawing.Point(486, 91);
            this.txtKdvToplam.Name = "txtKdvToplam";
            this.txtKdvToplam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.txtKdvToplam.Properties.Appearance.Options.UseFont = true;
            this.txtKdvToplam.Properties.ReadOnly = true;
            this.txtKdvToplam.Size = new System.Drawing.Size(125, 22);
            this.txtKdvToplam.TabIndex = 7;
            // 
            // txtGenelToplam
            // 
            this.txtGenelToplam.EditValue = "0";
            this.txtGenelToplam.Location = new System.Drawing.Point(486, 51);
            this.txtGenelToplam.Name = "txtGenelToplam";
            this.txtGenelToplam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.txtGenelToplam.Properties.Appearance.Options.UseFont = true;
            this.txtGenelToplam.Properties.ReadOnly = true;
            this.txtGenelToplam.Size = new System.Drawing.Size(125, 22);
            this.txtGenelToplam.TabIndex = 6;
            // 
            // txtAraToplam
            // 
            this.txtAraToplam.EditValue = "0";
            this.txtAraToplam.Location = new System.Drawing.Point(486, 12);
            this.txtAraToplam.Name = "txtAraToplam";
            this.txtAraToplam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.txtAraToplam.Properties.Appearance.Options.UseFont = true;
            this.txtAraToplam.Properties.ReadOnly = true;
            this.txtAraToplam.Size = new System.Drawing.Size(125, 22);
            this.txtAraToplam.TabIndex = 5;
            // 
            // txtFaturaNo
            // 
            this.txtFaturaNo.Location = new System.Drawing.Point(162, 12);
            this.txtFaturaNo.Name = "txtFaturaNo";
            this.txtFaturaNo.Size = new System.Drawing.Size(125, 22);
            this.txtFaturaNo.TabIndex = 4;
            // 
            // textEdit4
            // 
            this.textEdit4.EditValue = "Kdv Toplam";
            this.textEdit4.Location = new System.Drawing.Point(345, 91);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Properties.ReadOnly = true;
            this.textEdit4.Size = new System.Drawing.Size(125, 22);
            this.textEdit4.TabIndex = 3;
            // 
            // textEdit3
            // 
            this.textEdit3.EditValue = "Genel Toplam";
            this.textEdit3.Location = new System.Drawing.Point(345, 51);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.ReadOnly = true;
            this.textEdit3.Size = new System.Drawing.Size(125, 22);
            this.textEdit3.TabIndex = 2;
            // 
            // textEdit2
            // 
            this.textEdit2.EditValue = "Ara Toplam";
            this.textEdit2.Location = new System.Drawing.Point(345, 12);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.ReadOnly = true;
            this.textEdit2.Size = new System.Drawing.Size(125, 22);
            this.textEdit2.TabIndex = 1;
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "Fatura Numarasi";
            this.textEdit1.Location = new System.Drawing.Point(21, 12);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Size = new System.Drawing.Size(125, 22);
            this.textEdit1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.dgvMenu;
            this.gridControl1.DataSource = this.bsStokHareket;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridViewStokHareket;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(831, 312);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewStokHareket});
            // 
            // dgvMenu
            // 
            this.dgvMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dgvMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStokSec,
            this.menuStokCikart,
            this.menuCariHesapSec,
            this.menuCariHesapCikart});
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.Size = new System.Drawing.Size(193, 100);
            this.dgvMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.dgvMenu_ItemClicked);
            // 
            // menuStokSec
            // 
            this.menuStokSec.Name = "menuStokSec";
            this.menuStokSec.Size = new System.Drawing.Size(192, 24);
            this.menuStokSec.Text = "Stok seç";
            // 
            // menuStokCikart
            // 
            this.menuStokCikart.Name = "menuStokCikart";
            this.menuStokCikart.Size = new System.Drawing.Size(192, 24);
            this.menuStokCikart.Text = "Stok Çıkart";
            // 
            // menuCariHesapSec
            // 
            this.menuCariHesapSec.Name = "menuCariHesapSec";
            this.menuCariHesapSec.Size = new System.Drawing.Size(192, 24);
            this.menuCariHesapSec.Text = "Cari Hesap Seç";
            // 
            // menuCariHesapCikart
            // 
            this.menuCariHesapCikart.Name = "menuCariHesapCikart";
            this.menuCariHesapCikart.Size = new System.Drawing.Size(192, 24);
            this.menuCariHesapCikart.Text = "Cari Hesap Çıkart";
            // 
            // bsStokHareket
            // 
            this.bsStokHareket.DataMember = "tblStokHareket";
            this.bsStokHareket.DataSource = this.myDataSet;
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "myDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewStokHareket
            // 
            this.gridViewStokHareket.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHareketID,
            this.colFaturaID,
            this.colStokID,
            this.colBirimID,
            this.colStokKod,
            this.colBarkod,
            this.colFiyat,
            this.colTutar,
            this.colKdvOrani,
            this.colMiktar,
            this.colKdvTutari});
            this.gridViewStokHareket.GridControl = this.gridControl1;
            this.gridViewStokHareket.Name = "gridViewStokHareket";
            this.gridViewStokHareket.OptionsView.ShowAutoFilterRow = true;
            this.gridViewStokHareket.OptionsView.ShowFooter = true;
            this.gridViewStokHareket.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewStokHareket_CellValueChanged);
            // 
            // colHareketID
            // 
            this.colHareketID.FieldName = "HareketID";
            this.colHareketID.MinWidth = 25;
            this.colHareketID.Name = "colHareketID";
            this.colHareketID.OptionsColumn.AllowEdit = false;
            this.colHareketID.Visible = true;
            this.colHareketID.VisibleIndex = 0;
            this.colHareketID.Width = 94;
            // 
            // colFaturaID
            // 
            this.colFaturaID.FieldName = "FaturaID";
            this.colFaturaID.MinWidth = 25;
            this.colFaturaID.Name = "colFaturaID";
            this.colFaturaID.OptionsColumn.AllowEdit = false;
            this.colFaturaID.Visible = true;
            this.colFaturaID.VisibleIndex = 1;
            this.colFaturaID.Width = 94;
            // 
            // colStokID
            // 
            this.colStokID.FieldName = "StokID";
            this.colStokID.MinWidth = 25;
            this.colStokID.Name = "colStokID";
            this.colStokID.OptionsColumn.AllowEdit = false;
            this.colStokID.Visible = true;
            this.colStokID.VisibleIndex = 2;
            this.colStokID.Width = 94;
            // 
            // colBirimID
            // 
            this.colBirimID.FieldName = "BirimID";
            this.colBirimID.MinWidth = 25;
            this.colBirimID.Name = "colBirimID";
            this.colBirimID.OptionsColumn.AllowEdit = false;
            this.colBirimID.Visible = true;
            this.colBirimID.VisibleIndex = 3;
            this.colBirimID.Width = 94;
            // 
            // colStokKod
            // 
            this.colStokKod.FieldName = "StokKod";
            this.colStokKod.MinWidth = 25;
            this.colStokKod.Name = "colStokKod";
            this.colStokKod.OptionsColumn.AllowEdit = false;
            this.colStokKod.Visible = true;
            this.colStokKod.VisibleIndex = 4;
            this.colStokKod.Width = 94;
            // 
            // colBarkod
            // 
            this.colBarkod.FieldName = "Barkod";
            this.colBarkod.MinWidth = 25;
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.OptionsColumn.AllowEdit = false;
            this.colBarkod.Visible = true;
            this.colBarkod.VisibleIndex = 5;
            this.colBarkod.Width = 94;
            // 
            // colFiyat
            // 
            this.colFiyat.FieldName = "Fiyat";
            this.colFiyat.MinWidth = 25;
            this.colFiyat.Name = "colFiyat";
            this.colFiyat.Visible = true;
            this.colFiyat.VisibleIndex = 6;
            this.colFiyat.Width = 94;
            // 
            // colTutar
            // 
            this.colTutar.FieldName = "Tutar";
            this.colTutar.MinWidth = 25;
            this.colTutar.Name = "colTutar";
            this.colTutar.OptionsColumn.AllowEdit = false;
            this.colTutar.Visible = true;
            this.colTutar.VisibleIndex = 7;
            this.colTutar.Width = 94;
            // 
            // colKdvOrani
            // 
            this.colKdvOrani.FieldName = "KdvOrani";
            this.colKdvOrani.MinWidth = 25;
            this.colKdvOrani.Name = "colKdvOrani";
            this.colKdvOrani.OptionsColumn.AllowEdit = false;
            this.colKdvOrani.Visible = true;
            this.colKdvOrani.VisibleIndex = 8;
            this.colKdvOrani.Width = 94;
            // 
            // colMiktar
            // 
            this.colMiktar.FieldName = "Miktar";
            this.colMiktar.MinWidth = 25;
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.Visible = true;
            this.colMiktar.VisibleIndex = 9;
            this.colMiktar.Width = 94;
            // 
            // colKdvTutari
            // 
            this.colKdvTutari.FieldName = "KdvTutari";
            this.colKdvTutari.MinWidth = 25;
            this.colKdvTutari.Name = "colKdvTutari";
            this.colKdvTutari.OptionsColumn.AllowEdit = false;
            this.colKdvTutari.Visible = true;
            this.colKdvTutari.VisibleIndex = 10;
            this.colKdvTutari.Width = 94;
            // 
            // con
            // 
            this.con.FireInfoMessageEventOnUserErrors = false;
            // 
            // bsFatura
            // 
            this.bsFatura.DataMember = "tblFatura";
            this.bsFatura.DataSource = this.myDataSet;
            // 
            // Fatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 448);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Fatura";
            this.Text = "Fatura";
            this.Load += new System.EventHandler(this.Fatura_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCariHesap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKdvToplam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGenelToplam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAraToplam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.dgvMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsStokHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStokHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFatura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.TextEdit txtCariHesap;
        private DevExpress.XtraEditors.TextEdit textEdit9;
        private DevExpress.XtraEditors.TextEdit txtKdvToplam;
        private DevExpress.XtraEditors.TextEdit txtGenelToplam;
        private DevExpress.XtraEditors.TextEdit txtAraToplam;
        private DevExpress.XtraEditors.TextEdit txtFaturaNo;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource bsStokHareket;
        private myDataSet myDataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewStokHareket;
        private DevExpress.XtraGrid.Columns.GridColumn colHareketID;
        private DevExpress.XtraGrid.Columns.GridColumn colFaturaID;
        private DevExpress.XtraGrid.Columns.GridColumn colStokID;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimID;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKod;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colKdvOrani;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colKdvTutari;
        private System.Data.SqlClient.SqlConnection con;
        private System.Windows.Forms.ContextMenuStrip dgvMenu;
        private System.Windows.Forms.ToolStripMenuItem menuStokSec;
        private System.Windows.Forms.ToolStripMenuItem menuStokCikart;
        private System.Windows.Forms.ToolStripMenuItem menuCariHesapSec;
        private System.Windows.Forms.ToolStripMenuItem menuCariHesapCikart;
        private System.Windows.Forms.BindingSource bsFatura;
    }
}