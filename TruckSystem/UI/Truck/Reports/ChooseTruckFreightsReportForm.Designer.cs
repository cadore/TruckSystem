namespace TruckSystem.UI.Truck.Reports
{
    partial class ChooseTruckFreightsReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseTruckFreightsReportForm));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbDriver = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfull_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcpf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ckDriver = new System.Windows.Forms.RadioButton();
            this.ckTruck = new System.Windows.Forms.RadioButton();
            this.btnGenerate = new WCButtons.Black.ButtonSettingsBlack();
            this.btnCancel = new WCButtons.Black.ButtonCancelBlack();
            this.dtEnd = new DevExpress.XtraEditors.DateEdit();
            this.dtStart = new DevExpress.XtraEditors.DateEdit();
            this.cbTruck = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colboard = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.validator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.bdgDrivers = new System.Windows.Forms.BindingSource(this.components);
            this.bdgTruck = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbDriver.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTruck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgTruck)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbDriver);
            this.groupControl1.Controls.Add(this.ckDriver);
            this.groupControl1.Controls.Add(this.ckTruck);
            this.groupControl1.Controls.Add(this.btnGenerate);
            this.groupControl1.Controls.Add(this.btnCancel);
            this.groupControl1.Controls.Add(this.dtEnd);
            this.groupControl1.Controls.Add(this.dtStart);
            this.groupControl1.Controls.Add(this.cbTruck);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(533, 151);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Relatorio de Fretes por Veículo";
            // 
            // cbDriver
            // 
            this.cbDriver.Location = new System.Drawing.Point(92, 51);
            this.cbDriver.Name = "cbDriver";
            this.cbDriver.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDriver.Properties.DataSource = this.bdgDrivers;
            this.cbDriver.Properties.DisplayMember = "full_name";
            this.cbDriver.Properties.NullText = "";
            this.cbDriver.Properties.ReadOnly = true;
            this.cbDriver.Properties.ValueMember = "id";
            this.cbDriver.Properties.View = this.gridView1;
            this.cbDriver.Size = new System.Drawing.Size(434, 20);
            this.cbDriver.TabIndex = 6;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colfull_name,
            this.colcpf});
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
            this.gridColumn1.Width = 177;
            // 
            // colfull_name
            // 
            this.colfull_name.Caption = "Nome";
            this.colfull_name.FieldName = "full_name";
            this.colfull_name.Name = "colfull_name";
            this.colfull_name.Visible = true;
            this.colfull_name.VisibleIndex = 1;
            this.colfull_name.Width = 479;
            // 
            // colcpf
            // 
            this.colcpf.Caption = "CPF";
            this.colcpf.FieldName = "cpf";
            this.colcpf.Name = "colcpf";
            this.colcpf.Visible = true;
            this.colcpf.VisibleIndex = 2;
            this.colcpf.Width = 422;
            // 
            // ckDriver
            // 
            this.ckDriver.AutoSize = true;
            this.ckDriver.Location = new System.Drawing.Point(12, 52);
            this.ckDriver.Name = "ckDriver";
            this.ckDriver.Size = new System.Drawing.Size(74, 17);
            this.ckDriver.TabIndex = 5;
            this.ckDriver.TabStop = true;
            this.ckDriver.Tag = "1";
            this.ckDriver.Text = "Motorista:";
            this.ckDriver.UseVisualStyleBackColor = true;
            this.ckDriver.CheckedChanged += new System.EventHandler(this.ckCheckedChanged);
            // 
            // ckTruck
            // 
            this.ckTruck.AutoSize = true;
            this.ckTruck.Location = new System.Drawing.Point(12, 26);
            this.ckTruck.Name = "ckTruck";
            this.ckTruck.Size = new System.Drawing.Size(62, 17);
            this.ckTruck.TabIndex = 5;
            this.ckTruck.TabStop = true;
            this.ckTruck.Tag = "0";
            this.ckTruck.Text = "Veículo:";
            this.ckTruck.UseVisualStyleBackColor = true;
            this.ckTruck.CheckedChanged += new System.EventHandler(this.ckCheckedChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerate.Image")));
            this.btnGenerate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerate.Location = new System.Drawing.Point(254, 110);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(155, 33);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Gerar Relatório";
            this.btnGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(416, 110);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 33);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtEnd
            // 
            this.dtEnd.EditValue = null;
            this.dtEnd.Enabled = false;
            this.dtEnd.Location = new System.Drawing.Point(254, 77);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEnd.Size = new System.Drawing.Size(138, 20);
            this.dtEnd.TabIndex = 2;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Informe a Data Final";
            this.validator.SetValidationRule(this.dtEnd, conditionValidationRule1);
            // 
            // dtStart
            // 
            this.dtStart.EditValue = null;
            this.dtStart.Enabled = false;
            this.dtStart.Location = new System.Drawing.Point(92, 77);
            this.dtStart.Name = "dtStart";
            this.dtStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtStart.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtStart.Size = new System.Drawing.Size(138, 20);
            this.dtStart.TabIndex = 1;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Informe a Data Inicial";
            this.validator.SetValidationRule(this.dtStart, conditionValidationRule2);
            // 
            // cbTruck
            // 
            this.cbTruck.Location = new System.Drawing.Point(92, 25);
            this.cbTruck.Name = "cbTruck";
            this.cbTruck.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTruck.Properties.DataSource = this.bdgTruck;
            this.cbTruck.Properties.DisplayMember = "board";
            this.cbTruck.Properties.NullText = "";
            this.cbTruck.Properties.ReadOnly = true;
            this.cbTruck.Properties.ValueMember = "id";
            this.cbTruck.Properties.View = this.searchLookUpEdit1View;
            this.cbTruck.Size = new System.Drawing.Size(434, 20);
            this.cbTruck.TabIndex = 0;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colboard});
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
            this.colid.Width = 263;
            // 
            // colboard
            // 
            this.colboard.Caption = "Board";
            this.colboard.FieldName = "board";
            this.colboard.Name = "colboard";
            this.colboard.OptionsColumn.AllowEdit = false;
            this.colboard.Visible = true;
            this.colboard.VisibleIndex = 1;
            this.colboard.Width = 815;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(236, 80);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(12, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = " à ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 80);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Període de:";
            // 
            // bdgDrivers
            // 
            this.bdgDrivers.DataSource = typeof(TruckSystem.driver);
            // 
            // bdgTruck
            // 
            this.bdgTruck.DataSource = typeof(TruckSystem.truck);
            // 
            // ChooseTruckFreightsReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 151);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "ChooseTruckFreightsReportForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbDriver.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTruck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgTruck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.DateEdit dtEnd;
        private DevExpress.XtraEditors.DateEdit dtStart;
        private DevExpress.XtraEditors.SearchLookUpEdit cbTruck;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private WCButtons.Black.ButtonCancelBlack btnCancel;
        private WCButtons.Black.ButtonSettingsBlack btnGenerate;
        private System.Windows.Forms.BindingSource bdgTruck;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colboard;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validator;
        private DevExpress.XtraEditors.SearchLookUpEdit cbDriver;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.RadioButton ckDriver;
        private System.Windows.Forms.RadioButton ckTruck;
        private System.Windows.Forms.BindingSource bdgDrivers;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colfull_name;
        private DevExpress.XtraGrid.Columns.GridColumn colcpf;
    }
}