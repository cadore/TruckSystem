namespace TruckSystem.UI.Business
{
    partial class SearchBusinessForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBusinessForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bdgBusiness = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcorporate_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfantasy_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldocument = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinactive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colphone_fixed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colphone_mobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmanager = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcontact_manager = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tfSearch = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnSelect = new WCButtons.Black.ButtonConfirmBlack();
            this.btnCancel = new WCButtons.Black.ButtonCancelBlack();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgBusiness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.tfSearch);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(879, 317);
            this.panelControl1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bdgBusiness;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(2, 35);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(875, 280);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.btnSelect_Click);
            // 
            // bdgBusiness
            // 
            this.bdgBusiness.DataSource = typeof(TruckSystem.business);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcorporate_name,
            this.colfantasy_name,
            this.coldocument,
            this.colinactive,
            this.colphone_fixed,
            this.colphone_mobile,
            this.colemail,
            this.colmanager,
            this.colcontact_manager});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colid
            // 
            this.colid.Caption = "Cod.";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 80;
            // 
            // colcorporate_name
            // 
            this.colcorporate_name.Caption = "Razão Social";
            this.colcorporate_name.FieldName = "corporate_name";
            this.colcorporate_name.Name = "colcorporate_name";
            this.colcorporate_name.OptionsColumn.AllowEdit = false;
            this.colcorporate_name.Visible = true;
            this.colcorporate_name.VisibleIndex = 1;
            this.colcorporate_name.Width = 290;
            // 
            // colfantasy_name
            // 
            this.colfantasy_name.Caption = "Nome Fantasia";
            this.colfantasy_name.FieldName = "fantasy_name";
            this.colfantasy_name.Name = "colfantasy_name";
            this.colfantasy_name.OptionsColumn.AllowEdit = false;
            this.colfantasy_name.Visible = true;
            this.colfantasy_name.VisibleIndex = 2;
            this.colfantasy_name.Width = 221;
            // 
            // coldocument
            // 
            this.coldocument.Caption = "Documento";
            this.coldocument.FieldName = "document";
            this.coldocument.Name = "coldocument";
            this.coldocument.OptionsColumn.AllowEdit = false;
            this.coldocument.Visible = true;
            this.coldocument.VisibleIndex = 3;
            this.coldocument.Width = 152;
            // 
            // colinactive
            // 
            this.colinactive.Caption = "Inativo";
            this.colinactive.FieldName = "inactive";
            this.colinactive.Name = "colinactive";
            this.colinactive.OptionsColumn.AllowEdit = false;
            this.colinactive.Visible = true;
            this.colinactive.VisibleIndex = 4;
            this.colinactive.Width = 114;
            // 
            // colphone_fixed
            // 
            this.colphone_fixed.FieldName = "phone_fixed";
            this.colphone_fixed.Name = "colphone_fixed";
            this.colphone_fixed.OptionsColumn.AllowEdit = false;
            this.colphone_fixed.Width = 77;
            // 
            // colphone_mobile
            // 
            this.colphone_mobile.FieldName = "phone_mobile";
            this.colphone_mobile.Name = "colphone_mobile";
            this.colphone_mobile.OptionsColumn.AllowEdit = false;
            this.colphone_mobile.Width = 77;
            // 
            // colemail
            // 
            this.colemail.Caption = "Email";
            this.colemail.FieldName = "email";
            this.colemail.Name = "colemail";
            this.colemail.OptionsColumn.AllowEdit = false;
            this.colemail.Width = 78;
            // 
            // colmanager
            // 
            this.colmanager.Caption = "Gerente";
            this.colmanager.FieldName = "manager";
            this.colmanager.Name = "colmanager";
            this.colmanager.OptionsColumn.AllowEdit = false;
            this.colmanager.Width = 126;
            // 
            // colcontact_manager
            // 
            this.colcontact_manager.Caption = "Contato Gerente";
            this.colcontact_manager.FieldName = "contact_manager";
            this.colcontact_manager.Name = "colcontact_manager";
            this.colcontact_manager.OptionsColumn.AllowEdit = false;
            this.colcontact_manager.Width = 105;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(95, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Razão Social/Nome:";
            // 
            // tfSearch
            // 
            this.tfSearch.Location = new System.Drawing.Point(113, 9);
            this.tfSearch.Name = "tfSearch";
            this.tfSearch.Size = new System.Drawing.Size(754, 20);
            this.tfSearch.TabIndex = 0;
            this.tfSearch.EditValueChanged += new System.EventHandler(this.tfSearch_EditValueChanged);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnSelect);
            this.panelControl2.Controls.Add(this.btnCancel);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 317);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(879, 46);
            this.panelControl2.TabIndex = 1;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.Location = new System.Drawing.Point(637, 6);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(114, 33);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Selecionar";
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(757, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 33);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SearchBusinessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 363);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "SearchBusinessForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Empresas";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgBusiness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private WCButtons.Black.ButtonCancelBlack btnCancel;
        private WCButtons.Black.ButtonConfirmBlack btnSelect;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tfSearch;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bdgBusiness;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcorporate_name;
        private DevExpress.XtraGrid.Columns.GridColumn colfantasy_name;
        private DevExpress.XtraGrid.Columns.GridColumn coldocument;
        private DevExpress.XtraGrid.Columns.GridColumn colinactive;
        private DevExpress.XtraGrid.Columns.GridColumn colphone_fixed;
        private DevExpress.XtraGrid.Columns.GridColumn colphone_mobile;
        private DevExpress.XtraGrid.Columns.GridColumn colemail;
        private DevExpress.XtraGrid.Columns.GridColumn colmanager;
        private DevExpress.XtraGrid.Columns.GridColumn colcontact_manager;
    }
}