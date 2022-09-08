
namespace StokTakip
{
    partial class StokLists
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
            this.dgvStok = new DevExpress.XtraGrid.GridControl();
            this.bsStok = new System.Windows.Forms.BindingSource(this.components);
            this.myDataSet = new StokTakip.myDataSet();
            this.gridViewStok = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStokID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKdvOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.con = new System.Data.SqlClient.SqlConnection();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStok)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStok
            // 
            this.dgvStok.DataSource = this.bsStok;
            this.dgvStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStok.Location = new System.Drawing.Point(0, 0);
            this.dgvStok.MainView = this.gridViewStok;
            this.dgvStok.Name = "dgvStok";
            this.dgvStok.Size = new System.Drawing.Size(680, 406);
            this.dgvStok.TabIndex = 0;
            this.dgvStok.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewStok});
            this.dgvStok.DoubleClick += new System.EventHandler(this.dgvStok_DoubleClick);
            // 
            // bsStok
            // 
            this.bsStok.DataMember = "tblStok";
            this.bsStok.DataSource = this.myDataSet;
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "myDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.gridViewStok.OptionsView.ShowFooter = true;
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
            // StokLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 406);
            this.Controls.Add(this.dgvStok);
            this.Name = "StokLists";
            this.Text = "Stok Seç";
            this.Load += new System.EventHandler(this.StokLists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvStok;
        private myDataSet myDataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewStok;
        private DevExpress.XtraGrid.Columns.GridColumn colStokID;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimID;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKod;
        private DevExpress.XtraGrid.Columns.GridColumn colStokFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKdvOrani;
        private System.Data.SqlClient.SqlConnection con;
        public System.Windows.Forms.BindingSource bsStok;
    }
}