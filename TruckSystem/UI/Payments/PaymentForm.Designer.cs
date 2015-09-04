namespace TruckSystem.UI.Payments
{
    partial class PaymentForm
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
            DevExpress.XtraEditors.LabelControl customer_idLabel;
            DevExpress.XtraEditors.LabelControl descriptionLabel;
            DevExpress.XtraEditors.LabelControl expiration_dateLabel;
            DevExpress.XtraEditors.LabelControl idLabel;
            DevExpress.XtraEditors.LabelControl observationLabel;
            DevExpress.XtraEditors.LabelControl paidLabel;
            DevExpress.XtraEditors.LabelControl paid_dateLabel;
            DevExpress.XtraEditors.LabelControl reason_expirationLabel;
            DevExpress.XtraEditors.LabelControl truck_idLabel;
            DevExpress.XtraEditors.LabelControl valueLabel;
            DevExpress.XtraEditors.LabelControl value_paidLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule6 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule7 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnParcel = new WCButtons.Black.ButtonSettingsBlack();
            this.btnUpdateData = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new WCButtons.Black.ButtonSaveBlack();
            this.btnCancel = new WCButtons.Black.ButtonCancelBlack();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.tfObservation = new DevExpress.XtraEditors.MemoEdit();
            this.bdgPayment = new System.Windows.Forms.BindingSource(this.components);
            this.cbCustomer = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdgCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.customer_idSearchLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcorporate_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfantasy_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldocument = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tfDescription = new DevExpress.XtraEditors.TextEdit();
            this.tfDateExpiration = new DevExpress.XtraEditors.DateEdit();
            this.tfId = new DevExpress.XtraEditors.TextEdit();
            this.ckPaid = new DevExpress.XtraEditors.CheckEdit();
            this.tfDatePayment = new DevExpress.XtraEditors.DateEdit();
            this.tfReasonExpiration = new DevExpress.XtraEditors.TextEdit();
            this.cbTruck = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdgTruck = new System.Windows.Forms.BindingSource(this.components);
            this.truck_idSearchLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colboard = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tfValue = new DevExpress.XtraEditors.CalcEdit();
            this.tfValuePaid = new DevExpress.XtraEditors.CalcEdit();
            this.validator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.validatorPaid = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            customer_idLabel = new DevExpress.XtraEditors.LabelControl();
            descriptionLabel = new DevExpress.XtraEditors.LabelControl();
            expiration_dateLabel = new DevExpress.XtraEditors.LabelControl();
            idLabel = new DevExpress.XtraEditors.LabelControl();
            observationLabel = new DevExpress.XtraEditors.LabelControl();
            paidLabel = new DevExpress.XtraEditors.LabelControl();
            paid_dateLabel = new DevExpress.XtraEditors.LabelControl();
            reason_expirationLabel = new DevExpress.XtraEditors.LabelControl();
            truck_idLabel = new DevExpress.XtraEditors.LabelControl();
            valueLabel = new DevExpress.XtraEditors.LabelControl();
            value_paidLabel = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfObservation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_idSearchLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDateExpiration.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDateExpiration.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckPaid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDatePayment.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDatePayment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfReasonExpiration.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTruck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgTruck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truck_idSearchLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValuePaid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorPaid)).BeginInit();
            this.SuspendLayout();
            // 
            // customer_idLabel
            // 
            customer_idLabel.Location = new System.Drawing.Point(5, 8);
            customer_idLabel.Name = "customer_idLabel";
            customer_idLabel.Size = new System.Drawing.Size(51, 13);
            customer_idLabel.TabIndex = 0;
            customer_idLabel.Text = "Prestador:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.Location = new System.Drawing.Point(5, 34);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(50, 13);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Descrição:";
            // 
            // expiration_dateLabel
            // 
            expiration_dateLabel.Location = new System.Drawing.Point(5, 60);
            expiration_dateLabel.Name = "expiration_dateLabel";
            expiration_dateLabel.Size = new System.Drawing.Size(100, 13);
            expiration_dateLabel.TabIndex = 4;
            expiration_dateLabel.Text = "Data de Vencimento:";
            // 
            // idLabel
            // 
            idLabel.Location = new System.Drawing.Point(538, 8);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(27, 13);
            idLabel.TabIndex = 8;
            idLabel.Text = "Cod.:";
            // 
            // observationLabel
            // 
            observationLabel.Location = new System.Drawing.Point(5, 141);
            observationLabel.Name = "observationLabel";
            observationLabel.Size = new System.Drawing.Size(67, 13);
            observationLabel.TabIndex = 10;
            observationLabel.Text = "Observações:";
            // 
            // paidLabel
            // 
            paidLabel.Location = new System.Drawing.Point(406, 60);
            paidLabel.Name = "paidLabel";
            paidLabel.Size = new System.Drawing.Size(28, 13);
            paidLabel.TabIndex = 12;
            paidLabel.Text = "Pago:";
            // 
            // paid_dateLabel
            // 
            paid_dateLabel.Location = new System.Drawing.Point(5, 86);
            paid_dateLabel.Name = "paid_dateLabel";
            paid_dateLabel.Size = new System.Drawing.Size(99, 13);
            paid_dateLabel.TabIndex = 14;
            paid_dateLabel.Text = "Data de Pagamento:";
            // 
            // reason_expirationLabel
            // 
            reason_expirationLabel.Location = new System.Drawing.Point(5, 112);
            reason_expirationLabel.Name = "reason_expirationLabel";
            reason_expirationLabel.Size = new System.Drawing.Size(94, 13);
            reason_expirationLabel.TabIndex = 16;
            reason_expirationLabel.Text = "Motivo Vencimento:";
            // 
            // truck_idLabel
            // 
            truck_idLabel.Location = new System.Drawing.Point(376, 8);
            truck_idLabel.Name = "truck_idLabel";
            truck_idLabel.Size = new System.Drawing.Size(51, 13);
            truck_idLabel.TabIndex = 18;
            truck_idLabel.Text = "Caminhão:";
            // 
            // valueLabel
            // 
            valueLabel.Location = new System.Drawing.Point(217, 60);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new System.Drawing.Size(44, 13);
            valueLabel.TabIndex = 20;
            valueLabel.Text = "Valor R$:";
            // 
            // value_paidLabel
            // 
            value_paidLabel.Location = new System.Drawing.Point(217, 86);
            value_paidLabel.Name = "value_paidLabel";
            value_paidLabel.Size = new System.Drawing.Size(71, 13);
            value_paidLabel.TabIndex = 22;
            value_paidLabel.Text = "Valor Pago R$:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnParcel);
            this.panelControl1.Controls.Add(this.btnUpdateData);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 263);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(625, 44);
            this.panelControl1.TabIndex = 1;
            // 
            // btnParcel
            // 
            this.btnParcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnParcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParcel.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnParcel.ForeColor = System.Drawing.Color.White;
            this.btnParcel.Image = ((System.Drawing.Image)(resources.GetObject("btnParcel.Image")));
            this.btnParcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParcel.Location = new System.Drawing.Point(278, 6);
            this.btnParcel.Name = "btnParcel";
            this.btnParcel.Size = new System.Drawing.Size(110, 33);
            this.btnParcel.TabIndex = 3;
            this.btnParcel.Text = "Parcelas";
            this.btnParcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnParcel.UseVisualStyleBackColor = false;
            this.btnParcel.Click += new System.EventHandler(this.btnParcel_Click);
            // 
            // btnUpdateData
            // 
            this.btnUpdateData.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnUpdateData.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateData.Image")));
            this.btnUpdateData.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnUpdateData.Location = new System.Drawing.Point(5, 5);
            this.btnUpdateData.Name = "btnUpdateData";
            this.btnUpdateData.Size = new System.Drawing.Size(33, 33);
            this.btnUpdateData.TabIndex = 2;
            this.btnUpdateData.Click += new System.EventHandler(this.btnUpdateData_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(394, 6);
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
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(510, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 33);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.tfObservation);
            this.panelControl2.Controls.Add(customer_idLabel);
            this.panelControl2.Controls.Add(this.cbCustomer);
            this.panelControl2.Controls.Add(descriptionLabel);
            this.panelControl2.Controls.Add(this.tfDescription);
            this.panelControl2.Controls.Add(expiration_dateLabel);
            this.panelControl2.Controls.Add(this.tfDateExpiration);
            this.panelControl2.Controls.Add(idLabel);
            this.panelControl2.Controls.Add(this.tfId);
            this.panelControl2.Controls.Add(observationLabel);
            this.panelControl2.Controls.Add(paidLabel);
            this.panelControl2.Controls.Add(this.ckPaid);
            this.panelControl2.Controls.Add(paid_dateLabel);
            this.panelControl2.Controls.Add(this.tfDatePayment);
            this.panelControl2.Controls.Add(reason_expirationLabel);
            this.panelControl2.Controls.Add(this.tfReasonExpiration);
            this.panelControl2.Controls.Add(truck_idLabel);
            this.panelControl2.Controls.Add(this.cbTruck);
            this.panelControl2.Controls.Add(valueLabel);
            this.panelControl2.Controls.Add(this.tfValue);
            this.panelControl2.Controls.Add(value_paidLabel);
            this.panelControl2.Controls.Add(this.tfValuePaid);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(625, 263);
            this.panelControl2.TabIndex = 0;
            // 
            // tfObservation
            // 
            this.tfObservation.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgPayment, "observation", true));
            this.tfObservation.Location = new System.Drawing.Point(5, 160);
            this.tfObservation.Name = "tfObservation";
            this.tfObservation.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfObservation.Size = new System.Drawing.Size(614, 96);
            this.tfObservation.TabIndex = 9;
            this.tfObservation.UseOptimizedRendering = true;
            // 
            // bdgPayment
            // 
            this.bdgPayment.DataSource = typeof(TruckSystem.payment);
            // 
            // cbCustomer
            // 
            this.cbCustomer.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgPayment, "customer_id", true));
            this.cbCustomer.Location = new System.Drawing.Point(111, 5);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCustomer.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cbCustomer.Properties.DataSource = this.bdgCustomer;
            this.cbCustomer.Properties.DisplayMember = "corporate_name";
            this.cbCustomer.Properties.NullText = "";
            this.cbCustomer.Properties.ValueMember = "id";
            this.cbCustomer.Properties.View = this.customer_idSearchLookUpEditView;
            this.cbCustomer.Size = new System.Drawing.Size(260, 20);
            this.cbCustomer.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule1.ErrorText = "Informe o Cliente/Prestador";
            conditionValidationRule1.Value1 = ((long)(0));
            this.validator.SetValidationRule(this.cbCustomer, conditionValidationRule1);
            // 
            // bdgCustomer
            // 
            this.bdgCustomer.DataSource = typeof(TruckSystem.customer);
            // 
            // customer_idSearchLookUpEditView
            // 
            this.customer_idSearchLookUpEditView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.colcorporate_name,
            this.colfantasy_name,
            this.coldocument});
            this.customer_idSearchLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.customer_idSearchLookUpEditView.Name = "customer_idSearchLookUpEditView";
            this.customer_idSearchLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.customer_idSearchLookUpEditView.OptionsView.ShowGroupPanel = false;
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
            // tfDescription
            // 
            this.tfDescription.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgPayment, "description", true));
            this.tfDescription.Location = new System.Drawing.Point(111, 31);
            this.tfDescription.Name = "tfDescription";
            this.tfDescription.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfDescription.Size = new System.Drawing.Size(508, 20);
            this.tfDescription.TabIndex = 2;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Informe a Descrição";
            this.validator.SetValidationRule(this.tfDescription, conditionValidationRule2);
            // 
            // tfDateExpiration
            // 
            this.tfDateExpiration.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgPayment, "expiration_date", true));
            this.tfDateExpiration.EditValue = null;
            this.tfDateExpiration.Location = new System.Drawing.Point(111, 57);
            this.tfDateExpiration.Name = "tfDateExpiration";
            this.tfDateExpiration.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfDateExpiration.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfDateExpiration.Size = new System.Drawing.Size(100, 20);
            this.tfDateExpiration.TabIndex = 3;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Informe a Data de Vencimento";
            this.validator.SetValidationRule(this.tfDateExpiration, conditionValidationRule3);
            this.tfDateExpiration.EditValueChanged += new System.EventHandler(this.isExpired);
            // 
            // tfId
            // 
            this.tfId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgPayment, "id", true));
            this.tfId.Location = new System.Drawing.Point(571, 5);
            this.tfId.Name = "tfId";
            this.tfId.Properties.ReadOnly = true;
            this.tfId.Size = new System.Drawing.Size(48, 20);
            this.tfId.TabIndex = 9;
            this.tfId.TabStop = false;
            // 
            // ckPaid
            // 
            this.ckPaid.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgPayment, "paid", true));
            this.ckPaid.Location = new System.Drawing.Point(440, 59);
            this.ckPaid.Name = "ckPaid";
            this.ckPaid.Properties.Caption = "";
            this.ckPaid.Size = new System.Drawing.Size(16, 15);
            this.ckPaid.TabIndex = 5;
            this.ckPaid.CheckedChanged += new System.EventHandler(this.ckPaid_CheckedChanged);
            // 
            // tfDatePayment
            // 
            this.tfDatePayment.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgPayment, "paid_date", true));
            this.tfDatePayment.EditValue = null;
            this.tfDatePayment.Enabled = false;
            this.tfDatePayment.Location = new System.Drawing.Point(111, 83);
            this.tfDatePayment.Name = "tfDatePayment";
            this.tfDatePayment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfDatePayment.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfDatePayment.Size = new System.Drawing.Size(100, 20);
            this.tfDatePayment.TabIndex = 6;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Informe a data de pagamento";
            this.validatorPaid.SetValidationRule(this.tfDatePayment, conditionValidationRule4);
            this.tfDatePayment.EditValueChanged += new System.EventHandler(this.isExpired);
            // 
            // tfReasonExpiration
            // 
            this.tfReasonExpiration.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgPayment, "reason_expiration", true));
            this.tfReasonExpiration.Enabled = false;
            this.tfReasonExpiration.Location = new System.Drawing.Point(111, 109);
            this.tfReasonExpiration.Name = "tfReasonExpiration";
            this.tfReasonExpiration.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tfReasonExpiration.Properties.Appearance.Options.UseBackColor = true;
            this.tfReasonExpiration.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfReasonExpiration.Size = new System.Drawing.Size(508, 20);
            this.tfReasonExpiration.TabIndex = 8;
            // 
            // cbTruck
            // 
            this.cbTruck.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgPayment, "truck_id", true));
            this.cbTruck.Location = new System.Drawing.Point(433, 5);
            this.cbTruck.Name = "cbTruck";
            this.cbTruck.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTruck.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cbTruck.Properties.DataSource = this.bdgTruck;
            this.cbTruck.Properties.DisplayMember = "board";
            this.cbTruck.Properties.NullText = "";
            this.cbTruck.Properties.ValueMember = "id";
            this.cbTruck.Properties.View = this.truck_idSearchLookUpEditView;
            this.cbTruck.Size = new System.Drawing.Size(100, 20);
            this.cbTruck.TabIndex = 1;
            conditionValidationRule5.ErrorText = "This value is not valid";
            this.validator.SetValidationRule(this.cbTruck, conditionValidationRule5);
            // 
            // bdgTruck
            // 
            this.bdgTruck.DataSource = typeof(TruckSystem.truck);
            // 
            // truck_idSearchLookUpEditView
            // 
            this.truck_idSearchLookUpEditView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colboard});
            this.truck_idSearchLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.truck_idSearchLookUpEditView.Name = "truck_idSearchLookUpEditView";
            this.truck_idSearchLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.truck_idSearchLookUpEditView.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.Caption = "Cod.";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 179;
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
            // tfValue
            // 
            this.tfValue.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgPayment, "value", true));
            this.tfValue.Location = new System.Drawing.Point(294, 57);
            this.tfValue.Name = "tfValue";
            this.tfValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfValue.Properties.Mask.EditMask = "c2";
            this.tfValue.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfValue.Size = new System.Drawing.Size(100, 20);
            this.tfValue.TabIndex = 4;
            conditionValidationRule6.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule6.ErrorText = "Informe o Valor";
            conditionValidationRule6.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.validator.SetValidationRule(this.tfValue, conditionValidationRule6);
            // 
            // tfValuePaid
            // 
            this.tfValuePaid.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgPayment, "value_paid", true));
            this.tfValuePaid.Enabled = false;
            this.tfValuePaid.Location = new System.Drawing.Point(294, 83);
            this.tfValuePaid.Name = "tfValuePaid";
            this.tfValuePaid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfValuePaid.Properties.Mask.EditMask = "c2";
            this.tfValuePaid.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfValuePaid.Size = new System.Drawing.Size(100, 20);
            this.tfValuePaid.TabIndex = 7;
            conditionValidationRule7.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule7.ErrorText = "Informe o valor pago R$";
            conditionValidationRule7.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.validatorPaid.SetValidationRule(this.tfValuePaid, conditionValidationRule7);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "PaymentForm";
            this.Size = new System.Drawing.Size(625, 307);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfObservation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_idSearchLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDateExpiration.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDateExpiration.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckPaid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDatePayment.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDatePayment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfReasonExpiration.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTruck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgTruck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truck_idSearchLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValuePaid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorPaid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private WCButtons.Black.ButtonSaveBlack btnSave;
        private WCButtons.Black.ButtonCancelBlack btnCancel;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validator;
        private DevExpress.XtraEditors.SearchLookUpEdit cbCustomer;
        private System.Windows.Forms.BindingSource bdgPayment;
        private DevExpress.XtraGrid.Views.Grid.GridView customer_idSearchLookUpEditView;
        private DevExpress.XtraEditors.TextEdit tfDescription;
        private DevExpress.XtraEditors.DateEdit tfDateExpiration;
        private DevExpress.XtraEditors.TextEdit tfId;
        private DevExpress.XtraEditors.CheckEdit ckPaid;
        private DevExpress.XtraEditors.DateEdit tfDatePayment;
        private DevExpress.XtraEditors.TextEdit tfReasonExpiration;
        private DevExpress.XtraEditors.SearchLookUpEdit cbTruck;
        private DevExpress.XtraGrid.Views.Grid.GridView truck_idSearchLookUpEditView;
        private DevExpress.XtraEditors.CalcEdit tfValue;
        private DevExpress.XtraEditors.CalcEdit tfValuePaid;
        private DevExpress.XtraEditors.MemoEdit tfObservation;
        private System.Windows.Forms.BindingSource bdgCustomer;
        private System.Windows.Forms.BindingSource bdgTruck;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colcorporate_name;
        private DevExpress.XtraGrid.Columns.GridColumn colfantasy_name;
        private DevExpress.XtraGrid.Columns.GridColumn coldocument;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colboard;
        private DevExpress.XtraEditors.SimpleButton btnUpdateData;
        private WCButtons.Black.ButtonSettingsBlack btnParcel;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validatorPaid;
    }
}
