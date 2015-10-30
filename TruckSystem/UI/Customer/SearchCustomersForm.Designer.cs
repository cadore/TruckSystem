namespace TruckSystem.UI.Customer
{
    partial class SearchCustomersForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCustomersForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSearch = new WCButtons.Black.ButtonSearchBlack();
            this.tfSearch = new DevExpress.XtraEditors.TextEdit();
            this.rgSearch = new DevExpress.XtraEditors.RadioGroup();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bdgCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcorporate_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfantasy_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldocument = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladdress_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colregistred_at = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colregistred_by = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinactive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colie_rg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colphone_fixed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colphone_mobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnSelect = new WCButtons.Black.ButtonConfirmBlack();
            this.btnCancel = new WCButtons.Black.ButtonCancelBlack();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSearch);
            this.panelControl1.Controls.Add(this.tfSearch);
            this.panelControl1.Controls.Add(this.rgSearch);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1024, 44);
            this.panelControl1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(791, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 33);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tfSearch
            // 
            this.tfSearch.Location = new System.Drawing.Point(172, 12);
            this.tfSearch.Name = "tfSearch";
            this.tfSearch.Size = new System.Drawing.Size(613, 20);
            this.tfSearch.TabIndex = 1;
            this.tfSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tfSearch_KeyDown);
            // 
            // rgSearch
            // 
            this.rgSearch.Location = new System.Drawing.Point(5, 9);
            this.rgSearch.Name = "rgSearch";
            this.rgSearch.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgSearch.Properties.Appearance.Options.UseBackColor = true;
            this.rgSearch.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.rgSearch.Properties.Columns = 3;
            this.rgSearch.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("id", "Cod."),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("name", "Nome"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("cnpj", "CNPJ")});
            this.rgSearch.Size = new System.Drawing.Size(161, 26);
            this.rgSearch.TabIndex = 0;
            this.rgSearch.SelectedIndexChanged += new System.EventHandler(this.rgSearch_SelectedIndexChanged);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 44);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1024, 465);
            this.panelControl2.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bdgCustomer;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1020, 419);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.btnSelect_Click);
            // 
            // bdgCustomer
            // 
            this.bdgCustomer.DataSource = typeof(TruckSystem.customer);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcorporate_name,
            this.colfantasy_name,
            this.coldocument,
            this.coladdress_id,
            this.colregistred_at,
            this.colregistred_by,
            this.colinactive,
            this.colie_rg,
            this.colphone_fixed,
            this.colphone_mobile});
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
            this.colid.Width = 53;
            // 
            // colcorporate_name
            // 
            this.colcorporate_name.Caption = "Razão Social/Nome";
            this.colcorporate_name.FieldName = "corporate_name";
            this.colcorporate_name.Name = "colcorporate_name";
            this.colcorporate_name.OptionsColumn.AllowEdit = false;
            this.colcorporate_name.Visible = true;
            this.colcorporate_name.VisibleIndex = 1;
            this.colcorporate_name.Width = 288;
            // 
            // colfantasy_name
            // 
            this.colfantasy_name.Caption = "Nome Fantasia/Sobrenome";
            this.colfantasy_name.FieldName = "fantasy_name";
            this.colfantasy_name.Name = "colfantasy_name";
            this.colfantasy_name.OptionsColumn.AllowEdit = false;
            this.colfantasy_name.Visible = true;
            this.colfantasy_name.VisibleIndex = 2;
            this.colfantasy_name.Width = 234;
            // 
            // coldocument
            // 
            this.coldocument.Caption = "CNPJ/CPF";
            this.coldocument.FieldName = "document";
            this.coldocument.Name = "coldocument";
            this.coldocument.OptionsColumn.AllowEdit = false;
            this.coldocument.Visible = true;
            this.coldocument.VisibleIndex = 3;
            this.coldocument.Width = 149;
            // 
            // coladdress_id
            // 
            this.coladdress_id.FieldName = "address_id";
            this.coladdress_id.Name = "coladdress_id";
            this.coladdress_id.OptionsColumn.AllowEdit = false;
            // 
            // colregistred_at
            // 
            this.colregistred_at.FieldName = "registred_at";
            this.colregistred_at.Name = "colregistred_at";
            this.colregistred_at.OptionsColumn.AllowEdit = false;
            // 
            // colregistred_by
            // 
            this.colregistred_by.FieldName = "registred_by";
            this.colregistred_by.Name = "colregistred_by";
            this.colregistred_by.OptionsColumn.AllowEdit = false;
            // 
            // colinactive
            // 
            this.colinactive.FieldName = "inactive";
            this.colinactive.Name = "colinactive";
            this.colinactive.OptionsColumn.AllowEdit = false;
            // 
            // colie_rg
            // 
            this.colie_rg.FieldName = "ie_rg";
            this.colie_rg.Name = "colie_rg";
            this.colie_rg.OptionsColumn.AllowEdit = false;
            // 
            // colphone_fixed
            // 
            this.colphone_fixed.Caption = "Telefone";
            this.colphone_fixed.FieldName = "phone_fixed";
            this.colphone_fixed.Name = "colphone_fixed";
            this.colphone_fixed.OptionsColumn.AllowEdit = false;
            this.colphone_fixed.Visible = true;
            this.colphone_fixed.VisibleIndex = 4;
            this.colphone_fixed.Width = 126;
            // 
            // colphone_mobile
            // 
            this.colphone_mobile.Caption = "Celular";
            this.colphone_mobile.FieldName = "phone_mobile";
            this.colphone_mobile.Name = "colphone_mobile";
            this.colphone_mobile.OptionsColumn.AllowEdit = false;
            this.colphone_mobile.Visible = true;
            this.colphone_mobile.VisibleIndex = 5;
            this.colphone_mobile.Width = 152;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnSelect);
            this.panelControl3.Controls.Add(this.btnCancel);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 466);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1024, 43);
            this.panelControl3.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.Location = new System.Drawing.Point(791, 5);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(113, 33);
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
            this.btnCancel.Location = new System.Drawing.Point(909, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 33);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SearchCustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "SearchCustomersForm";
            this.Size = new System.Drawing.Size(1024, 509);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tfSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private WCButtons.Black.ButtonSearchBlack btnSearch;
        private DevExpress.XtraEditors.TextEdit tfSearch;
        private DevExpress.XtraEditors.RadioGroup rgSearch;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private WCButtons.Black.ButtonConfirmBlack btnSelect;
        private WCButtons.Black.ButtonCancelBlack btnCancel;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource bdgCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcorporate_name;
        private DevExpress.XtraGrid.Columns.GridColumn colfantasy_name;
        private DevExpress.XtraGrid.Columns.GridColumn coldocument;
        private DevExpress.XtraGrid.Columns.GridColumn coladdress_id;
        private DevExpress.XtraGrid.Columns.GridColumn colregistred_at;
        private DevExpress.XtraGrid.Columns.GridColumn colregistred_by;
        private DevExpress.XtraGrid.Columns.GridColumn colinactive;
        private DevExpress.XtraGrid.Columns.GridColumn colie_rg;
        private DevExpress.XtraGrid.Columns.GridColumn colphone_fixed;
        private DevExpress.XtraGrid.Columns.GridColumn colphone_mobile;
    }
}
