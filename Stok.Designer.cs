
namespace StokTakip
{
    partial class Stok
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
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.bsBirim = new System.Windows.Forms.BindingSource(this.components);
            this.myDataSet = new StokTakip.myDataSet();
            this.txtKdvOrani = new DevExpress.XtraEditors.TextEdit();
            this.txtStokAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtFiyat = new DevExpress.XtraEditors.TextEdit();
            this.txtBarkod = new DevExpress.XtraEditors.TextEdit();
            this.txtStokKodu = new DevExpress.XtraEditors.TextEdit();
            this.textEdit9 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit8 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.dgvStok = new DevExpress.XtraGrid.GridControl();
            this.bsStok = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewStok = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStokID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKdvOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.con = new System.Data.SqlClient.SqlConnection();
            this.dgvMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuChange = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBirim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKdvOrani.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStok)).BeginInit();
            this.dgvMenu.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.lookUpEdit1);
            this.splitContainer1.Panel1.Controls.Add(this.txtKdvOrani);
            this.splitContainer1.Panel1.Controls.Add(this.txtStokAdi);
            this.splitContainer1.Panel1.Controls.Add(this.txtFiyat);
            this.splitContainer1.Panel1.Controls.Add(this.txtBarkod);
            this.splitContainer1.Panel1.Controls.Add(this.txtStokKodu);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit9);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit3);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit8);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit2);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit7);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvStok);
            this.splitContainer1.Size = new System.Drawing.Size(903, 450);
            this.splitContainer1.SplitterDistance = 210;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(191, 117);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(161, 13);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BirimAdi", "Birim Adi", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEdit1.Properties.DataSource = this.bsBirim;
            this.lookUpEdit1.Properties.DisplayMember = "BirimAdi";
            this.lookUpEdit1.Properties.NullText = "";
            this.lookUpEdit1.Properties.ValueMember = "BirimID";
            this.lookUpEdit1.Size = new System.Drawing.Size(125, 22);
            this.lookUpEdit1.TabIndex = 6;
            // 
            // bsBirim
            // 
            this.bsBirim.DataMember = "tblBirim";
            this.bsBirim.DataSource = this.myDataSet;
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "myDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtKdvOrani
            // 
            this.txtKdvOrani.Location = new System.Drawing.Point(516, 68);
            this.txtKdvOrani.Name = "txtKdvOrani";
            this.txtKdvOrani.Size = new System.Drawing.Size(125, 22);
            this.txtKdvOrani.TabIndex = 5;
            // 
            // txtStokAdi
            // 
            this.txtStokAdi.Location = new System.Drawing.Point(161, 68);
            this.txtStokAdi.Name = "txtStokAdi";
            this.txtStokAdi.Size = new System.Drawing.Size(125, 22);
            this.txtStokAdi.TabIndex = 5;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(516, 40);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(125, 22);
            this.txtFiyat.TabIndex = 4;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(161, 40);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(125, 22);
            this.txtBarkod.TabIndex = 4;
            // 
            // txtStokKodu
            // 
            this.txtStokKodu.Location = new System.Drawing.Point(516, 12);
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.Size = new System.Drawing.Size(125, 22);
            this.txtStokKodu.TabIndex = 3;
            // 
            // textEdit9
            // 
            this.textEdit9.EditValue = "Kdv Orani";
            this.textEdit9.Location = new System.Drawing.Point(367, 68);
            this.textEdit9.Name = "textEdit9";
            this.textEdit9.Properties.ReadOnly = true;
            this.textEdit9.Size = new System.Drawing.Size(125, 22);
            this.textEdit9.TabIndex = 2;
            // 
            // textEdit3
            // 
            this.textEdit3.EditValue = "Stok Adi";
            this.textEdit3.Location = new System.Drawing.Point(12, 68);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.ReadOnly = true;
            this.textEdit3.Size = new System.Drawing.Size(125, 22);
            this.textEdit3.TabIndex = 2;
            // 
            // textEdit8
            // 
            this.textEdit8.EditValue = "Fiyat";
            this.textEdit8.Location = new System.Drawing.Point(367, 40);
            this.textEdit8.Name = "textEdit8";
            this.textEdit8.Properties.ReadOnly = true;
            this.textEdit8.Size = new System.Drawing.Size(125, 22);
            this.textEdit8.TabIndex = 1;
            // 
            // textEdit2
            // 
            this.textEdit2.EditValue = "Barkod";
            this.textEdit2.Location = new System.Drawing.Point(12, 40);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.ReadOnly = true;
            this.textEdit2.Size = new System.Drawing.Size(125, 22);
            this.textEdit2.TabIndex = 1;
            // 
            // textEdit7
            // 
            this.textEdit7.EditValue = "Stok Kodu";
            this.textEdit7.Location = new System.Drawing.Point(367, 12);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Properties.ReadOnly = true;
            this.textEdit7.Size = new System.Drawing.Size(125, 22);
            this.textEdit7.TabIndex = 0;
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "Birim Adi";
            this.textEdit1.Location = new System.Drawing.Point(12, 12);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Size = new System.Drawing.Size(125, 22);
            this.textEdit1.TabIndex = 0;
            // 
            // dgvStok
            // 
            this.dgvStok.ContextMenuStrip = this.dgvMenu;
            this.dgvStok.DataSource = this.bsStok;
            this.dgvStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStok.Location = new System.Drawing.Point(0, 0);
            this.dgvStok.MainView = this.gridViewStok;
            this.dgvStok.Name = "dgvStok";
            this.dgvStok.Size = new System.Drawing.Size(903, 236);
            this.dgvStok.TabIndex = 0;
            this.dgvStok.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewStok});
            // 
            // bsStok
            // 
            this.bsStok.DataMember = "tblStok";
            this.bsStok.DataSource = this.myDataSet;
            // 
            // gridViewStok
            // 
            this.gridViewStok.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStokID,
            this.colBirimID,
            this.colBarkod,
            this.colStokAdi,
            this.colStokKod,
            this.colStokFiyat,
            this.colStokKdvOrani});
            this.gridViewStok.GridControl = this.dgvStok;
            this.gridViewStok.Name = "gridViewStok";
            this.gridViewStok.OptionsBehavior.Editable = false;
            this.gridViewStok.OptionsView.ShowAutoFilterRow = true;
            // 
            // colStokID
            // 
            this.colStokID.FieldName = "StokID";
            this.colStokID.MinWidth = 25;
            this.colStokID.Name = "colStokID";
            this.colStokID.Visible = true;
            this.colStokID.VisibleIndex = 0;
            this.colStokID.Width = 94;
            // 
            // colBirimID
            // 
            this.colBirimID.FieldName = "BirimID";
            this.colBirimID.MinWidth = 25;
            this.colBirimID.Name = "colBirimID";
            this.colBirimID.Visible = true;
            this.colBirimID.VisibleIndex = 1;
            this.colBirimID.Width = 94;
            // 
            // colBarkod
            // 
            this.colBarkod.FieldName = "Barkod";
            this.colBarkod.MinWidth = 25;
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.Visible = true;
            this.colBarkod.VisibleIndex = 2;
            this.colBarkod.Width = 94;
            // 
            // colStokAdi
            // 
            this.colStokAdi.FieldName = "StokAdi";
            this.colStokAdi.MinWidth = 25;
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 3;
            this.colStokAdi.Width = 94;
            // 
            // colStokKod
            // 
            this.colStokKod.FieldName = "StokKod";
            this.colStokKod.MinWidth = 25;
            this.colStokKod.Name = "colStokKod";
            this.colStokKod.Visible = true;
            this.colStokKod.VisibleIndex = 4;
            this.colStokKod.Width = 94;
            // 
            // colStokFiyat
            // 
            this.colStokFiyat.FieldName = "StokFiyat";
            this.colStokFiyat.MinWidth = 25;
            this.colStokFiyat.Name = "colStokFiyat";
            this.colStokFiyat.Visible = true;
            this.colStokFiyat.VisibleIndex = 5;
            this.colStokFiyat.Width = 94;
            // 
            // colStokKdvOrani
            // 
            this.colStokKdvOrani.FieldName = "StokKdvOrani";
            this.colStokKdvOrani.MinWidth = 25;
            this.colStokKdvOrani.Name = "colStokKdvOrani";
            this.colStokKdvOrani.Visible = true;
            this.colStokKdvOrani.VisibleIndex = 6;
            this.colStokKdvOrani.Width = 94;
            // 
            // con
            // 
            this.con.FireInfoMessageEventOnUserErrors = false;
            // 
            // dgvMenu
            // 
            this.dgvMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dgvMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuChange,
            this.menuDelete});
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.Size = new System.Drawing.Size(129, 52);
            this.dgvMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.dgvMenu_ItemClicked);
            // 
            // menuChange
            // 
            this.menuChange.Name = "menuChange";
            this.menuChange.Size = new System.Drawing.Size(128, 24);
            this.menuChange.Text = "Change";
            // 
            // menuDelete
            // 
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.Size = new System.Drawing.Size(128, 24);
            this.menuDelete.Text = "Delete";
            // 
            // Stok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Stok";
            this.Text = "Stok";
            this.Load += new System.EventHandler(this.Stok_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBirim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKdvOrani.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStok)).EndInit();
            this.dgvMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Data.SqlClient.SqlConnection con;
        private DevExpress.XtraGrid.GridControl dgvStok;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewStok;
        private System.Windows.Forms.BindingSource bsStok;
        private myDataSet myDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colStokID;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimID;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKod;
        private DevExpress.XtraGrid.Columns.GridColumn colStokFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKdvOrani;
        private DevExpress.XtraEditors.TextEdit txtKdvOrani;
        private DevExpress.XtraEditors.TextEdit txtStokAdi;
        private DevExpress.XtraEditors.TextEdit txtFiyat;
        private DevExpress.XtraEditors.TextEdit txtBarkod;
        private DevExpress.XtraEditors.TextEdit txtStokKodu;
        private DevExpress.XtraEditors.TextEdit textEdit9;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit8;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private System.Windows.Forms.BindingSource bsBirim;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.ContextMenuStrip dgvMenu;
        private System.Windows.Forms.ToolStripMenuItem menuChange;
        private System.Windows.Forms.ToolStripMenuItem menuDelete;
    }
}