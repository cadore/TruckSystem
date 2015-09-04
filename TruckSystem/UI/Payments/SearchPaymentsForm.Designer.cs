namespace TruckSystem.UI.Payments
{
    partial class SearchPaymentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchPaymentsForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnConfirm = new WCButtons.Black.ButtonConfirmBlack();
            this.btnCancel = new WCButtons.Black.ButtonCancelBlack();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.rgPaid = new DevExpress.XtraEditors.RadioGroup();
            this.tfEndDatePaid = new DevExpress.XtraEditors.DateEdit();
            this.tfEndDateExpiration = new DevExpress.XtraEditors.DateEdit();
            this.tfStartDatePaid = new DevExpress.XtraEditors.DateEdit();
            this.tfStartDateExpiration = new DevExpress.XtraEditors.DateEdit();
            this.cbTruck = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdgTrucks = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colboard = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbCustomer = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdgCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcorporate_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfantasy_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldocument = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tfDescription = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new WCButtons.Black.ButtonSearchBlack();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bdgPayments = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcustomer_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexpiration_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpaid_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalue_paid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpaid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltruck_board = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgPaid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfEndDatePaid.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfEndDatePaid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfEndDateExpiration.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfEndDateExpiration.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfStartDatePaid.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfStartDatePaid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfStartDateExpiration.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfStartDateExpiration.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTruck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgTrucks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnConfirm);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 427);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(965, 44);
            this.panelControl1.TabIndex = 0;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirm.Location = new System.Drawing.Point(730, 6);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(114, 33);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Selecionar";
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(850, 6);
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
            this.panelControl2.Controls.Add(this.rgPaid);
            this.panelControl2.Controls.Add(this.tfEndDatePaid);
            this.panelControl2.Controls.Add(this.tfEndDateExpiration);
            this.panelControl2.Controls.Add(this.tfStartDatePaid);
            this.panelControl2.Controls.Add(this.tfStartDateExpiration);
            this.panelControl2.Controls.Add(this.cbTruck);
            this.panelControl2.Controls.Add(this.cbCustomer);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.tfDescription);
            this.panelControl2.Controls.Add(this.labelControl7);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.btnSearch);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(965, 70);
            this.panelControl2.TabIndex = 1;
            // 
            // rgPaid
            // 
            this.rgPaid.Location = new System.Drawing.Point(621, 37);
            this.rgPaid.Name = "rgPaid";
            this.rgPaid.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Não Pago"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Pago"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Todos")});
            this.rgPaid.Size = new System.Drawing.Size(210, 26);
            this.rgPaid.TabIndex = 5;
            // 
            // tfEndDatePaid
            // 
            this.tfEndDatePaid.EditValue = null;
            this.tfEndDatePaid.Location = new System.Drawing.Point(515, 39);
            this.tfEndDatePaid.Name = "tfEndDatePaid";
            this.tfEndDatePaid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfEndDatePaid.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfEndDatePaid.Size = new System.Drawing.Size(100, 20);
            this.tfEndDatePaid.TabIndex = 4;
            // 
            // tfEndDateExpiration
            // 
            this.tfEndDateExpiration.EditValue = null;
            this.tfEndDateExpiration.Location = new System.Drawing.Point(207, 39);
            this.tfEndDateExpiration.Name = "tfEndDateExpiration";
            this.tfEndDateExpiration.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfEndDateExpiration.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfEndDateExpiration.Size = new System.Drawing.Size(100, 20);
            this.tfEndDateExpiration.TabIndex = 4;
            // 
            // tfStartDatePaid
            // 
            this.tfStartDatePaid.EditValue = null;
            this.tfStartDatePaid.Location = new System.Drawing.Point(397, 40);
            this.tfStartDatePaid.Name = "tfStartDatePaid";
            this.tfStartDatePaid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfStartDatePaid.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfStartDatePaid.Size = new System.Drawing.Size(100, 20);
            this.tfStartDatePaid.TabIndex = 4;
            // 
            // tfStartDateExpiration
            // 
            this.tfStartDateExpiration.EditValue = null;
            this.tfStartDateExpiration.Location = new System.Drawing.Point(89, 40);
            this.tfStartDateExpiration.Name = "tfStartDateExpiration";
            this.tfStartDateExpiration.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfStartDateExpiration.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfStartDateExpiration.Size = new System.Drawing.Size(100, 20);
            this.tfStartDateExpiration.TabIndex = 4;
            // 
            // cbTruck
            // 
            this.cbTruck.Location = new System.Drawing.Point(680, 13);
            this.cbTruck.Name = "cbTruck";
            this.cbTruck.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTruck.Properties.DataSource = this.bdgTrucks;
            this.cbTruck.Properties.DisplayMember = "board";
            this.cbTruck.Properties.NullText = "";
            this.cbTruck.Properties.ValueMember = "id";
            this.cbTruck.Properties.View = this.gridView2;
            this.cbTruck.Size = new System.Drawing.Size(151, 20);
            this.cbTruck.TabIndex = 3;
            // 
            // bdgTrucks
            // 
            this.bdgTrucks.DataSource = typeof(TruckSystem.truck);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colboard});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Cod.";
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 179;
            // 
            // colboard
            // 
            this.colboard.Caption = "Placa";
            this.colboard.FieldName = "board";
            this.colboard.Name = "colboard";
            this.colboard.OptionsColumn.AllowEdit = false;
            this.colboard.Visible = true;
            this.colboard.VisibleIndex = 1;
            this.colboard.Width = 899;
            // 
            // cbCustomer
            // 
            this.cbCustomer.Location = new System.Drawing.Point(397, 13);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCustomer.Properties.DataSource = this.bdgCustomers;
            this.cbCustomer.Properties.DisplayMember = "corporate_name";
            this.cbCustomer.Properties.NullText = "";
            this.cbCustomer.Properties.ValueMember = "id";
            this.cbCustomer.Properties.View = this.searchLookUpEdit1View;
            this.cbCustomer.Size = new System.Drawing.Size(218, 20);
            this.cbCustomer.TabIndex = 3;
            // 
            // bdgCustomers
            // 
            this.bdgCustomers.DataSource = typeof(TruckSystem.customer);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.colcorporate_name,
            this.colfantasy_name,
            this.coldocument});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Cod.";
            this.gridColumn2.FieldName = "id";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 117;
            // 
            // colcorporate_name
            // 
            this.colcorporate_name.Caption = "Razão Social";
            this.colcorporate_name.FieldName = "corporate_name";
            this.colcorporate_name.Name = "colcorporate_name";
            this.colcorporate_name.OptionsColumn.AllowEdit = false;
            this.colcorporate_name.Visible = true;
            this.colcorporate_name.VisibleIndex = 1;
            this.colcorporate_name.Width = 341;
            // 
            // colfantasy_name
            // 
            this.colfantasy_name.Caption = "Nome Fantasia";
            this.colfantasy_name.FieldName = "fantasy_name";
            this.colfantasy_name.Name = "colfantasy_name";
            this.colfantasy_name.OptionsColumn.AllowEdit = false;
            this.colfantasy_name.Visible = true;
            this.colfantasy_name.VisibleIndex = 2;
            this.colfantasy_name.Width = 343;
            // 
            // coldocument
            // 
            this.coldocument.Caption = "CNPJ/CPF";
            this.coldocument.FieldName = "document";
            this.coldocument.Name = "coldocument";
            this.coldocument.OptionsColumn.AllowEdit = false;
            this.coldocument.Visible = true;
            this.coldocument.VisibleIndex = 3;
            this.coldocument.Width = 277;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(623, 16);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Caminhão:";
            // 
            // tfDescription
            // 
            this.tfDescription.Location = new System.Drawing.Point(89, 13);
            this.tfDescription.Name = "tfDescription";
            this.tfDescription.Size = new System.Drawing.Size(243, 20);
            this.tfDescription.TabIndex = 2;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(503, 42);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(6, 13);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "à";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(354, 16);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Cliente:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(318, 42);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(73, 13);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "Pagamento de:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(195, 42);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(6, 13);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "à";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(9, 42);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(74, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Vencimento de:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Descrição:";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(850, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 33);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gridControl1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 70);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(965, 357);
            this.panelControl3.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bdgPayments;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(961, 353);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.btnConfirm_Click);
            // 
            // bdgPayments
            // 
            this.bdgPayments.DataSource = typeof(TruckSystem.payment);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescription,
            this.colcustomer_name,
            this.colexpiration_date,
            this.colpaid_date,
            this.colvalue,
            this.colvalue_paid,
            this.colpaid,
            this.coltruck_board});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colid
            // 
            this.colid.Caption = "Cod.";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 43;
            // 
            // coldescription
            // 
            this.coldescription.Caption = "Descrição";
            this.coldescription.FieldName = "description";
            this.coldescription.Name = "coldescription";
            this.coldescription.OptionsColumn.AllowEdit = false;
            this.coldescription.Visible = true;
            this.coldescription.VisibleIndex = 1;
            this.coldescription.Width = 252;
            // 
            // colcustomer_name
            // 
            this.colcustomer_name.Caption = "Cliente/Prestador";
            this.colcustomer_name.FieldName = "customer_name";
            this.colcustomer_name.Name = "colcustomer_name";
            this.colcustomer_name.OptionsColumn.AllowEdit = false;
            this.colcustomer_name.Visible = true;
            this.colcustomer_name.VisibleIndex = 2;
            this.colcustomer_name.Width = 173;
            // 
            // colexpiration_date
            // 
            this.colexpiration_date.Caption = "Vencimento";
            this.colexpiration_date.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colexpiration_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colexpiration_date.FieldName = "expiration_date";
            this.colexpiration_date.Name = "colexpiration_date";
            this.colexpiration_date.OptionsColumn.AllowEdit = false;
            this.colexpiration_date.Visible = true;
            this.colexpiration_date.VisibleIndex = 5;
            this.colexpiration_date.Width = 83;
            // 
            // colpaid_date
            // 
            this.colpaid_date.Caption = "Pagamento";
            this.colpaid_date.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colpaid_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colpaid_date.FieldName = "paid_date";
            this.colpaid_date.Name = "colpaid_date";
            this.colpaid_date.OptionsColumn.AllowEdit = false;
            this.colpaid_date.Visible = true;
            this.colpaid_date.VisibleIndex = 8;
            this.colpaid_date.Width = 92;
            // 
            // colvalue
            // 
            this.colvalue.Caption = "Valor R$";
            this.colvalue.DisplayFormat.FormatString = "c2";
            this.colvalue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colvalue.FieldName = "value";
            this.colvalue.Name = "colvalue";
            this.colvalue.OptionsColumn.AllowEdit = false;
            this.colvalue.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "value", "{0:c2}")});
            this.colvalue.Visible = true;
            this.colvalue.VisibleIndex = 4;
            this.colvalue.Width = 95;
            // 
            // colvalue_paid
            // 
            this.colvalue_paid.Caption = "Valor Pago R$";
            this.colvalue_paid.DisplayFormat.FormatString = "c2";
            this.colvalue_paid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colvalue_paid.FieldName = "value_paid";
            this.colvalue_paid.Name = "colvalue_paid";
            this.colvalue_paid.OptionsColumn.AllowEdit = false;
            this.colvalue_paid.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "value_paid", "{0:c2}")});
            this.colvalue_paid.Visible = true;
            this.colvalue_paid.VisibleIndex = 7;
            this.colvalue_paid.Width = 85;
            // 
            // colpaid
            // 
            this.colpaid.Caption = "Pago?";
            this.colpaid.FieldName = "paid";
            this.colpaid.Name = "colpaid";
            this.colpaid.OptionsColumn.AllowEdit = false;
            this.colpaid.Visible = true;
            this.colpaid.VisibleIndex = 6;
            this.colpaid.Width = 44;
            // 
            // coltruck_board
            // 
            this.coltruck_board.Caption = "Caminhão";
            this.coltruck_board.FieldName = "truck_board";
            this.coltruck_board.Name = "coltruck_board";
            this.coltruck_board.OptionsColumn.AllowEdit = false;
            this.coltruck_board.Visible = true;
            this.coltruck_board.VisibleIndex = 3;
            this.coltruck_board.Width = 76;
            // 
            // SearchPaymentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "SearchPaymentsForm";
            this.Size = new System.Drawing.Size(965, 471);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgPaid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfEndDatePaid.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfEndDatePaid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfEndDateExpiration.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfEndDateExpiration.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfStartDatePaid.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfStartDatePaid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfStartDateExpiration.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfStartDateExpiration.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTruck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgTrucks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private WCButtons.Black.ButtonConfirmBlack btnConfirm;
        private WCButtons.Black.ButtonCancelBlack btnCancel;
        private WCButtons.Black.ButtonSearchBlack btnSearch;
        private System.Windows.Forms.BindingSource bdgPayments;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescription;
        private DevExpress.XtraGrid.Columns.GridColumn colexpiration_date;
        private DevExpress.XtraGrid.Columns.GridColumn colpaid_date;
        private DevExpress.XtraGrid.Columns.GridColumn colvalue;
        private DevExpress.XtraGrid.Columns.GridColumn colvalue_paid;
        private DevExpress.XtraGrid.Columns.GridColumn colpaid;
        private DevExpress.XtraGrid.Columns.GridColumn colcustomer_name;
        private DevExpress.XtraGrid.Columns.GridColumn coltruck_board;
        private DevExpress.XtraEditors.TextEdit tfDescription;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit cbTruck;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SearchLookUpEdit cbCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit tfStartDateExpiration;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit tfEndDateExpiration;
        private DevExpress.XtraEditors.DateEdit tfEndDatePaid;
        private DevExpress.XtraEditors.DateEdit tfStartDatePaid;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.RadioGroup rgPaid;
        private System.Windows.Forms.BindingSource bdgTrucks;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colboard;
        private System.Windows.Forms.BindingSource bdgCustomers;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colcorporate_name;
        private DevExpress.XtraGrid.Columns.GridColumn colfantasy_name;
        private DevExpress.XtraGrid.Columns.GridColumn coldocument;
    }
}
