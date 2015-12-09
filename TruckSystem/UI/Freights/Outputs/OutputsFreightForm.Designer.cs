namespace TruckSystem.UI.Freights.Outputs
{
    partial class OutputsFreightForm
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
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label observationLabel;
            System.Windows.Forms.Label valueLabel;
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutputsFreightForm));
            this.lbCustomer = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tfObservation = new DevExpress.XtraEditors.MemoEdit();
            this.bdgOutput = new System.Windows.Forms.BindingSource(this.components);
            this.cbCustomer = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdgCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.customer_idSearchLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcorporate_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfantasy_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldocument = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tfDate = new DevExpress.XtraEditors.DateEdit();
            this.tfDescription = new DevExpress.XtraEditors.TextEdit();
            this.tfId = new DevExpress.XtraEditors.TextEdit();
            this.tfValue = new DevExpress.XtraEditors.CalcEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new WCButtons.Black.ButtonSaveBlack();
            this.btnCancel = new WCButtons.Black.ButtonCancelBlack();
            this.validator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            dateLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            observationLabel = new System.Windows.Forms.Label();
            valueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfObservation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_idSearchLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(461, 34);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(34, 13);
            dateLabel.TabIndex = 2;
            dateLabel.Text = "Data:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(5, 34);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(57, 13);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Descrição:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(461, 8);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(34, 13);
            idLabel.TabIndex = 8;
            idLabel.Text = "Cod.:";
            // 
            // observationLabel
            // 
            observationLabel.AutoSize = true;
            observationLabel.Location = new System.Drawing.Point(5, 87);
            observationLabel.Name = "observationLabel";
            observationLabel.Size = new System.Drawing.Size(74, 13);
            observationLabel.TabIndex = 10;
            observationLabel.Text = "Observações:";
            // 
            // valueLabel
            // 
            valueLabel.AutoSize = true;
            valueLabel.Location = new System.Drawing.Point(5, 60);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new System.Drawing.Size(35, 13);
            valueLabel.TabIndex = 16;
            valueLabel.Text = "Valor:";
            // 
            // lbCustomer
            // 
            this.lbCustomer.AutoSize = true;
            this.lbCustomer.Location = new System.Drawing.Point(5, 8);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(58, 13);
            this.lbCustomer.TabIndex = 0;
            this.lbCustomer.Text = "Prestador:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.tfObservation);
            this.panelControl1.Controls.Add(this.lbCustomer);
            this.panelControl1.Controls.Add(this.cbCustomer);
            this.panelControl1.Controls.Add(dateLabel);
            this.panelControl1.Controls.Add(this.tfDate);
            this.panelControl1.Controls.Add(descriptionLabel);
            this.panelControl1.Controls.Add(this.tfDescription);
            this.panelControl1.Controls.Add(idLabel);
            this.panelControl1.Controls.Add(this.tfId);
            this.panelControl1.Controls.Add(observationLabel);
            this.panelControl1.Controls.Add(valueLabel);
            this.panelControl1.Controls.Add(this.tfValue);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(609, 227);
            this.panelControl1.TabIndex = 0;
            // 
            // tfObservation
            // 
            this.tfObservation.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgOutput, "observation", true));
            this.tfObservation.Location = new System.Drawing.Point(8, 103);
            this.tfObservation.Name = "tfObservation";
            this.tfObservation.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfObservation.Size = new System.Drawing.Size(591, 74);
            this.tfObservation.TabIndex = 4;
            this.tfObservation.UseOptimizedRendering = true;
            // 
            // bdgOutput
            // 
            this.bdgOutput.DataSource = typeof(TruckSystem.output);
            // 
            // cbCustomer
            // 
            this.cbCustomer.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgOutput, "customer_id", true));
            this.cbCustomer.Location = new System.Drawing.Point(69, 5);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCustomer.Properties.DataSource = this.bdgCustomers;
            this.cbCustomer.Properties.DisplayMember = "corporate_name";
            this.cbCustomer.Properties.NullText = "";
            this.cbCustomer.Properties.ValueMember = "id";
            this.cbCustomer.Properties.View = this.customer_idSearchLookUpEditView;
            this.cbCustomer.Size = new System.Drawing.Size(386, 20);
            this.cbCustomer.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule1.ErrorText = "Informe o Prestador/Recebedor";
            conditionValidationRule1.Value1 = ((long)(0));
            this.validator.SetValidationRule(this.cbCustomer, conditionValidationRule1);
            // 
            // bdgCustomers
            // 
            this.bdgCustomers.DataSource = typeof(TruckSystem.customer);
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
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 117;
            // 
            // colcorporate_name
            // 
            this.colcorporate_name.Caption = "Razão Social";
            this.colcorporate_name.FieldName = "corporate_name";
            this.colcorporate_name.Name = "colcorporate_name";
            this.colcorporate_name.Visible = true;
            this.colcorporate_name.VisibleIndex = 1;
            this.colcorporate_name.Width = 341;
            // 
            // colfantasy_name
            // 
            this.colfantasy_name.Caption = "Nome Fantasia";
            this.colfantasy_name.FieldName = "fantasy_name";
            this.colfantasy_name.Name = "colfantasy_name";
            this.colfantasy_name.Visible = true;
            this.colfantasy_name.VisibleIndex = 2;
            this.colfantasy_name.Width = 343;
            // 
            // coldocument
            // 
            this.coldocument.Caption = "CNPJ/CPF";
            this.coldocument.FieldName = "document";
            this.coldocument.Name = "coldocument";
            this.coldocument.Visible = true;
            this.coldocument.VisibleIndex = 3;
            this.coldocument.Width = 277;
            // 
            // tfDate
            // 
            this.tfDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgOutput, "date", true));
            this.tfDate.EditValue = null;
            this.tfDate.Location = new System.Drawing.Point(499, 31);
            this.tfDate.Name = "tfDate";
            this.tfDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfDate.Size = new System.Drawing.Size(100, 20);
            this.tfDate.TabIndex = 2;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Informe a data";
            this.validator.SetValidationRule(this.tfDate, conditionValidationRule2);
            // 
            // tfDescription
            // 
            this.tfDescription.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgOutput, "description", true));
            this.tfDescription.Location = new System.Drawing.Point(69, 31);
            this.tfDescription.Name = "tfDescription";
            this.tfDescription.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfDescription.Size = new System.Drawing.Size(386, 20);
            this.tfDescription.TabIndex = 1;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Informe a descrição";
            this.validator.SetValidationRule(this.tfDescription, conditionValidationRule3);
            // 
            // tfId
            // 
            this.tfId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgOutput, "id", true));
            this.tfId.Location = new System.Drawing.Point(499, 5);
            this.tfId.Name = "tfId";
            this.tfId.Properties.ReadOnly = true;
            this.tfId.Size = new System.Drawing.Size(100, 20);
            this.tfId.TabIndex = 9;
            this.tfId.TabStop = false;
            // 
            // tfValue
            // 
            this.tfValue.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgOutput, "value", true));
            this.tfValue.Location = new System.Drawing.Point(69, 57);
            this.tfValue.Name = "tfValue";
            this.tfValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfValue.Properties.Mask.EditMask = "c2";
            this.tfValue.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfValue.Size = new System.Drawing.Size(125, 20);
            this.tfValue.TabIndex = 3;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule4.ErrorText = "Informe o valor";
            conditionValidationRule4.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.validator.SetValidationRule(this.tfValue, conditionValidationRule4);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnSave);
            this.panelControl2.Controls.Add(this.btnCancel);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 184);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(609, 43);
            this.panelControl2.TabIndex = 1;
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
            this.btnSave.Location = new System.Drawing.Point(378, 5);
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
            this.btnCancel.Location = new System.Drawing.Point(494, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 33);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // OutputsFreightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 227);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OutputsFreightForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nova Despesa";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfObservation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_idSearchLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.validator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private WCButtons.Black.ButtonSaveBlack btnSave;
        private WCButtons.Black.ButtonCancelBlack btnCancel;
        private System.Windows.Forms.BindingSource bdgOutput;
        private DevExpress.XtraEditors.SearchLookUpEdit cbCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView customer_idSearchLookUpEditView;
        private DevExpress.XtraEditors.DateEdit tfDate;
        private DevExpress.XtraEditors.TextEdit tfDescription;
        private DevExpress.XtraEditors.TextEdit tfId;
        private DevExpress.XtraEditors.CalcEdit tfValue;
        private DevExpress.XtraEditors.MemoEdit tfObservation;
        private System.Windows.Forms.Label lbCustomer;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validator;
        private System.Windows.Forms.BindingSource bdgCustomers;
        private DevExpress.XtraGrid.Columns.GridColumn colcorporate_name;
        private DevExpress.XtraGrid.Columns.GridColumn coldocument;
        private DevExpress.XtraGrid.Columns.GridColumn colfantasy_name;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}