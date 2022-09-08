
namespace StokTakip
{
    partial class Birimler
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
            this.txtBirim = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.dgvBirim = new DevExpress.XtraGrid.GridControl();
            this.dgvMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuChange = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.bsBirim = new System.Windows.Forms.BindingSource(this.components);
            this.myDataSet = new StokTakip.myDataSet();
            this.gridViewBirim = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBirimID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.con = new System.Data.SqlClient.SqlConnection();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBirim)).BeginInit();
            this.dgvMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBirim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBirim)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.txtBirim);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvBirim);
            this.splitContainer1.Size = new System.Drawing.Size(804, 435);
            this.splitContainer1.SplitterDistance = 83;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(300, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBirim
            // 
            this.txtBirim.Location = new System.Drawing.Point(144, 22);
            this.txtBirim.Name = "txtBirim";
            this.txtBirim.Size = new System.Drawing.Size(125, 22);
            this.txtBirim.TabIndex = 1;
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "Birim Adi";
            this.textEdit1.Location = new System.Drawing.Point(13, 22);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Size = new System.Drawing.Size(125, 22);
            this.textEdit1.TabIndex = 0;
            // 
            // dgvBirim
            // 
            this.dgvBirim.ContextMenuStrip = this.dgvMenu;
            this.dgvBirim.DataSource = this.bsBirim;
            this.dgvBirim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBirim.Location = new System.Drawing.Point(0, 0);
            this.dgvBirim.MainView = this.gridViewBirim;
            this.dgvBirim.Name = "dgvBirim";
            this.dgvBirim.Size = new System.Drawing.Size(804, 348);
            this.dgvBirim.TabIndex = 0;
            this.dgvBirim.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBirim});
            // 
            // dgvMenu
            // 
            this.dgvMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dgvMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuChange,
            this.menuDelete});
            this.dgvMenu.Name = "contextMenuStrip1";
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
            // gridViewBirim
            // 
            this.gridViewBirim.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBirimID,
            this.colBirimAdi});
            this.gridViewBirim.GridControl = this.dgvBirim;
            this.gridViewBirim.Name = "gridViewBirim";
            this.gridViewBirim.OptionsBehavior.Editable = false;
            this.gridViewBirim.OptionsView.ShowAutoFilterRow = true;
            // 
            // colBirimID
            // 
            this.colBirimID.FieldName = "BirimID";
            this.colBirimID.MinWidth = 25;
            this.colBirimID.Name = "colBirimID";
            this.colBirimID.Visible = true;
            this.colBirimID.VisibleIndex = 0;
            this.colBirimID.Width = 94;
            // 
            // colBirimAdi
            // 
            this.colBirimAdi.FieldName = "BirimAdi";
            this.colBirimAdi.MinWidth = 25;
            this.colBirimAdi.Name = "colBirimAdi";
            this.colBirimAdi.Visible = true;
            this.colBirimAdi.VisibleIndex = 1;
            this.colBirimAdi.Width = 94;
            // 
            // con
            // 
            this.con.FireInfoMessageEventOnUserErrors = false;
            // 
            // Birimler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 435);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Birimler";
            this.Text = "Birimler";
            this.Load += new System.EventHandler(this.Birimler_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtBirim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBirim)).EndInit();
            this.dgvMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsBirim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBirim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtBirim;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraGrid.GridControl dgvBirim;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBirim;
        private myDataSet myDataSet;
        private System.Data.SqlClient.SqlConnection con;
        private System.Windows.Forms.BindingSource bsBirim;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimID;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimAdi;
        private System.Windows.Forms.ContextMenuStrip dgvMenu;
        private System.Windows.Forms.ToolStripMenuItem menuChange;
        private System.Windows.Forms.ToolStripMenuItem menuDelete;
    }
}