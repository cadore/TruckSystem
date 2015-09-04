namespace TruckSystem.UI.Drivers
{
    partial class SearchDriversForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchDriversForm));
            this.pnButtons = new DevExpress.XtraEditors.PanelControl();
            this.btnSelect = new WCButtons.Black.ButtonConfirmBlack();
            this.btnCancel = new WCButtons.Black.ButtonCancelBlack();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tfSearch = new DevExpress.XtraEditors.TextEdit();
            this.rgTypeSearch = new DevExpress.XtraEditors.RadioGroup();
            this.lbTypeSearch = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new WCButtons.Black.ButtonSearchBlack();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bdgDrivers = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfull_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcpf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladdress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbirthday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumber_cnh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcategory_cnh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgenre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colphone_fixed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colphone_mobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinactive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colregistred_at = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colregistred_by = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcomission = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladmitted_at = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldismissed_at = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnButtons)).BeginInit();
            this.pnButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTypeSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnButtons
            // 
            this.pnButtons.Controls.Add(this.btnSelect);
            this.pnButtons.Controls.Add(this.btnCancel);
            this.pnButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnButtons.Location = new System.Drawing.Point(0, 406);
            this.pnButtons.Name = "pnButtons";
            this.pnButtons.Size = new System.Drawing.Size(978, 45);
            this.pnButtons.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.Location = new System.Drawing.Point(743, 6);
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
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(863, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 33);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.tfSearch);
            this.panelControl1.Controls.Add(this.rgTypeSearch);
            this.panelControl1.Controls.Add(this.lbTypeSearch);
            this.panelControl1.Controls.Add(this.btnSearch);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(978, 43);
            this.panelControl1.TabIndex = 1;
            // 
            // tfSearch
            // 
            this.tfSearch.Location = new System.Drawing.Point(204, 14);
            this.tfSearch.Name = "tfSearch";
            this.tfSearch.Size = new System.Drawing.Size(653, 20);
            this.tfSearch.TabIndex = 3;
            this.tfSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tfSearch_KeyDown);
            // 
            // rgTypeSearch
            // 
            this.rgTypeSearch.Location = new System.Drawing.Point(5, 11);
            this.rgTypeSearch.Name = "rgTypeSearch";
            this.rgTypeSearch.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgTypeSearch.Properties.Appearance.Options.UseBackColor = true;
            this.rgTypeSearch.Properties.Columns = 2;
            this.rgTypeSearch.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("name", "Nome"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("cpf", "CPF")});
            this.rgTypeSearch.Size = new System.Drawing.Size(108, 25);
            this.rgTypeSearch.TabIndex = 2;
            this.rgTypeSearch.SelectedIndexChanged += new System.EventHandler(this.rgTypeSearch_SelectedIndexChanged);
            // 
            // lbTypeSearch
            // 
            this.lbTypeSearch.Location = new System.Drawing.Point(123, 17);
            this.lbTypeSearch.Name = "lbTypeSearch";
            this.lbTypeSearch.Size = new System.Drawing.Size(79, 13);
            this.lbTypeSearch.TabIndex = 1;
            this.lbTypeSearch.Text = "Nome Completo:";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(863, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 33);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 43);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(978, 363);
            this.panelControl2.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bdgDrivers;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(974, 359);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.btnSelect_Click);
            // 
            // bdgDrivers
            // 
            this.bdgDrivers.DataSource = typeof(TruckSystem.driver);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colfull_name,
            this.colcpf,
            this.coladdress,
            this.colbirthday,
            this.colnumber_cnh,
            this.colcategory_cnh,
            this.colgenre,
            this.colphone_fixed,
            this.colphone_mobile,
            this.colinactive,
            this.colregistred_at,
            this.colregistred_by,
            this.colcomission,
            this.coladmitted_at,
            this.coldismissed_at});
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
            this.colid.Width = 44;
            // 
            // colfull_name
            // 
            this.colfull_name.Caption = "Nome Completo";
            this.colfull_name.FieldName = "full_name";
            this.colfull_name.Name = "colfull_name";
            this.colfull_name.OptionsColumn.AllowEdit = false;
            this.colfull_name.Visible = true;
            this.colfull_name.VisibleIndex = 1;
            this.colfull_name.Width = 230;
            // 
            // colcpf
            // 
            this.colcpf.Caption = "CPF";
            this.colcpf.FieldName = "cpf";
            this.colcpf.Name = "colcpf";
            this.colcpf.OptionsColumn.AllowEdit = false;
            this.colcpf.Visible = true;
            this.colcpf.VisibleIndex = 2;
            this.colcpf.Width = 132;
            // 
            // coladdress
            // 
            this.coladdress.FieldName = "address";
            this.coladdress.Name = "coladdress";
            this.coladdress.OptionsColumn.AllowEdit = false;
            this.coladdress.Width = 91;
            // 
            // colbirthday
            // 
            this.colbirthday.Caption = "Data Nascimento";
            this.colbirthday.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colbirthday.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colbirthday.FieldName = "birthday";
            this.colbirthday.Name = "colbirthday";
            this.colbirthday.OptionsColumn.AllowEdit = false;
            this.colbirthday.Visible = true;
            this.colbirthday.VisibleIndex = 3;
            this.colbirthday.Width = 94;
            // 
            // colnumber_cnh
            // 
            this.colnumber_cnh.FieldName = "number_cnh";
            this.colnumber_cnh.Name = "colnumber_cnh";
            this.colnumber_cnh.OptionsColumn.AllowEdit = false;
            // 
            // colcategory_cnh
            // 
            this.colcategory_cnh.FieldName = "category_cnh";
            this.colcategory_cnh.Name = "colcategory_cnh";
            this.colcategory_cnh.OptionsColumn.AllowEdit = false;
            this.colcategory_cnh.Width = 73;
            // 
            // colgenre
            // 
            this.colgenre.FieldName = "genre";
            this.colgenre.Name = "colgenre";
            this.colgenre.OptionsColumn.AllowEdit = false;
            this.colgenre.Width = 83;
            // 
            // colphone_fixed
            // 
            this.colphone_fixed.Caption = "Fixo";
            this.colphone_fixed.FieldName = "phone_fixed";
            this.colphone_fixed.Name = "colphone_fixed";
            this.colphone_fixed.OptionsColumn.AllowEdit = false;
            this.colphone_fixed.Visible = true;
            this.colphone_fixed.VisibleIndex = 4;
            this.colphone_fixed.Width = 85;
            // 
            // colphone_mobile
            // 
            this.colphone_mobile.Caption = "Celular";
            this.colphone_mobile.FieldName = "phone_mobile";
            this.colphone_mobile.Name = "colphone_mobile";
            this.colphone_mobile.OptionsColumn.AllowEdit = false;
            this.colphone_mobile.Visible = true;
            this.colphone_mobile.VisibleIndex = 5;
            this.colphone_mobile.Width = 85;
            // 
            // colinactive
            // 
            this.colinactive.Caption = "Inativo";
            this.colinactive.FieldName = "inactive";
            this.colinactive.Name = "colinactive";
            this.colinactive.OptionsColumn.AllowEdit = false;
            this.colinactive.Visible = true;
            this.colinactive.VisibleIndex = 6;
            this.colinactive.Width = 85;
            // 
            // colregistred_at
            // 
            this.colregistred_at.FieldName = "registred_at";
            this.colregistred_at.Name = "colregistred_at";
            this.colregistred_at.OptionsColumn.AllowEdit = false;
            this.colregistred_at.Width = 54;
            // 
            // colregistred_by
            // 
            this.colregistred_by.FieldName = "registred_by";
            this.colregistred_by.Name = "colregistred_by";
            this.colregistred_by.OptionsColumn.AllowEdit = false;
            this.colregistred_by.Width = 54;
            // 
            // colcomission
            // 
            this.colcomission.FieldName = "comission";
            this.colcomission.Name = "colcomission";
            this.colcomission.OptionsColumn.AllowEdit = false;
            this.colcomission.Width = 118;
            // 
            // coladmitted_at
            // 
            this.coladmitted_at.FieldName = "admitted_at";
            this.coladmitted_at.Name = "coladmitted_at";
            this.coladmitted_at.OptionsColumn.AllowEdit = false;
            this.coladmitted_at.Width = 54;
            // 
            // coldismissed_at
            // 
            this.coldismissed_at.FieldName = "dismissed_at";
            this.coldismissed_at.Name = "coldismissed_at";
            this.coldismissed_at.OptionsColumn.AllowEdit = false;
            this.coldismissed_at.Width = 82;
            // 
            // SearchDriversForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.pnButtons);
            this.Name = "SearchDriversForm";
            this.Size = new System.Drawing.Size(978, 451);
            ((System.ComponentModel.ISupportInitialize)(this.pnButtons)).EndInit();
            this.pnButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTypeSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnButtons;
        private WCButtons.Black.ButtonConfirmBlack btnSelect;
        private WCButtons.Black.ButtonCancelBlack btnCancel;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private WCButtons.Black.ButtonSearchBlack btnSearch;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource bdgDrivers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colfull_name;
        private DevExpress.XtraGrid.Columns.GridColumn colcpf;
        private DevExpress.XtraGrid.Columns.GridColumn coladdress;
        private DevExpress.XtraGrid.Columns.GridColumn colbirthday;
        private DevExpress.XtraGrid.Columns.GridColumn colnumber_cnh;
        private DevExpress.XtraGrid.Columns.GridColumn colcategory_cnh;
        private DevExpress.XtraGrid.Columns.GridColumn colgenre;
        private DevExpress.XtraGrid.Columns.GridColumn colphone_fixed;
        private DevExpress.XtraGrid.Columns.GridColumn colphone_mobile;
        private DevExpress.XtraGrid.Columns.GridColumn colinactive;
        private DevExpress.XtraGrid.Columns.GridColumn colregistred_at;
        private DevExpress.XtraGrid.Columns.GridColumn colregistred_by;
        private DevExpress.XtraGrid.Columns.GridColumn colcomission;
        private DevExpress.XtraGrid.Columns.GridColumn coladmitted_at;
        private DevExpress.XtraGrid.Columns.GridColumn coldismissed_at;
        private DevExpress.XtraEditors.TextEdit tfSearch;
        private DevExpress.XtraEditors.RadioGroup rgTypeSearch;
        private DevExpress.XtraEditors.LabelControl lbTypeSearch;
    }
}
