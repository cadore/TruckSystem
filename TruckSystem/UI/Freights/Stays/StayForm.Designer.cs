namespace TruckSystem.UI.Freights.Stays
{
    partial class StayForm
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
            DevExpress.XtraEditors.LabelControl endLabel;
            DevExpress.XtraEditors.LabelControl freight_idLabel;
            DevExpress.XtraEditors.LabelControl idLabel;
            DevExpress.XtraEditors.LabelControl startLabel;
            DevExpress.XtraEditors.LabelControl totalLabel;
            DevExpress.XtraEditors.LabelControl truck_idLabel;
            DevExpress.XtraEditors.LabelControl value_horLabel;
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StayForm));
            DevExpress.XtraEditors.LabelControl labelControl4;
            this.tfDateEnd = new DevExpress.XtraEditors.DateEdit();
            this.tfId = new DevExpress.XtraEditors.TextEdit();
            this.tfDateStart = new DevExpress.XtraEditors.DateEdit();
            this.tfValueEstay = new DevExpress.XtraEditors.CalcEdit();
            this.tfValueHor = new DevExpress.XtraEditors.CalcEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.tfTaxeComission = new DevExpress.XtraEditors.CalcEdit();
            this.tfNameDriver = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tfTimeEnd = new DevExpress.XtraEditors.TimeEdit();
            this.tfTimeStart = new DevExpress.XtraEditors.TimeEdit();
            this.tfTotalComission = new DevExpress.XtraEditors.CalcEdit();
            this.btnSave = new WCButtons.Black.ButtonSaveBlack();
            this.btnCancel = new WCButtons.Black.ButtonCancelBlack();
            this.tfTruck = new DevExpress.XtraEditors.TextEdit();
            this.tfFreight = new DevExpress.XtraEditors.TextEdit();
            this.tfTotal = new DevExpress.XtraEditors.CalcEdit();
            this.bdgStay = new System.Windows.Forms.BindingSource(this.components);
            this.validator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            endLabel = new DevExpress.XtraEditors.LabelControl();
            freight_idLabel = new DevExpress.XtraEditors.LabelControl();
            idLabel = new DevExpress.XtraEditors.LabelControl();
            startLabel = new DevExpress.XtraEditors.LabelControl();
            totalLabel = new DevExpress.XtraEditors.LabelControl();
            truck_idLabel = new DevExpress.XtraEditors.LabelControl();
            value_horLabel = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tfDateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDateStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDateStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValueEstay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValueHor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfTaxeComission.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfNameDriver.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfTimeEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfTimeStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfTotalComission.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfTruck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfFreight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgStay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).BeginInit();
            this.SuspendLayout();
            // 
            // endLabel
            // 
            endLabel.Location = new System.Drawing.Point(6, 60);
            endLabel.Name = "endLabel";
            endLabel.Size = new System.Drawing.Size(20, 13);
            endLabel.TabIndex = 1;
            endLabel.Text = "Fim:";
            // 
            // freight_idLabel
            // 
            freight_idLabel.Location = new System.Drawing.Point(161, 8);
            freight_idLabel.Name = "freight_idLabel";
            freight_idLabel.Size = new System.Drawing.Size(30, 13);
            freight_idLabel.TabIndex = 3;
            freight_idLabel.Text = "Frete:";
            // 
            // idLabel
            // 
            idLabel.Location = new System.Drawing.Point(255, 8);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(27, 13);
            idLabel.TabIndex = 5;
            idLabel.Text = "Cod.:";
            // 
            // startLabel
            // 
            startLabel.Location = new System.Drawing.Point(6, 34);
            startLabel.Name = "startLabel";
            startLabel.Size = new System.Drawing.Size(29, 13);
            startLabel.TabIndex = 7;
            startLabel.Text = "Inicio:";
            // 
            // totalLabel
            // 
            totalLabel.Location = new System.Drawing.Point(160, 86);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(66, 13);
            totalLabel.TabIndex = 9;
            totalLabel.Text = "Total Estadia:";
            // 
            // truck_idLabel
            // 
            truck_idLabel.Location = new System.Drawing.Point(5, 8);
            truck_idLabel.Name = "truck_idLabel";
            truck_idLabel.Size = new System.Drawing.Size(51, 13);
            truck_idLabel.TabIndex = 11;
            truck_idLabel.Text = "Caminhão:";
            // 
            // value_horLabel
            // 
            value_horLabel.Location = new System.Drawing.Point(6, 86);
            value_horLabel.Name = "value_horLabel";
            value_horLabel.Size = new System.Drawing.Size(43, 13);
            value_horLabel.TabIndex = 13;
            value_horLabel.Text = "R$ Hora:";
            // 
            // tfDateEnd
            // 
            this.tfDateEnd.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgStay, "end", true));
            this.tfDateEnd.EditValue = null;
            this.tfDateEnd.Location = new System.Drawing.Point(63, 57);
            this.tfDateEnd.Name = "tfDateEnd";
            this.tfDateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfDateEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfDateEnd.Size = new System.Drawing.Size(93, 20);
            this.tfDateEnd.TabIndex = 2;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Informe a data Final";
            this.validator.SetValidationRule(this.tfDateEnd, conditionValidationRule1);
            this.tfDateEnd.EditValueChanged += new System.EventHandler(this.calcValues);
            // 
            // tfId
            // 
            this.tfId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgStay, "id", true));
            this.tfId.Location = new System.Drawing.Point(288, 5);
            this.tfId.Name = "tfId";
            this.tfId.Properties.ReadOnly = true;
            this.tfId.Size = new System.Drawing.Size(53, 20);
            this.tfId.TabIndex = 6;
            // 
            // tfDateStart
            // 
            this.tfDateStart.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgStay, "start", true));
            this.tfDateStart.EditValue = null;
            this.tfDateStart.Location = new System.Drawing.Point(63, 31);
            this.tfDateStart.Name = "tfDateStart";
            this.tfDateStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfDateStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfDateStart.Size = new System.Drawing.Size(93, 20);
            this.tfDateStart.TabIndex = 8;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Informe a data Inicio";
            this.validator.SetValidationRule(this.tfDateStart, conditionValidationRule2);
            this.tfDateStart.EditValueChanged += new System.EventHandler(this.calcValues);
            // 
            // tfValueEstay
            // 
            this.tfValueEstay.Location = new System.Drawing.Point(242, 83);
            this.tfValueEstay.Name = "tfValueEstay";
            this.tfValueEstay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfValueEstay.Properties.Mask.EditMask = "c2";
            this.tfValueEstay.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfValueEstay.Properties.ReadOnly = true;
            this.tfValueEstay.Size = new System.Drawing.Size(100, 20);
            this.tfValueEstay.TabIndex = 10;
            // 
            // tfValueHor
            // 
            this.tfValueHor.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgStay, "value_hor", true));
            this.tfValueHor.Location = new System.Drawing.Point(63, 83);
            this.tfValueHor.Name = "tfValueHor";
            this.tfValueHor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfValueHor.Properties.Mask.EditMask = "c2";
            this.tfValueHor.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfValueHor.Size = new System.Drawing.Size(93, 20);
            this.tfValueHor.TabIndex = 14;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule3.ErrorText = "Informe o valor por hora por tonelada";
            conditionValidationRule3.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.validator.SetValidationRule(this.tfValueHor, conditionValidationRule3);
            this.tfValueHor.EditValueChanged += new System.EventHandler(this.calcValues);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 192);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(353, 44);
            this.panelControl1.TabIndex = 15;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.tfFreight);
            this.panelControl2.Controls.Add(this.tfTruck);
            this.panelControl2.Controls.Add(this.tfTotalComission);
            this.panelControl2.Controls.Add(this.tfTaxeComission);
            this.panelControl2.Controls.Add(this.tfNameDriver);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.tfTimeEnd);
            this.panelControl2.Controls.Add(this.tfTimeStart);
            this.panelControl2.Controls.Add(this.tfDateStart);
            this.panelControl2.Controls.Add(this.tfValueHor);
            this.panelControl2.Controls.Add(endLabel);
            this.panelControl2.Controls.Add(value_horLabel);
            this.panelControl2.Controls.Add(this.tfDateEnd);
            this.panelControl2.Controls.Add(freight_idLabel);
            this.panelControl2.Controls.Add(truck_idLabel);
            this.panelControl2.Controls.Add(this.tfTotal);
            this.panelControl2.Controls.Add(this.tfValueEstay);
            this.panelControl2.Controls.Add(labelControl4);
            this.panelControl2.Controls.Add(idLabel);
            this.panelControl2.Controls.Add(totalLabel);
            this.panelControl2.Controls.Add(this.tfId);
            this.panelControl2.Controls.Add(startLabel);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(353, 192);
            this.panelControl2.TabIndex = 16;
            // 
            // tfTaxeComission
            // 
            this.tfTaxeComission.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgStay, "taxe_comission", true));
            this.tfTaxeComission.Location = new System.Drawing.Point(63, 135);
            this.tfTaxeComission.Name = "tfTaxeComission";
            this.tfTaxeComission.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfTaxeComission.Properties.Mask.EditMask = "n2";
            this.tfTaxeComission.Size = new System.Drawing.Size(93, 20);
            this.tfTaxeComission.TabIndex = 18;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule4.ErrorText = "Informe a % de comissão do motorista";
            conditionValidationRule4.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.validator.SetValidationRule(this.tfTaxeComission, conditionValidationRule4);
            this.tfTaxeComission.EditValueChanged += new System.EventHandler(this.calcValues);
            // 
            // tfNameDriver
            // 
            this.tfNameDriver.Location = new System.Drawing.Point(63, 109);
            this.tfNameDriver.Name = "tfNameDriver";
            this.tfNameDriver.Properties.ReadOnly = true;
            this.tfNameDriver.Size = new System.Drawing.Size(279, 20);
            this.tfNameDriver.TabIndex = 17;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(160, 138);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(76, 13);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Total Comissão:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 138);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 13);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Comissão:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 112);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 13);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Motorista:";
            // 
            // tfTimeEnd
            // 
            this.tfTimeEnd.EditValue = new System.DateTime(2015, 7, 9, 0, 0, 0, 0);
            this.tfTimeEnd.Location = new System.Drawing.Point(160, 57);
            this.tfTimeEnd.Name = "tfTimeEnd";
            this.tfTimeEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfTimeEnd.Properties.Mask.EditMask = "HH:mm";
            this.tfTimeEnd.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.tfTimeEnd.Size = new System.Drawing.Size(65, 20);
            this.tfTimeEnd.TabIndex = 15;
            this.tfTimeEnd.EditValueChanged += new System.EventHandler(this.calcValues);
            // 
            // tfTimeStart
            // 
            this.tfTimeStart.EditValue = new System.DateTime(2015, 7, 9, 0, 0, 0, 0);
            this.tfTimeStart.Location = new System.Drawing.Point(160, 31);
            this.tfTimeStart.Name = "tfTimeStart";
            this.tfTimeStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfTimeStart.Properties.Mask.EditMask = "HH:mm";
            this.tfTimeStart.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.tfTimeStart.Size = new System.Drawing.Size(65, 20);
            this.tfTimeStart.TabIndex = 15;
            this.tfTimeStart.EditValueChanged += new System.EventHandler(this.calcValues);
            // 
            // tfTotalComission
            // 
            this.tfTotalComission.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgStay, "total_comission", true));
            this.tfTotalComission.Location = new System.Drawing.Point(242, 135);
            this.tfTotalComission.Name = "tfTotalComission";
            this.tfTotalComission.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfTotalComission.Properties.Mask.EditMask = "c2";
            this.tfTotalComission.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfTotalComission.Properties.ReadOnly = true;
            this.tfTotalComission.Size = new System.Drawing.Size(100, 20);
            this.tfTotalComission.TabIndex = 23;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(115, 6);
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
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(231, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 33);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tfTruck
            // 
            this.tfTruck.Location = new System.Drawing.Point(62, 5);
            this.tfTruck.Name = "tfTruck";
            this.tfTruck.Properties.ReadOnly = true;
            this.tfTruck.Size = new System.Drawing.Size(93, 20);
            this.tfTruck.TabIndex = 24;
            // 
            // tfFreight
            // 
            this.tfFreight.Location = new System.Drawing.Point(197, 5);
            this.tfFreight.Name = "tfFreight";
            this.tfFreight.Properties.ReadOnly = true;
            this.tfFreight.Size = new System.Drawing.Size(52, 20);
            this.tfFreight.TabIndex = 24;
            // 
            // labelControl4
            // 
            labelControl4.Location = new System.Drawing.Point(134, 170);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(102, 13);
            labelControl4.TabIndex = 9;
            labelControl4.Text = "Total Liquido Estadia:";
            // 
            // tfTotal
            // 
            this.tfTotal.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgStay, "total", true));
            this.tfTotal.Location = new System.Drawing.Point(242, 167);
            this.tfTotal.Name = "tfTotal";
            this.tfTotal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfTotal.Properties.Mask.EditMask = "c2";
            this.tfTotal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfTotal.Properties.ReadOnly = true;
            this.tfTotal.Size = new System.Drawing.Size(100, 20);
            this.tfTotal.TabIndex = 10;
            // 
            // bdgStay
            // 
            this.bdgStay.DataSource = typeof(TruckSystem.stay);
            // 
            // StayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 236);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StayForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Estadia";
            ((System.ComponentModel.ISupportInitialize)(this.tfDateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDateStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDateStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValueEstay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValueHor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfTaxeComission.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfNameDriver.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfTimeEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfTimeStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfTotalComission.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfTruck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfFreight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgStay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit tfDateEnd;
        private DevExpress.XtraEditors.TextEdit tfId;
        private DevExpress.XtraEditors.DateEdit tfDateStart;
        private DevExpress.XtraEditors.CalcEdit tfValueEstay;
        private DevExpress.XtraEditors.CalcEdit tfValueHor;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TimeEdit tfTimeEnd;
        private DevExpress.XtraEditors.TimeEdit tfTimeStart;
        private WCButtons.Black.ButtonSaveBlack btnSave;
        private WCButtons.Black.ButtonCancelBlack btnCancel;
        private DevExpress.XtraEditors.TextEdit tfNameDriver;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CalcEdit tfTaxeComission;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public System.Windows.Forms.BindingSource bdgStay;
        private DevExpress.XtraEditors.CalcEdit tfTotalComission;
        private DevExpress.XtraEditors.TextEdit tfFreight;
        private DevExpress.XtraEditors.TextEdit tfTruck;
        private DevExpress.XtraEditors.CalcEdit tfTotal;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validator;
    }
}
