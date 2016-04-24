namespace TruckSystem.UI.Freights.Fueled
{
    partial class FueledForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FueledForm));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new WCButtons.Black.ButtonSaveBlack();
            this.btnCancel = new WCButtons.Black.ButtonCancelBlack();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.tfTotal = new DevExpress.XtraEditors.CalcEdit();
            this.bdgFueled = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.tfDiscount = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.tfValueLiters = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.tfDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tfKm = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbGasStation = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdgCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.gas_station_idSearchLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcorporate_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfantasy_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tfFreightId = new DevExpress.XtraEditors.TextEdit();
            this.tfId = new DevExpress.XtraEditors.TextEdit();
            this.tfLiters = new DevExpress.XtraEditors.TextEdit();
            this.validator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.colcnpj = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgFueled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValueLiters.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfKm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGasStation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gas_station_idSearchLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfFreightId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfLiters.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 53);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(646, 46);
            this.panelControl1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(417, 6);
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
            this.btnCancel.Location = new System.Drawing.Point(533, 6);
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
            this.panelControl2.AllowTouchScroll = true;
            this.panelControl2.Controls.Add(this.labelControl9);
            this.panelControl2.Controls.Add(this.tfTotal);
            this.panelControl2.Controls.Add(this.labelControl8);
            this.panelControl2.Controls.Add(this.tfDiscount);
            this.panelControl2.Controls.Add(this.labelControl7);
            this.panelControl2.Controls.Add(this.tfValueLiters);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.tfDate);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.tfKm);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.cbGasStation);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.tfFreightId);
            this.panelControl2.Controls.Add(this.tfId);
            this.panelControl2.Controls.Add(this.tfLiters);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(646, 53);
            this.panelControl2.TabIndex = 0;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(501, 34);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(44, 13);
            this.labelControl9.TabIndex = 19;
            this.labelControl9.Text = "R$ Total:";
            // 
            // tfTotal
            // 
            this.tfTotal.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgFueled, "total", true));
            this.tfTotal.Location = new System.Drawing.Point(551, 31);
            this.tfTotal.Name = "tfTotal";
            this.tfTotal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfTotal.Properties.Mask.EditMask = "c2";
            this.tfTotal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfTotal.Properties.ReadOnly = true;
            this.tfTotal.Size = new System.Drawing.Size(92, 20);
            this.tfTotal.TabIndex = 6;
            this.tfTotal.TabStop = false;
            // 
            // bdgFueled
            // 
            this.bdgFueled.DataSource = typeof(TruckSystem.fueled);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(362, 34);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(49, 13);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "Desconto:";
            // 
            // tfDiscount
            // 
            this.tfDiscount.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgFueled, "discount", true));
            this.tfDiscount.Location = new System.Drawing.Point(417, 31);
            this.tfDiscount.Name = "tfDiscount";
            this.tfDiscount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfDiscount.Properties.Mask.EditMask = "c2";
            this.tfDiscount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfDiscount.Size = new System.Drawing.Size(79, 20);
            this.tfDiscount.TabIndex = 5;
            this.tfDiscount.EditValueChanged += new System.EventHandler(this.calcValues);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(234, 34);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(41, 13);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "R$ Litro:";
            // 
            // tfValueLiters
            // 
            this.tfValueLiters.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgFueled, "value_liters", true));
            this.tfValueLiters.Location = new System.Drawing.Point(281, 31);
            this.tfValueLiters.Name = "tfValueLiters";
            this.tfValueLiters.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfValueLiters.Properties.Mask.EditMask = "c3";
            this.tfValueLiters.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfValueLiters.Size = new System.Drawing.Size(76, 20);
            this.tfValueLiters.TabIndex = 4;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule1.ErrorText = "Informe o valor por litro";
            conditionValidationRule1.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.validator.SetValidationRule(this.tfValueLiters, conditionValidationRule1);
            this.tfValueLiters.EditValueChanged += new System.EventHandler(this.calcValues);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(128, 34);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(30, 13);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "Litros:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(6, 34);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(27, 13);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Data:";
            // 
            // tfDate
            // 
            this.tfDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgFueled, "date", true));
            this.tfDate.EditValue = null;
            this.tfDate.Location = new System.Drawing.Point(42, 31);
            this.tfDate.Name = "tfDate";
            this.tfDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfDate.Size = new System.Drawing.Size(80, 20);
            this.tfDate.TabIndex = 2;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Informe a data";
            this.validator.SetValidationRule(this.tfDate, conditionValidationRule2);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(417, 8);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(18, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "KM:";
            // 
            // tfKm
            // 
            this.tfKm.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgFueled, "km", true));
            this.tfKm.Location = new System.Drawing.Point(441, 5);
            this.tfKm.Name = "tfKm";
            this.tfKm.Size = new System.Drawing.Size(110, 20);
            this.tfKm.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(110, 8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Posto:";
            // 
            // cbGasStation
            // 
            this.cbGasStation.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgFueled, "gas_station_id", true));
            this.cbGasStation.Location = new System.Drawing.Point(147, 5);
            this.cbGasStation.Name = "cbGasStation";
            this.cbGasStation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGasStation.Properties.DataSource = this.bdgCustomers;
            this.cbGasStation.Properties.DisplayMember = "corporate_name";
            this.cbGasStation.Properties.NullText = "";
            this.cbGasStation.Properties.ValueMember = "id";
            this.cbGasStation.Properties.View = this.gas_station_idSearchLookUpEditView;
            this.cbGasStation.Size = new System.Drawing.Size(264, 20);
            this.cbGasStation.TabIndex = 0;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule3.ErrorText = "Informe o posto";
            conditionValidationRule3.Value1 = ((long)(0));
            this.validator.SetValidationRule(this.cbGasStation, conditionValidationRule3);
            // 
            // bdgCustomers
            // 
            this.bdgCustomers.DataSource = typeof(TruckSystem.customer);
            // 
            // gas_station_idSearchLookUpEditView
            // 
            this.gas_station_idSearchLookUpEditView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcorporate_name,
            this.colfantasy_name,
            this.colcnpj});
            this.gas_station_idSearchLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gas_station_idSearchLookUpEditView.Name = "gas_station_idSearchLookUpEditView";
            this.gas_station_idSearchLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gas_station_idSearchLookUpEditView.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.Caption = "Cod.";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 79;
            // 
            // colcorporate_name
            // 
            this.colcorporate_name.Caption = "Razão Social";
            this.colcorporate_name.FieldName = "corporate_name";
            this.colcorporate_name.Name = "colcorporate_name";
            this.colcorporate_name.Visible = true;
            this.colcorporate_name.VisibleIndex = 1;
            this.colcorporate_name.Width = 359;
            // 
            // colfantasy_name
            // 
            this.colfantasy_name.Caption = "Nome Fantasia";
            this.colfantasy_name.FieldName = "fantasy_name";
            this.colfantasy_name.Name = "colfantasy_name";
            this.colfantasy_name.Visible = true;
            this.colfantasy_name.VisibleIndex = 2;
            this.colfantasy_name.Width = 373;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(557, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Cod.:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Frete:";
            // 
            // tfFreightId
            // 
            this.tfFreightId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgFueled, "freight_id", true));
            this.tfFreightId.Location = new System.Drawing.Point(42, 5);
            this.tfFreightId.Name = "tfFreightId";
            this.tfFreightId.Properties.ReadOnly = true;
            this.tfFreightId.Size = new System.Drawing.Size(60, 20);
            this.tfFreightId.TabIndex = 3;
            this.tfFreightId.TabStop = false;
            // 
            // tfId
            // 
            this.tfId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgFueled, "id", true));
            this.tfId.Location = new System.Drawing.Point(593, 5);
            this.tfId.Name = "tfId";
            this.tfId.Properties.ReadOnly = true;
            this.tfId.Size = new System.Drawing.Size(50, 20);
            this.tfId.TabIndex = 1;
            this.tfId.TabStop = false;
            // 
            // tfLiters
            // 
            this.tfLiters.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgFueled, "liters", true));
            this.tfLiters.Location = new System.Drawing.Point(164, 31);
            this.tfLiters.Name = "tfLiters";
            this.tfLiters.Properties.Mask.EditMask = "n2";
            this.tfLiters.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tfLiters.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfLiters.Size = new System.Drawing.Size(63, 20);
            this.tfLiters.TabIndex = 3;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule4.ErrorText = "Informe a quantidade de litros";
            conditionValidationRule4.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.validator.SetValidationRule(this.tfLiters, conditionValidationRule4);
            this.tfLiters.EditValueChanged += new System.EventHandler(this.calcValues);
            // 
            // colcnpj
            // 
            this.colcnpj.Caption = "CNPJ";
            this.colcnpj.FieldName = "cnpj";
            this.colcnpj.Name = "colcnpj";
            this.colcnpj.Visible = true;
            this.colcnpj.VisibleIndex = 3;
            this.colcnpj.Width = 267;
            // 
            // FueledForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 99);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FueledForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Novo Abastecimento";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgFueled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValueLiters.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfKm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGasStation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gas_station_idSearchLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfFreightId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfLiters.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private WCButtons.Black.ButtonCancelBlack btnCancel;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private WCButtons.Black.ButtonSaveBlack btnSave;
        private System.Windows.Forms.BindingSource bdgFueled;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit tfKm;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SearchLookUpEdit cbGasStation;
        private DevExpress.XtraGrid.Views.Grid.GridView gas_station_idSearchLookUpEditView;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tfFreightId;
        private DevExpress.XtraEditors.TextEdit tfId;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.CalcEdit tfDiscount;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.CalcEdit tfValueLiters;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit tfDate;
        private DevExpress.XtraEditors.TextEdit tfLiters;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.CalcEdit tfTotal;
        private System.Windows.Forms.BindingSource bdgCustomers;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcorporate_name;
        private DevExpress.XtraGrid.Columns.GridColumn colfantasy_name;
        private DevExpress.XtraGrid.Columns.GridColumn colcnpj;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validator;
    }
}