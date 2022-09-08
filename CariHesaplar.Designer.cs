
namespace StokTakip
{
    partial class CariHesaplar
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
            this.txtMail = new DevExpress.XtraEditors.TextEdit();
            this.txtTelefon = new DevExpress.XtraEditors.TextEdit();
            this.txtAdres = new DevExpress.XtraEditors.TextEdit();
            this.textEdit10 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit11 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit12 = new DevExpress.XtraEditors.TextEdit();
            this.txtVergiDairesi = new DevExpress.XtraEditors.TextEdit();
            this.txtVergiNo = new DevExpress.XtraEditors.TextEdit();
            this.txtUnvan = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.dgvCariHesaplar = new DevExpress.XtraGrid.GridControl();
            this.dgvListe = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuChange = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit10.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit11.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit12.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiDairesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnvan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariHesaplar)).BeginInit();
            this.dgvListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCariHesaplar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCariHesaplar)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.txtMail);
            this.splitContainer1.Panel1.Controls.Add(this.txtTelefon);
            this.splitContainer1.Panel1.Controls.Add(this.txtAdres);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit10);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit11);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit12);
            this.splitContainer1.Panel1.Controls.Add(this.txtVergiDairesi);
            this.splitContainer1.Panel1.Controls.Add(this.txtVergiNo);
            this.splitContainer1.Panel1.Controls.Add(this.txtUnvan);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit3);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit2);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvCariHesaplar);
            this.splitContainer1.Size = new System.Drawing.Size(996, 501);
            this.splitContainer1.SplitterDistance = 183;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(723, 52);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(522, 87);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(125, 22);
            this.txtMail.TabIndex = 11;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(522, 59);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(125, 22);
            this.txtTelefon.TabIndex = 10;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(522, 31);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(125, 22);
            this.txtAdres.TabIndex = 9;
            // 
            // textEdit10
            // 
            this.textEdit10.EditValue = "Mail";
            this.textEdit10.Location = new System.Drawing.Point(363, 87);
            this.textEdit10.Name = "textEdit10";
            this.textEdit10.Properties.ReadOnly = true;
            this.textEdit10.Size = new System.Drawing.Size(125, 22);
            this.textEdit10.TabIndex = 8;
            // 
            // textEdit11
            // 
            this.textEdit11.EditValue = "Telefon";
            this.textEdit11.Location = new System.Drawing.Point(363, 59);
            this.textEdit11.Name = "textEdit11";
            this.textEdit11.Properties.ReadOnly = true;
            this.textEdit11.Size = new System.Drawing.Size(125, 22);
            this.textEdit11.TabIndex = 7;
            // 
            // textEdit12
            // 
            this.textEdit12.EditValue = "Adres";
            this.textEdit12.Location = new System.Drawing.Point(363, 31);
            this.textEdit12.Name = "textEdit12";
            this.textEdit12.Properties.ReadOnly = true;
            this.textEdit12.Size = new System.Drawing.Size(125, 22);
            this.textEdit12.TabIndex = 6;
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Location = new System.Drawing.Point(172, 87);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(125, 22);
            this.txtVergiDairesi.TabIndex = 5;
            // 
            // txtVergiNo
            // 
            this.txtVergiNo.Location = new System.Drawing.Point(172, 59);
            this.txtVergiNo.Name = "txtVergiNo";
            this.txtVergiNo.Size = new System.Drawing.Size(125, 22);
            this.txtVergiNo.TabIndex = 4;
            // 
            // txtUnvan
            // 
            this.txtUnvan.Location = new System.Drawing.Point(172, 31);
            this.txtUnvan.Name = "txtUnvan";
            this.txtUnvan.Size = new System.Drawing.Size(125, 22);
            this.txtUnvan.TabIndex = 3;
            // 
            // textEdit3
            // 
            this.textEdit3.EditValue = "Vergi Dairesi";
            this.textEdit3.Location = new System.Drawing.Point(13, 87);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.ReadOnly = true;
            this.textEdit3.Size = new System.Drawing.Size(125, 22);
            this.textEdit3.TabIndex = 2;
            // 
            // textEdit2
            // 
            this.textEdit2.EditValue = "Vergi Numarasi";
            this.textEdit2.Location = new System.Drawing.Point(13, 59);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.ReadOnly = true;
            this.textEdit2.Size = new System.Drawing.Size(125, 22);
            this.textEdit2.TabIndex = 1;
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "Unvan";
            this.textEdit1.Location = new System.Drawing.Point(13, 31);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Size = new System.Drawing.Size(125, 22);
            this.textEdit1.TabIndex = 0;
            // 
            // dgvCariHesaplar
            // 
            this.dgvCariHesaplar.ContextMenuStrip = this.dgvListe;
            this.dgvCariHesaplar.DataSource = this.bsCariHesaplar;
            this.dgvCariHesaplar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCariHesaplar.Location = new System.Drawing.Point(0, 0);
            this.dgvCariHesaplar.MainView = this.gridViewCariHesaplar;
            this.dgvCariHesaplar.Name = "dgvCariHesaplar";
            this.dgvCariHesaplar.Size = new System.Drawing.Size(996, 314);
            this.dgvCariHesaplar.TabIndex = 0;
            this.dgvCariHesaplar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCariHesaplar});
            // 
            // dgvListe
            // 
            this.dgvListe.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dgvListe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuChange,
            this.menuDelete});
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.Size = new System.Drawing.Size(129, 52);
            this.dgvListe.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.dgvListe_ItemClicked);
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
            // CariHesaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 501);
            this.Controls.Add(this.splitContainer1);
            this.Name = "CariHesaplar";
            this.Text = "Cari Hesaplar";
            this.Load += new System.EventHandler(this.CariHesaplar_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit10.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit11.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit12.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiDairesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnvan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariHesaplar)).EndInit();
            this.dgvListe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsCariHesaplar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCariHesaplar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Data.SqlClient.SqlConnection con;
        private DevExpress.XtraGrid.GridControl dgvCariHesaplar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCariHesaplar;
        private System.Windows.Forms.BindingSource bsCariHesaplar;
        private myDataSet myDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colCariID;
        private DevExpress.XtraGrid.Columns.GridColumn colUnvan;
        private DevExpress.XtraGrid.Columns.GridColumn colVergiNo;
        private DevExpress.XtraGrid.Columns.GridColumn colVergiDairesi;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon;
        private DevExpress.XtraGrid.Columns.GridColumn colMail;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtMail;
        private DevExpress.XtraEditors.TextEdit txtTelefon;
        private DevExpress.XtraEditors.TextEdit txtAdres;
        private DevExpress.XtraEditors.TextEdit textEdit10;
        private DevExpress.XtraEditors.TextEdit textEdit11;
        private DevExpress.XtraEditors.TextEdit textEdit12;
        private DevExpress.XtraEditors.TextEdit txtVergiDairesi;
        private DevExpress.XtraEditors.TextEdit txtVergiNo;
        private DevExpress.XtraEditors.TextEdit txtUnvan;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.ContextMenuStrip dgvListe;
        private System.Windows.Forms.ToolStripMenuItem menuChange;
        private System.Windows.Forms.ToolStripMenuItem menuDelete;
    }
}