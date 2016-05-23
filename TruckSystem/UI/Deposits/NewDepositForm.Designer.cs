namespace TruckSystem.UI.Deposits
{
    partial class NewDepositForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewDepositForm));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule7 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new WCButtons.Black.ButtonSaveBlack();
            this.btnCancel = new WCButtons.Black.ButtonCancelBlack();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.rgType = new DevExpress.XtraEditors.RadioGroup();
            this.bdgDeposit = new System.Windows.Forms.BindingSource(this.components);
            this.tfDescription = new DevExpress.XtraEditors.TextEdit();
            this.tfValue = new DevExpress.XtraEditors.TextEdit();
            this.cbCustomer = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdgCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcorporate_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfantasy_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tfDate = new DevExpress.XtraEditors.DateEdit();
            this.cbBankAccount = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdgBankAccounts = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colagency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colholder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldocument = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbank_number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbank_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tfId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.validator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgDeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBankAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgBankAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnSave);
            this.panelControl2.Controls.Add(this.btnCancel);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 117);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(541, 46);
            this.panelControl2.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(310, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 33);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Salvar";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(426, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 33);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.rgType);
            this.panelControl1.Controls.Add(this.tfDescription);
            this.panelControl1.Controls.Add(this.tfValue);
            this.panelControl1.Controls.Add(this.cbCustomer);
            this.panelControl1.Controls.Add(this.tfDate);
            this.panelControl1.Controls.Add(this.cbBankAccount);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.tfId);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(541, 117);
            this.panelControl1.TabIndex = 0;
            // 
            // rgType
            // 
            this.rgType.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgDeposit, "type", true));
            this.rgType.Location = new System.Drawing.Point(249, 60);
            this.rgType.Name = "rgType";
            this.rgType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgType.Properties.Appearance.Options.UseBackColor = true;
            this.rgType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgType.Properties.Columns = 2;
            this.rgType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Dinheiro"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Cheque")});
            this.rgType.Size = new System.Drawing.Size(134, 23);
            this.rgType.TabIndex = 4;
            conditionValidationRule7.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.GreaterOrEqual;
            conditionValidationRule7.ErrorText = "Informe o Tipo";
            conditionValidationRule7.Value1 = ((long)(0));
            this.validator.SetValidationRule(this.rgType, conditionValidationRule7);
            // 
            // bdgDeposit
            // 
            this.bdgDeposit.DataSource = typeof(TruckSystem.deposits);
            // 
            // tfDescription
            // 
            this.tfDescription.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgDeposit, "description", true));
            this.tfDescription.Location = new System.Drawing.Point(95, 88);
            this.tfDescription.Name = "tfDescription";
            this.tfDescription.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfDescription.Size = new System.Drawing.Size(441, 20);
            this.tfDescription.TabIndex = 5;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Informe a Descrição";
            this.validator.SetValidationRule(this.tfDescription, conditionValidationRule1);
            // 
            // tfValue
            // 
            this.tfValue.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgDeposit, "value", true));
            this.tfValue.Location = new System.Drawing.Point(95, 62);
            this.tfValue.Name = "tfValue";
            this.tfValue.Properties.DisplayFormat.FormatString = "c2";
            this.tfValue.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tfValue.Properties.Mask.EditMask = "c2";
            this.tfValue.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tfValue.Size = new System.Drawing.Size(113, 20);
            this.tfValue.TabIndex = 3;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule2.ErrorText = "Informe o Valor";
            conditionValidationRule2.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.validator.SetValidationRule(this.tfValue, conditionValidationRule2);
            // 
            // cbCustomer
            // 
            this.cbCustomer.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgDeposit, "customer_id", true));
            this.cbCustomer.Location = new System.Drawing.Point(249, 36);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCustomer.Properties.DataSource = this.bdgCustomer;
            this.cbCustomer.Properties.DisplayMember = "corporate_name";
            this.cbCustomer.Properties.NullText = "";
            this.cbCustomer.Properties.ValueMember = "id";
            this.cbCustomer.Properties.View = this.gridView1;
            this.cbCustomer.Size = new System.Drawing.Size(287, 20);
            this.cbCustomer.TabIndex = 2;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule3.ErrorText = "Informe o Local de Depósito";
            conditionValidationRule3.Value1 = ((long)(0));
            this.validator.SetValidationRule(this.cbCustomer, conditionValidationRule3);
            // 
            // bdgCustomer
            // 
            this.bdgCustomer.DataSource = typeof(TruckSystem.customer);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colcorporate_name,
            this.colfantasy_name,
            this.gridColumn2});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Cod.";
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 69;
            // 
            // colcorporate_name
            // 
            this.colcorporate_name.Caption = "Razão Social";
            this.colcorporate_name.FieldName = "corporate_name";
            this.colcorporate_name.Name = "colcorporate_name";
            this.colcorporate_name.Visible = true;
            this.colcorporate_name.VisibleIndex = 1;
            this.colcorporate_name.Width = 264;
            // 
            // colfantasy_name
            // 
            this.colfantasy_name.Caption = "Nome Fantasia";
            this.colfantasy_name.FieldName = "fantasy_name";
            this.colfantasy_name.Name = "colfantasy_name";
            this.colfantasy_name.Visible = true;
            this.colfantasy_name.VisibleIndex = 2;
            this.colfantasy_name.Width = 192;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Documento";
            this.gridColumn2.FieldName = "document";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 171;
            // 
            // tfDate
            // 
            this.tfDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgDeposit, "date", true));
            this.tfDate.EditValue = null;
            this.tfDate.Location = new System.Drawing.Point(95, 36);
            this.tfDate.Name = "tfDate";
            this.tfDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfDate.Size = new System.Drawing.Size(113, 20);
            this.tfDate.TabIndex = 1;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Informe a Data";
            this.validator.SetValidationRule(this.tfDate, conditionValidationRule4);
            // 
            // cbBankAccount
            // 
            this.cbBankAccount.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgDeposit, "account_id", true));
            this.cbBankAccount.Location = new System.Drawing.Point(95, 10);
            this.cbBankAccount.Name = "cbBankAccount";
            this.cbBankAccount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbBankAccount.Properties.DataSource = this.bdgBankAccounts;
            this.cbBankAccount.Properties.DisplayMember = "account_name";
            this.cbBankAccount.Properties.NullText = "";
            this.cbBankAccount.Properties.ValueMember = "id";
            this.cbBankAccount.Properties.View = this.searchLookUpEdit1View;
            this.cbBankAccount.Size = new System.Drawing.Size(331, 20);
            this.cbBankAccount.TabIndex = 0;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule5.ErrorText = "Informe a Conta Bancária";
            conditionValidationRule5.Value1 = ((long)(0));
            this.validator.SetValidationRule(this.cbBankAccount, conditionValidationRule5);
            // 
            // bdgBankAccounts
            // 
            this.bdgBankAccounts.DataSource = typeof(TruckSystem.bank_account);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colagency,
            this.colaccount,
            this.colholder,
            this.coldocument,
            this.colbank_number,
            this.colbank_name});
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
            this.colid.Width = 73;
            // 
            // colagency
            // 
            this.colagency.Caption = "Agência";
            this.colagency.FieldName = "agency";
            this.colagency.Name = "colagency";
            this.colagency.OptionsColumn.AllowEdit = false;
            this.colagency.Visible = true;
            this.colagency.VisibleIndex = 1;
            // 
            // colaccount
            // 
            this.colaccount.Caption = "Conta";
            this.colaccount.FieldName = "account";
            this.colaccount.Name = "colaccount";
            this.colaccount.OptionsColumn.AllowEdit = false;
            this.colaccount.Visible = true;
            this.colaccount.VisibleIndex = 2;
            this.colaccount.Width = 106;
            // 
            // colholder
            // 
            this.colholder.Caption = "Titular";
            this.colholder.FieldName = "holder";
            this.colholder.Name = "colholder";
            this.colholder.OptionsColumn.AllowEdit = false;
            this.colholder.Visible = true;
            this.colholder.VisibleIndex = 3;
            this.colholder.Width = 237;
            // 
            // coldocument
            // 
            this.coldocument.Caption = "Documento";
            this.coldocument.FieldName = "document";
            this.coldocument.Name = "coldocument";
            this.coldocument.OptionsColumn.AllowEdit = false;
            this.coldocument.Width = 112;
            // 
            // colbank_number
            // 
            this.colbank_number.Caption = "Numero Banco";
            this.colbank_number.FieldName = "bank_number";
            this.colbank_number.Name = "colbank_number";
            this.colbank_number.OptionsColumn.AllowEdit = false;
            this.colbank_number.Width = 106;
            // 
            // colbank_name
            // 
            this.colbank_name.Caption = "Banco";
            this.colbank_name.FieldName = "bank_name";
            this.colbank_name.Name = "colbank_name";
            this.colbank_name.OptionsColumn.AllowEdit = false;
            this.colbank_name.Visible = true;
            this.colbank_name.VisibleIndex = 0;
            this.colbank_name.Width = 205;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(216, 65);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(24, 13);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "Tipo:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(216, 39);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(28, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Local:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 91);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(50, 13);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "Descrição:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(11, 65);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(28, 13);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Valor:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 39);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(27, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Data:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(77, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Conta Bancária:";
            // 
            // tfId
            // 
            this.tfId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgDeposit, "id", true));
            this.tfId.Location = new System.Drawing.Point(465, 10);
            this.tfId.Name = "tfId";
            this.tfId.Properties.ReadOnly = true;
            this.tfId.Size = new System.Drawing.Size(71, 20);
            this.tfId.TabIndex = 1;
            this.tfId.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(432, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Cod.:";
            // 
            // NewDepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 163);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewDepositForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Depósito";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgDeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBankAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgBankAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private WCButtons.Black.ButtonCancelBlack btnCancel;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private WCButtons.Black.ButtonSaveBlack btnSave;
        private DevExpress.XtraEditors.TextEdit tfId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit cbBankAccount;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit tfDate;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SearchLookUpEdit cbCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit tfValue;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.RadioGroup rgType;
        private DevExpress.XtraEditors.TextEdit tfDescription;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validator;
        private System.Windows.Forms.BindingSource bdgDeposit;
        private System.Windows.Forms.BindingSource bdgBankAccounts;
        private System.Windows.Forms.BindingSource bdgCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colagency;
        private DevExpress.XtraGrid.Columns.GridColumn colaccount;
        private DevExpress.XtraGrid.Columns.GridColumn colholder;
        private DevExpress.XtraGrid.Columns.GridColumn coldocument;
        private DevExpress.XtraGrid.Columns.GridColumn colbank_number;
        private DevExpress.XtraGrid.Columns.GridColumn colbank_name;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colcorporate_name;
        private DevExpress.XtraGrid.Columns.GridColumn colfantasy_name;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}