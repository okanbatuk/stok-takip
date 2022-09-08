
namespace StokTakip
{
    partial class FaturaLists
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
            this.dgvFatura = new DevExpress.XtraGrid.GridControl();
            this.dgvMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.bsFatura = new System.Windows.Forms.BindingSource(this.components);
            this.myDataSet = new StokTakip.myDataSet();
            this.gridViewFatura = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFaturaID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFaturaTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFaturaNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAraToplam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGenelToplam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKdvToplam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.con = new System.Data.SqlClient.SqlConnection();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFatura)).BeginInit();
            this.dgvMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsFatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFatura)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFatura
            // 
            this.dgvFatura.ContextMenuStrip = this.dgvMenu;
            this.dgvFatura.DataSource = this.bsFatura;
            this.dgvFatura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFatura.Location = new System.Drawing.Point(0, 0);
            this.dgvFatura.MainView = this.gridViewFatura;
            this.dgvFatura.Name = "dgvFatura";
            this.dgvFatura.Size = new System.Drawing.Size(700, 332);
            this.dgvFatura.TabIndex = 0;
            this.dgvFatura.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFatura});
            // 
            // dgvMenu
            // 
            this.dgvMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dgvMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUpdate,
            this.menuDelete,
            this.menuPrint});
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.Size = new System.Drawing.Size(211, 104);
            this.dgvMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.dgvMenu_ItemClicked);
            // 
            // menuUpdate
            // 
            this.menuUpdate.Name = "menuUpdate";
            this.menuUpdate.Size = new System.Drawing.Size(210, 24);
            this.menuUpdate.Text = "Update";
            // 
            // menuDelete
            // 
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.Size = new System.Drawing.Size(210, 24);
            this.menuDelete.Text = "Delete";
            // 
            // menuPrint
            // 
            this.menuPrint.Name = "menuPrint";
            this.menuPrint.Size = new System.Drawing.Size(210, 24);
            this.menuPrint.Text = "Print";
            // 
            // bsFatura
            // 
            this.bsFatura.DataMember = "tblFatura";
            this.bsFatura.DataSource = this.myDataSet;
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "myDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewFatura
            // 
            this.gridViewFatura.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFaturaID,
            this.colCariID,
            this.colFaturaTarihi,
            this.colFaturaNo,
            this.colAraToplam,
            this.colGenelToplam,
            this.colKdvToplam});
            this.gridViewFatura.GridControl = this.dgvFatura;
            this.gridViewFatura.Name = "gridViewFatura";
            this.gridViewFatura.OptionsBehavior.Editable = false;
            this.gridViewFatura.OptionsView.ShowAutoFilterRow = true;
            this.gridViewFatura.OptionsView.ShowFooter = true;
            // 
            // colFaturaID
            // 
            this.colFaturaID.FieldName = "FaturaID";
            this.colFaturaID.MinWidth = 25;
            this.colFaturaID.Name = "colFaturaID";
            this.colFaturaID.Visible = true;
            this.colFaturaID.VisibleIndex = 0;
            this.colFaturaID.Width = 94;
            // 
            // colCariID
            // 
            this.colCariID.FieldName = "CariID";
            this.colCariID.MinWidth = 25;
            this.colCariID.Name = "colCariID";
            this.colCariID.Visible = true;
            this.colCariID.VisibleIndex = 1;
            this.colCariID.Width = 94;
            // 
            // colFaturaTarihi
            // 
            this.colFaturaTarihi.FieldName = "FaturaTarihi";
            this.colFaturaTarihi.MinWidth = 25;
            this.colFaturaTarihi.Name = "colFaturaTarihi";
            this.colFaturaTarihi.Visible = true;
            this.colFaturaTarihi.VisibleIndex = 2;
            this.colFaturaTarihi.Width = 94;
            // 
            // colFaturaNo
            // 
            this.colFaturaNo.FieldName = "FaturaNo";
            this.colFaturaNo.MinWidth = 25;
            this.colFaturaNo.Name = "colFaturaNo";
            this.colFaturaNo.Visible = true;
            this.colFaturaNo.VisibleIndex = 3;
            this.colFaturaNo.Width = 94;
            // 
            // colAraToplam
            // 
            this.colAraToplam.FieldName = "AraToplam";
            this.colAraToplam.MinWidth = 25;
            this.colAraToplam.Name = "colAraToplam";
            this.colAraToplam.Visible = true;
            this.colAraToplam.VisibleIndex = 4;
            this.colAraToplam.Width = 94;
            // 
            // colGenelToplam
            // 
            this.colGenelToplam.FieldName = "GenelToplam";
            this.colGenelToplam.MinWidth = 25;
            this.colGenelToplam.Name = "colGenelToplam";
            this.colGenelToplam.Visible = true;
            this.colGenelToplam.VisibleIndex = 5;
            this.colGenelToplam.Width = 94;
            // 
            // colKdvToplam
            // 
            this.colKdvToplam.FieldName = "KdvToplam";
            this.colKdvToplam.MinWidth = 25;
            this.colKdvToplam.Name = "colKdvToplam";
            this.colKdvToplam.Visible = true;
            this.colKdvToplam.VisibleIndex = 6;
            this.colKdvToplam.Width = 94;
            // 
            // con
            // 
            this.con.FireInfoMessageEventOnUserErrors = false;
            // 
            // FaturaLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 332);
            this.Controls.Add(this.dgvFatura);
            this.Name = "FaturaLists";
            this.Text = "FaturaLists";
            this.Load += new System.EventHandler(this.FaturaLists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFatura)).EndInit();
            this.dgvMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsFatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFatura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvFatura;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFatura;
        private System.Windows.Forms.BindingSource bsFatura;
        private myDataSet myDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colFaturaID;
        private DevExpress.XtraGrid.Columns.GridColumn colCariID;
        private DevExpress.XtraGrid.Columns.GridColumn colFaturaTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colFaturaNo;
        private DevExpress.XtraGrid.Columns.GridColumn colAraToplam;
        private DevExpress.XtraGrid.Columns.GridColumn colGenelToplam;
        private DevExpress.XtraGrid.Columns.GridColumn colKdvToplam;
        private System.Data.SqlClient.SqlConnection con;
        private System.Windows.Forms.ContextMenuStrip dgvMenu;
        private System.Windows.Forms.ToolStripMenuItem menuDelete;
        private System.Windows.Forms.ToolStripMenuItem menuPrint;
        private System.Windows.Forms.ToolStripMenuItem menuUpdate;
    }
}