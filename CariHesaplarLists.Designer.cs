
namespace StokTakip
{
    partial class CariHesaplarLists
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
            this.dgvCariHesaplar = new DevExpress.XtraGrid.GridControl();
            this.bsCariHesaplar = new System.Windows.Forms.BindingSource(this.components);
            this.myDataSet = new StokTakip.myDataSet();
            this.gridViewCariHesaplar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCariID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnvan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVergiNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVergiDairesi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.con = new System.Data.SqlClient.SqlConnection();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariHesaplar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCariHesaplar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCariHesaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCariHesaplar
            // 
            this.dgvCariHesaplar.DataSource = this.bsCariHesaplar;
            this.dgvCariHesaplar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCariHesaplar.Location = new System.Drawing.Point(0, 0);
            this.dgvCariHesaplar.MainView = this.gridViewCariHesaplar;
            this.dgvCariHesaplar.Name = "dgvCariHesaplar";
            this.dgvCariHesaplar.Size = new System.Drawing.Size(756, 431);
            this.dgvCariHesaplar.TabIndex = 0;
            this.dgvCariHesaplar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCariHesaplar});
            this.dgvCariHesaplar.DoubleClick += new System.EventHandler(this.dgvCariHesaplar_DoubleClick);
            // 
            // bsCariHesaplar
            // 
            this.bsCariHesaplar.DataMember = "tblCariHesaplar";
            this.bsCariHesaplar.DataSource = this.myDataSet;
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "myDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewCariHesaplar
            // 
            this.gridViewCariHesaplar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCariID,
            this.colUnvan,
            this.colVergiNo,
            this.colVergiDairesi,
            this.colAdres,
            this.colTelefon,
            this.colMail});
            this.gridViewCariHesaplar.GridControl = this.dgvCariHesaplar;
            this.gridViewCariHesaplar.Name = "gridViewCariHesaplar";
            this.gridViewCariHesaplar.OptionsBehavior.Editable = false;
            this.gridViewCariHesaplar.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCariHesaplar.OptionsView.ShowFooter = true;
            // 
            // colCariID
            // 
            this.colCariID.FieldName = "CariID";
            this.colCariID.MinWidth = 25;
            this.colCariID.Name = "colCariID";
            this.colCariID.Visible = true;
            this.colCariID.VisibleIndex = 0;
            this.colCariID.Width = 94;
            // 
            // colUnvan
            // 
            this.colUnvan.FieldName = "Unvan";
            this.colUnvan.MinWidth = 25;
            this.colUnvan.Name = "colUnvan";
            this.colUnvan.Visible = true;
            this.colUnvan.VisibleIndex = 1;
            this.colUnvan.Width = 94;
            // 
            // colVergiNo
            // 
            this.colVergiNo.FieldName = "VergiNo";
            this.colVergiNo.MinWidth = 25;
            this.colVergiNo.Name = "colVergiNo";
            this.colVergiNo.Visible = true;
            this.colVergiNo.VisibleIndex = 2;
            this.colVergiNo.Width = 94;
            // 
            // colVergiDairesi
            // 
            this.colVergiDairesi.FieldName = "VergiDairesi";
            this.colVergiDairesi.MinWidth = 25;
            this.colVergiDairesi.Name = "colVergiDairesi";
            this.colVergiDairesi.Visible = true;
            this.colVergiDairesi.VisibleIndex = 3;
            this.colVergiDairesi.Width = 94;
            // 
            // colAdres
            // 
            this.colAdres.FieldName = "Adres";
            this.colAdres.MinWidth = 25;
            this.colAdres.Name = "colAdres";
            this.colAdres.Visible = true;
            this.colAdres.VisibleIndex = 4;
            this.colAdres.Width = 94;
            // 
            // colTelefon
            // 
            this.colTelefon.FieldName = "Telefon";
            this.colTelefon.MinWidth = 25;
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.Visible = true;
            this.colTelefon.VisibleIndex = 5;
            this.colTelefon.Width = 94;
            // 
            // colMail
            // 
            this.colMail.FieldName = "Mail";
            this.colMail.MinWidth = 25;
            this.colMail.Name = "colMail";
            this.colMail.Visible = true;
            this.colMail.VisibleIndex = 6;
            this.colMail.Width = 94;
            // 
            // con
            // 
            this.con.FireInfoMessageEventOnUserErrors = false;
            // 
            // CariHesaplarLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 431);
            this.Controls.Add(this.dgvCariHesaplar);
            this.Name = "CariHesaplarLists";
            this.Text = "Cari Hesap Seç";
            this.Load += new System.EventHandler(this.CariHesaplarLists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariHesaplar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCariHesaplar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCariHesaplar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvCariHesaplar;
        private myDataSet myDataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCariHesaplar;
        private DevExpress.XtraGrid.Columns.GridColumn colCariID;
        private DevExpress.XtraGrid.Columns.GridColumn colUnvan;
        private DevExpress.XtraGrid.Columns.GridColumn colVergiNo;
        private DevExpress.XtraGrid.Columns.GridColumn colVergiDairesi;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon;
        private DevExpress.XtraGrid.Columns.GridColumn colMail;
        private System.Data.SqlClient.SqlConnection con;
        public System.Windows.Forms.BindingSource bsCariHesaplar;
    }
}