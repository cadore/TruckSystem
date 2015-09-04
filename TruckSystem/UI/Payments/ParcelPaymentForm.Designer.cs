namespace TruckSystem.UI.Payments
{
    partial class ParcelPaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParcelPaymentForm));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new WCButtons.Black.ButtonSaveBlack();
            this.btnCancel = new WCButtons.Black.ButtonCancelBlack();
            this.pnControlsGenerateParcels = new DevExpress.XtraEditors.PanelControl();
            this.btnGenereteParcels = new DevExpress.XtraEditors.SimpleButton();
            this.tfDaysEntryParcels = new DevExpress.XtraEditors.SpinEdit();
            this.tfQntParcels = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bdgPayments = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexpiration_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colvalue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.validator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnControlsGenerateParcels)).BeginInit();
            this.pnControlsGenerateParcels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfDaysEntryParcels.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfQntParcels.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 338);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(738, 44);
            this.panelControl1.TabIndex = 0;
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
            this.btnSave.Location = new System.Drawing.Point(507, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 33);
            this.btnSave.TabIndex = 1;
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
            this.btnCancel.Location = new System.Drawing.Point(623, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 33);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnControlsGenerateParcels
            // 
            this.pnControlsGenerateParcels.Controls.Add(this.btnGenereteParcels);
            this.pnControlsGenerateParcels.Controls.Add(this.tfDaysEntryParcels);
            this.pnControlsGenerateParcels.Controls.Add(this.tfQntParcels);
            this.pnControlsGenerateParcels.Controls.Add(this.labelControl2);
            this.pnControlsGenerateParcels.Controls.Add(this.labelControl1);
            this.pnControlsGenerateParcels.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnControlsGenerateParcels.Location = new System.Drawing.Point(0, 0);
            this.pnControlsGenerateParcels.Name = "pnControlsGenerateParcels";
            this.pnControlsGenerateParcels.Size = new System.Drawing.Size(738, 43);
            this.pnControlsGenerateParcels.TabIndex = 0;
            // 
            // btnGenereteParcels
            // 
            this.btnGenereteParcels.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnGenereteParcels.Location = new System.Drawing.Point(336, 7);
            this.btnGenereteParcels.Name = "btnGenereteParcels";
            this.btnGenereteParcels.Size = new System.Drawing.Size(111, 23);
            this.btnGenereteParcels.TabIndex = 3;
            this.btnGenereteParcels.Text = "Gerar Parcelas";
            this.btnGenereteParcels.Click += new System.EventHandler(this.btnGenereteParcels_Click);
            // 
            // tfDaysEntryParcels
            // 
            this.tfDaysEntryParcels.EditValue = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.tfDaysEntryParcels.Location = new System.Drawing.Point(282, 9);
            this.tfDaysEntryParcels.Name = "tfDaysEntryParcels";
            this.tfDaysEntryParcels.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfDaysEntryParcels.Properties.Mask.EditMask = "d2";
            this.tfDaysEntryParcels.Properties.MaxValue = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.tfDaysEntryParcels.Properties.MinValue = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.tfDaysEntryParcels.Size = new System.Drawing.Size(48, 20);
            this.tfDaysEntryParcels.TabIndex = 2;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule3.ErrorText = "Informe o intervalo de dias entre as Parcelas";
            conditionValidationRule3.Value1 = 1;
            this.validator.SetValidationRule(this.tfDaysEntryParcels, conditionValidationRule3);
            // 
            // tfQntParcels
            // 
            this.tfQntParcels.Location = new System.Drawing.Point(129, 9);
            this.tfQntParcels.Name = "tfQntParcels";
            this.tfQntParcels.Properties.Mask.EditMask = "d3";
            this.tfQntParcels.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tfQntParcels.Size = new System.Drawing.Size(56, 20);
            this.tfQntParcels.TabIndex = 1;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule1.ErrorText = "Informe a quantidade de Parcelas";
            conditionValidationRule1.Value1 = 1;
            this.validator.SetValidationRule(this.tfQntParcels, conditionValidationRule1);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(191, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Intervalo de dias:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(118, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Quantidade de parcelas:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 43);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(738, 295);
            this.panelControl2.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bdgPayments;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCalcEdit1,
            this.repositoryItemDateEdit1});
            this.gridControl1.Size = new System.Drawing.Size(734, 291);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.colexpiration_date,
            this.colvalue});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.Caption = "Cod.";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 55;
            // 
            // coldescription
            // 
            this.coldescription.Caption = "Descrição";
            this.coldescription.FieldName = "description";
            this.coldescription.Name = "coldescription";
            this.coldescription.OptionsColumn.AllowEdit = false;
            this.coldescription.Visible = true;
            this.coldescription.VisibleIndex = 1;
            this.coldescription.Width = 411;
            // 
            // colexpiration_date
            // 
            this.colexpiration_date.Caption = "Vencimento";
            this.colexpiration_date.ColumnEdit = this.repositoryItemDateEdit1;
            this.colexpiration_date.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colexpiration_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colexpiration_date.FieldName = "expiration_date";
            this.colexpiration_date.Name = "colexpiration_date";
            this.colexpiration_date.Visible = true;
            this.colexpiration_date.VisibleIndex = 2;
            this.colexpiration_date.Width = 134;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // colvalue
            // 
            this.colvalue.Caption = "R$ Valor";
            this.colvalue.ColumnEdit = this.repositoryItemCalcEdit1;
            this.colvalue.DisplayFormat.FormatString = "c2";
            this.colvalue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colvalue.FieldName = "value";
            this.colvalue.Name = "colvalue";
            this.colvalue.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "value", "{0:c2}")});
            this.colvalue.Visible = true;
            this.colvalue.VisibleIndex = 3;
            this.colvalue.Width = 136;
            // 
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            // 
            // ParcelPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 382);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.pnControlsGenerateParcels);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "ParcelPaymentForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Parcelar Pagamento";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnControlsGenerateParcels)).EndInit();
            this.pnControlsGenerateParcels.ResumeLayout(false);
            this.pnControlsGenerateParcels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfDaysEntryParcels.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfQntParcels.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private WCButtons.Black.ButtonCancelBlack btnCancel;
        private WCButtons.Black.ButtonSaveBlack btnSave;
        private DevExpress.XtraEditors.PanelControl pnControlsGenerateParcels;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit tfDaysEntryParcels;
        private DevExpress.XtraEditors.SimpleButton btnGenereteParcels;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bdgPayments;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescription;
        private DevExpress.XtraGrid.Columns.GridColumn colexpiration_date;
        private DevExpress.XtraGrid.Columns.GridColumn colvalue;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validator;
        private DevExpress.XtraEditors.TextEdit tfQntParcels;
    }
}