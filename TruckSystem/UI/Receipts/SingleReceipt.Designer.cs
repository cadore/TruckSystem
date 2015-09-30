namespace TruckSystem.UI.Receipts
{
    partial class SingleReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleReceipt));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule6 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule7 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule8 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.btnPrint = new WCButtons.Black.ButtonSettingsBlack();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tfReceiveTo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tfReference = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tfNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tfDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.tfEmitter = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.tfDocument = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.rgType = new DevExpress.XtraEditors.RadioGroup();
            this.btnCancel = new WCButtons.Black.ButtonCancelBlack();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.tfValue = new DevExpress.XtraEditors.TextEdit();
            this.bdgState = new System.Windows.Forms.BindingSource(this.components);
            this.bdgCity = new System.Windows.Forms.BindingSource(this.components);
            this.cbCity = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbState = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.validator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.ckDouble = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tfReceiveTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfReference.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfEmitter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDocument.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckDouble.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(371, 171);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(110, 33);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Recebi(emos) de:";
            // 
            // tfReceiveTo
            // 
            this.tfReceiveTo.Location = new System.Drawing.Point(102, 13);
            this.tfReceiveTo.Name = "tfReceiveTo";
            this.tfReceiveTo.Size = new System.Drawing.Size(381, 20);
            this.tfReceiveTo.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Informe o Recebi(emos)";
            this.validator.SetValidationRule(this.tfReceiveTo, conditionValidationRule1);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Referente à:";
            // 
            // tfReference
            // 
            this.tfReference.Location = new System.Drawing.Point(102, 65);
            this.tfReference.Name = "tfReference";
            this.tfReference.Size = new System.Drawing.Size(495, 20);
            this.tfReference.TabIndex = 3;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Informe a Referencia";
            this.validator.SetValidationRule(this.tfReference, conditionValidationRule2);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(489, 16);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Número:";
            // 
            // tfNumber
            // 
            this.tfNumber.Location = new System.Drawing.Point(536, 13);
            this.tfNumber.Name = "tfNumber";
            this.tfNumber.Size = new System.Drawing.Size(61, 20);
            this.tfNumber.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 94);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(27, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Data:";
            // 
            // tfDate
            // 
            this.tfDate.EditValue = null;
            this.tfDate.Location = new System.Drawing.Point(102, 91);
            this.tfDate.Name = "tfDate";
            this.tfDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfDate.Size = new System.Drawing.Size(100, 20);
            this.tfDate.TabIndex = 4;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Informe a Data";
            this.validator.SetValidationRule(this.tfDate, conditionValidationRule3);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(318, 94);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(37, 13);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Cidade:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 124);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(56, 13);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "Recebedor:";
            // 
            // tfEmitter
            // 
            this.tfEmitter.Location = new System.Drawing.Point(102, 117);
            this.tfEmitter.Name = "tfEmitter";
            this.tfEmitter.Size = new System.Drawing.Size(495, 20);
            this.tfEmitter.TabIndex = 7;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Informe o Recebedor";
            this.validator.SetValidationRule(this.tfEmitter, conditionValidationRule4);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(208, 94);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(37, 13);
            this.labelControl8.TabIndex = 1;
            this.labelControl8.Text = "Estado:";
            // 
            // tfDocument
            // 
            this.tfDocument.Enabled = false;
            this.tfDocument.Location = new System.Drawing.Point(208, 145);
            this.tfDocument.Name = "tfDocument";
            this.tfDocument.Size = new System.Drawing.Size(389, 20);
            this.tfDocument.TabIndex = 9;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "Informe o Documento";
            this.validator.SetValidationRule(this.tfDocument, conditionValidationRule5);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 150);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(58, 13);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "Documento:";
            // 
            // rgType
            // 
            this.rgType.Location = new System.Drawing.Point(102, 143);
            this.rgType.Name = "rgType";
            this.rgType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgType.Properties.Appearance.Options.UseBackColor = true;
            this.rgType.Properties.Columns = 2;
            this.rgType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("cpf", "CPF"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("cnpj", "CNPJ")});
            this.rgType.Size = new System.Drawing.Size(100, 22);
            this.rgType.TabIndex = 8;
            this.rgType.SelectedIndexChanged += new System.EventHandler(this.rgType_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(487, 171);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 33);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(12, 42);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(28, 13);
            this.labelControl9.TabIndex = 1;
            this.labelControl9.Text = "Valor:";
            // 
            // tfValue
            // 
            this.tfValue.Location = new System.Drawing.Point(102, 39);
            this.tfValue.Name = "tfValue";
            this.tfValue.Properties.Mask.EditMask = "c2";
            this.tfValue.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tfValue.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfValue.Size = new System.Drawing.Size(495, 20);
            this.tfValue.TabIndex = 2;
            conditionValidationRule6.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule6.ErrorText = "Informe o Valor";
            conditionValidationRule6.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.validator.SetValidationRule(this.tfValue, conditionValidationRule6);
            // 
            // bdgState
            // 
            this.bdgState.DataSource = typeof(TruckSystem.state);
            // 
            // bdgCity
            // 
            this.bdgCity.DataSource = typeof(TruckSystem.city);
            // 
            // cbCity
            // 
            this.cbCity.Location = new System.Drawing.Point(361, 91);
            this.cbCity.Name = "cbCity";
            this.cbCity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCity.Properties.DataSource = this.bdgCity;
            this.cbCity.Properties.DisplayMember = "name";
            this.cbCity.Properties.NullText = "";
            this.cbCity.Properties.ValueMember = "name";
            this.cbCity.Properties.View = this.searchLookUpEdit1View;
            this.cbCity.Size = new System.Drawing.Size(236, 20);
            this.cbCity.TabIndex = 6;
            conditionValidationRule7.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule7.ErrorText = "Informe a Cidade";
            conditionValidationRule7.Value1 = ((long)(0));
            this.validator.SetValidationRule(this.cbCity, conditionValidationRule7);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colname});
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
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 227;
            // 
            // colname
            // 
            this.colname.Caption = "Nome";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            this.colname.Width = 851;
            // 
            // cbState
            // 
            this.cbState.Location = new System.Drawing.Point(251, 91);
            this.cbState.Name = "cbState";
            this.cbState.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbState.Properties.DataSource = this.bdgState;
            this.cbState.Properties.DisplayMember = "symbol";
            this.cbState.Properties.NullText = "";
            this.cbState.Properties.ValueMember = "id";
            this.cbState.Properties.View = this.searchLookUpEdit2View;
            this.cbState.Size = new System.Drawing.Size(61, 20);
            this.cbState.TabIndex = 5;
            conditionValidationRule8.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule8.ErrorText = "Informe o Estado";
            conditionValidationRule8.Value1 = ((long)(0));
            this.validator.SetValidationRule(this.cbState, conditionValidationRule8);
            this.cbState.EditValueChanged += new System.EventHandler(this.cbState_EditValueChanged);
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Cod.";
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 278;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nome";
            this.gridColumn2.FieldName = "name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 800;
            // 
            // ckDouble
            // 
            this.ckDouble.Location = new System.Drawing.Point(290, 182);
            this.ckDouble.Name = "ckDouble";
            this.ckDouble.Properties.Caption = "Duas vias";
            this.ckDouble.Size = new System.Drawing.Size(75, 15);
            this.ckDouble.TabIndex = 10;
            // 
            // SingleReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ckDouble);
            this.Controls.Add(this.cbState);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.rgType);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.tfDate);
            this.Controls.Add(this.tfReference);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.tfNumber);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.tfDocument);
            this.Controls.Add(this.tfEmitter);
            this.Controls.Add(this.tfValue);
            this.Controls.Add(this.tfReceiveTo);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnPrint);
            this.Name = "SingleReceipt";
            this.Size = new System.Drawing.Size(604, 209);
            ((System.ComponentModel.ISupportInitialize)(this.tfReceiveTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfReference.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfEmitter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDocument.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckDouble.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WCButtons.Black.ButtonSettingsBlack btnPrint;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tfReceiveTo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit tfReference;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tfNumber;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit tfDate;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit tfEmitter;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit tfDocument;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.RadioGroup rgType;
        private WCButtons.Black.ButtonCancelBlack btnCancel;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit tfValue;
        private System.Windows.Forms.BindingSource bdgState;
        private System.Windows.Forms.BindingSource bdgCity;
        private DevExpress.XtraEditors.SearchLookUpEdit cbCity;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraEditors.SearchLookUpEdit cbState;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validator;
        private DevExpress.XtraEditors.CheckEdit ckDouble;
    }
}
