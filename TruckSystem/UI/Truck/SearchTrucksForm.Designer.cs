namespace TruckSystem.UI.Truck
{
    partial class SearchTrucksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchTrucksForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSelect = new WCButtons.Black.ButtonConfirmBlack();
            this.btnCancel = new WCButtons.Black.ButtonCancelBlack();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.tfType = new DevExpress.XtraEditors.TextEdit();
            this.cbDriver = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdgDrivers = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfull_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcpf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladdress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbirthday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexpiration_cnh = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.lbType = new DevExpress.XtraEditors.LabelControl();
            this.lbDriver = new DevExpress.XtraEditors.LabelControl();
            this.rgType = new DevExpress.XtraEditors.RadioGroup();
            this.btnSearch = new WCButtons.Black.ButtonSearchBlack();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bdgTrucks = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colboard = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrenavam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colchassi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmodel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colyear_model = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colantt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldriver_name = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDriver.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgTrucks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSelect);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 454);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(992, 44);
            this.panelControl1.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.Location = new System.Drawing.Point(757, 6);
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
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(877, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 33);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.tfType);
            this.panelControl2.Controls.Add(this.cbDriver);
            this.panelControl2.Controls.Add(this.lbType);
            this.panelControl2.Controls.Add(this.lbDriver);
            this.panelControl2.Controls.Add(this.rgType);
            this.panelControl2.Controls.Add(this.btnSearch);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(992, 43);
            this.panelControl2.TabIndex = 1;
            // 
            // tfType
            // 
            this.tfType.Enabled = false;
            this.tfType.Location = new System.Drawing.Point(699, 13);
            this.tfType.Name = "tfType";
            this.tfType.Size = new System.Drawing.Size(121, 20);
            this.tfType.TabIndex = 2;
            this.tfType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tfType_KeyDown);
            // 
            // cbDriver
            // 
            this.cbDriver.Enabled = false;
            this.cbDriver.Location = new System.Drawing.Point(367, 13);
            this.cbDriver.Name = "cbDriver";
            this.cbDriver.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDriver.Properties.DataSource = this.bdgDrivers;
            this.cbDriver.Properties.DisplayMember = "full_name";
            this.cbDriver.Properties.NullText = "";
            this.cbDriver.Properties.ValueMember = "id";
            this.cbDriver.Properties.View = this.searchLookUpEdit1View;
            this.cbDriver.Size = new System.Drawing.Size(289, 20);
            this.cbDriver.TabIndex = 1;
            this.cbDriver.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tfType_KeyDown);
            // 
            // bdgDrivers
            // 
            this.bdgDrivers.DataSource = typeof(TruckSystem.driver);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colfull_name,
            this.colcpf,
            this.coladdress,
            this.colbirthday,
            this.colexpiration_cnh,
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
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.Caption = "Cod.";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 112;
            // 
            // colfull_name
            // 
            this.colfull_name.Caption = "Nome Completo";
            this.colfull_name.FieldName = "full_name";
            this.colfull_name.Name = "colfull_name";
            this.colfull_name.OptionsColumn.AllowEdit = false;
            this.colfull_name.Visible = true;
            this.colfull_name.VisibleIndex = 1;
            this.colfull_name.Width = 481;
            // 
            // colcpf
            // 
            this.colcpf.Caption = "CPF";
            this.colcpf.FieldName = "cpf";
            this.colcpf.Name = "colcpf";
            this.colcpf.OptionsColumn.AllowEdit = false;
            this.colcpf.Visible = true;
            this.colcpf.VisibleIndex = 2;
            this.colcpf.Width = 485;
            // 
            // coladdress
            // 
            this.coladdress.FieldName = "address";
            this.coladdress.Name = "coladdress";
            this.coladdress.OptionsColumn.AllowEdit = false;
            // 
            // colbirthday
            // 
            this.colbirthday.FieldName = "birthday";
            this.colbirthday.Name = "colbirthday";
            this.colbirthday.OptionsColumn.AllowEdit = false;
            // 
            // colexpiration_cnh
            // 
            this.colexpiration_cnh.FieldName = "expiration_cnh";
            this.colexpiration_cnh.Name = "colexpiration_cnh";
            this.colexpiration_cnh.OptionsColumn.AllowEdit = false;
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
            // 
            // colgenre
            // 
            this.colgenre.FieldName = "genre";
            this.colgenre.Name = "colgenre";
            this.colgenre.OptionsColumn.AllowEdit = false;
            // 
            // colphone_fixed
            // 
            this.colphone_fixed.FieldName = "phone_fixed";
            this.colphone_fixed.Name = "colphone_fixed";
            this.colphone_fixed.OptionsColumn.AllowEdit = false;
            // 
            // colphone_mobile
            // 
            this.colphone_mobile.FieldName = "phone_mobile";
            this.colphone_mobile.Name = "colphone_mobile";
            this.colphone_mobile.OptionsColumn.AllowEdit = false;
            // 
            // colinactive
            // 
            this.colinactive.FieldName = "inactive";
            this.colinactive.Name = "colinactive";
            this.colinactive.OptionsColumn.AllowEdit = false;
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
            // colcomission
            // 
            this.colcomission.FieldName = "comission";
            this.colcomission.Name = "colcomission";
            this.colcomission.OptionsColumn.AllowEdit = false;
            // 
            // coladmitted_at
            // 
            this.coladmitted_at.FieldName = "admitted_at";
            this.coladmitted_at.Name = "coladmitted_at";
            this.coladmitted_at.OptionsColumn.AllowEdit = false;
            // 
            // coldismissed_at
            // 
            this.coldismissed_at.FieldName = "dismissed_at";
            this.coldismissed_at.Name = "coldismissed_at";
            this.coldismissed_at.OptionsColumn.AllowEdit = false;
            // 
            // lbType
            // 
            this.lbType.Enabled = false;
            this.lbType.Location = new System.Drawing.Point(662, 15);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(29, 13);
            this.lbType.TabIndex = 2;
            this.lbType.Text = "Placa:";
            // 
            // lbDriver
            // 
            this.lbDriver.Enabled = false;
            this.lbDriver.Location = new System.Drawing.Point(312, 16);
            this.lbDriver.Name = "lbDriver";
            this.lbDriver.Size = new System.Drawing.Size(49, 13);
            this.lbDriver.TabIndex = 2;
            this.lbDriver.Text = "Motorista:";
            // 
            // rgType
            // 
            this.rgType.Location = new System.Drawing.Point(5, 9);
            this.rgType.Name = "rgType";
            this.rgType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgType.Properties.Appearance.Options.UseBackColor = true;
            this.rgType.Properties.Columns = 4;
            this.rgType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("board", "Placa"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("antt", "ANTT"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("driver", "Motorista"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("all", "Todos")});
            this.rgType.Size = new System.Drawing.Size(297, 27);
            this.rgType.TabIndex = 0;
            this.rgType.SelectedIndexChanged += new System.EventHandler(this.rgType_SelectedIndexChanged);
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
            this.btnSearch.Location = new System.Drawing.Point(877, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 33);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gridControl1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 43);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(992, 411);
            this.panelControl3.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bdgTrucks;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(988, 407);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.btnSelect_Click);
            // 
            // bdgTrucks
            // 
            this.bdgTrucks.DataSource = typeof(TruckSystem.truck);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.colboard,
            this.colrenavam,
            this.colchassi,
            this.colmodel,
            this.colyear_model,
            this.colantt,
            this.coldriver_name});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colid1
            // 
            this.colid1.Caption = "Cod.";
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            this.colid1.OptionsColumn.AllowEdit = false;
            this.colid1.Visible = true;
            this.colid1.VisibleIndex = 0;
            this.colid1.Width = 48;
            // 
            // colboard
            // 
            this.colboard.Caption = "Placa";
            this.colboard.FieldName = "board";
            this.colboard.Name = "colboard";
            this.colboard.OptionsColumn.AllowEdit = false;
            this.colboard.Visible = true;
            this.colboard.VisibleIndex = 1;
            this.colboard.Width = 83;
            // 
            // colrenavam
            // 
            this.colrenavam.Caption = "Renavan";
            this.colrenavam.FieldName = "renavam";
            this.colrenavam.Name = "colrenavam";
            this.colrenavam.OptionsColumn.AllowEdit = false;
            this.colrenavam.Visible = true;
            this.colrenavam.VisibleIndex = 2;
            this.colrenavam.Width = 110;
            // 
            // colchassi
            // 
            this.colchassi.Caption = "Chassi";
            this.colchassi.FieldName = "chassi";
            this.colchassi.Name = "colchassi";
            this.colchassi.OptionsColumn.AllowEdit = false;
            this.colchassi.Visible = true;
            this.colchassi.VisibleIndex = 3;
            this.colchassi.Width = 179;
            // 
            // colmodel
            // 
            this.colmodel.Caption = "Modelo";
            this.colmodel.FieldName = "model";
            this.colmodel.Name = "colmodel";
            this.colmodel.OptionsColumn.AllowEdit = false;
            this.colmodel.Visible = true;
            this.colmodel.VisibleIndex = 4;
            this.colmodel.Width = 152;
            // 
            // colyear_model
            // 
            this.colyear_model.Caption = "Ano Modelo";
            this.colyear_model.FieldName = "year_model";
            this.colyear_model.Name = "colyear_model";
            this.colyear_model.OptionsColumn.AllowEdit = false;
            this.colyear_model.Visible = true;
            this.colyear_model.VisibleIndex = 5;
            this.colyear_model.Width = 76;
            // 
            // colantt
            // 
            this.colantt.Caption = "ANTT";
            this.colantt.FieldName = "antt";
            this.colantt.Name = "colantt";
            this.colantt.OptionsColumn.AllowEdit = false;
            this.colantt.Visible = true;
            this.colantt.VisibleIndex = 6;
            this.colantt.Width = 106;
            // 
            // coldriver_name
            // 
            this.coldriver_name.Caption = "Motorista";
            this.coldriver_name.FieldName = "driver_name";
            this.coldriver_name.Name = "coldriver_name";
            this.coldriver_name.OptionsColumn.AllowEdit = false;
            this.coldriver_name.Visible = true;
            this.coldriver_name.VisibleIndex = 7;
            this.coldriver_name.Width = 216;
            // 
            // SearchTrucksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "SearchTrucksForm";
            this.Size = new System.Drawing.Size(992, 498);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDriver.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgTrucks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private WCButtons.Black.ButtonCancelBlack btnCancel;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private WCButtons.Black.ButtonConfirmBlack btnSelect;
        private WCButtons.Black.ButtonSearchBlack btnSearch;
        private DevExpress.XtraEditors.RadioGroup rgType;
        private DevExpress.XtraEditors.SearchLookUpEdit cbDriver;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl lbDriver;
        private DevExpress.XtraEditors.TextEdit tfType;
        private DevExpress.XtraEditors.LabelControl lbType;
        private System.Windows.Forms.BindingSource bdgTrucks;
        private System.Windows.Forms.BindingSource bdgDrivers;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colfull_name;
        private DevExpress.XtraGrid.Columns.GridColumn colcpf;
        private DevExpress.XtraGrid.Columns.GridColumn coladdress;
        private DevExpress.XtraGrid.Columns.GridColumn colbirthday;
        private DevExpress.XtraGrid.Columns.GridColumn colexpiration_cnh;
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
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn colboard;
        private DevExpress.XtraGrid.Columns.GridColumn colrenavam;
        private DevExpress.XtraGrid.Columns.GridColumn colchassi;
        private DevExpress.XtraGrid.Columns.GridColumn colmodel;
        private DevExpress.XtraGrid.Columns.GridColumn colyear_model;
        private DevExpress.XtraGrid.Columns.GridColumn colantt;
        private DevExpress.XtraGrid.Columns.GridColumn coldriver_name;
    }
}
