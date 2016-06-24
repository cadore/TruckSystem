using System;
namespace TruckSystem.UI.Freights
{
    partial class FreightForm
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
            DevExpress.XtraEditors.LabelControl labelControl12;
            DevExpress.XtraEditors.LabelControl labelControl16;
            DevExpress.XtraEditors.LabelControl labelControl15;
            DevExpress.XtraEditors.LabelControl labelControl14;
            DevExpress.XtraEditors.LabelControl labelControl13;
            DevExpress.XtraEditors.LabelControl labelControl11;
            DevExpress.XtraEditors.LabelControl labelControl10;
            DevExpress.XtraEditors.LabelControl labelControl9;
            DevExpress.XtraEditors.LabelControl labelControl8;
            DevExpress.XtraEditors.LabelControl labelControl7;
            DevExpress.XtraEditors.LabelControl labelControl6;
            DevExpress.XtraEditors.LabelControl labelControl5;
            DevExpress.XtraEditors.LabelControl labelControl4;
            DevExpress.XtraEditors.LabelControl labelControl3;
            DevExpress.XtraEditors.LabelControl labelControl2;
            DevExpress.XtraEditors.LabelControl labelControl1;
            DevExpress.XtraEditors.LabelControl number_cteLabel;
            DevExpress.XtraEditors.LabelControl number_noteLabel;
            DevExpress.XtraEditors.LabelControl driver_idLabel;
            DevExpress.XtraEditors.LabelControl idLabel;
            DevExpress.XtraEditors.LabelControl labelControl17;
            DevExpress.XtraEditors.LabelControl labelControl18;
            DevExpress.XtraEditors.LabelControl labelControl19;
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule6 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule7 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule8 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule9 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule10 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule11 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule12 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FreightForm));
            this.validator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.tfPercentComission = new DevExpress.XtraEditors.TextEdit();
            this.bdgFreight = new System.Windows.Forms.BindingSource(this.components);
            this.tfValueTon = new DevExpress.XtraEditors.CalcEdit();
            this.tfWeight = new DevExpress.XtraEditors.TextEdit();
            this.tfProduct = new DevExpress.XtraEditors.TextEdit();
            this.tfEnd = new DevExpress.XtraEditors.DateEdit();
            this.tfStart = new DevExpress.XtraEditors.DateEdit();
            this.cbCompanyDestination = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdgCompanyDestination = new System.Windows.Forms.BindingSource(this.components);
            this.company_destinationSearchLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbCompanySource = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdgCompanySource = new System.Windows.Forms.BindingSource(this.components);
            this.company_sourceSearchLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcorporate_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfantasy_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldocument = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tfNumberNote = new DevExpress.XtraEditors.TextEdit();
            this.cbDriver = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdgDrivers = new System.Windows.Forms.BindingSource(this.components);
            this.driver_idSearchLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfull_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcpf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbTruck = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdgTrucks = new System.Windows.Forms.BindingSource(this.components);
            this.truck_idSearchLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colboard = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbCarrier = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdgCarrier = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnDeposits = new DevExpress.XtraEditors.SimpleButton();
            this.btnStay = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.tfObservations = new DevExpress.XtraEditors.MemoEdit();
            this.lbTrailers = new DevExpress.XtraEditors.LabelControl();
            this.btnFueled = new DevExpress.XtraEditors.SimpleButton();
            this.btnOutputs = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.tfValueComission = new DevExpress.XtraEditors.CalcEdit();
            this.tfExtraComission = new DevExpress.XtraEditors.CalcEdit();
            this.tfDiscountComission = new DevExpress.XtraEditors.CalcEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tfDeposits = new DevExpress.XtraEditors.TextEdit();
            this.tfOutputs = new DevExpress.XtraEditors.TextEdit();
            this.tfStay = new DevExpress.XtraEditors.TextEdit();
            this.tfFueled = new DevExpress.XtraEditors.TextEdit();
            this.tfGross = new DevExpress.XtraEditors.TextEdit();
            this.tfLiquidFreight = new DevExpress.XtraEditors.TextEdit();
            this.tfNumberCte = new DevExpress.XtraEditors.TextEdit();
            this.tfId = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnUpdateData = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new WCButtons.Black.ButtonSaveBlack();
            this.btnCancel = new WCButtons.Black.ButtonCancelBlack();
            labelControl12 = new DevExpress.XtraEditors.LabelControl();
            labelControl16 = new DevExpress.XtraEditors.LabelControl();
            labelControl15 = new DevExpress.XtraEditors.LabelControl();
            labelControl14 = new DevExpress.XtraEditors.LabelControl();
            labelControl13 = new DevExpress.XtraEditors.LabelControl();
            labelControl11 = new DevExpress.XtraEditors.LabelControl();
            labelControl10 = new DevExpress.XtraEditors.LabelControl();
            labelControl9 = new DevExpress.XtraEditors.LabelControl();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            number_cteLabel = new DevExpress.XtraEditors.LabelControl();
            number_noteLabel = new DevExpress.XtraEditors.LabelControl();
            driver_idLabel = new DevExpress.XtraEditors.LabelControl();
            idLabel = new DevExpress.XtraEditors.LabelControl();
            labelControl17 = new DevExpress.XtraEditors.LabelControl();
            labelControl18 = new DevExpress.XtraEditors.LabelControl();
            labelControl19 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfPercentComission.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgFreight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValueTon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfWeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCompanyDestination.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCompanyDestination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.company_destinationSearchLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCompanySource.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCompanySource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.company_sourceSearchLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfNumberNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDriver.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driver_idSearchLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTruck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgTrucks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truck_idSearchLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCarrier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCarrier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfObservations.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfValueComission.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfExtraComission.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDiscountComission.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfDeposits.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfOutputs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfStay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfFueled.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfGross.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfLiquidFreight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfNumberCte.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl12
            // 
            labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelControl12.Appearance.ForeColor = System.Drawing.Color.Green;
            labelControl12.Location = new System.Drawing.Point(490, 254);
            labelControl12.Name = "labelControl12";
            labelControl12.Size = new System.Drawing.Size(121, 19);
            labelControl12.TabIndex = 36;
            labelControl12.Text = "Liquido do Frete:";
            // 
            // labelControl16
            // 
            labelControl16.Location = new System.Drawing.Point(215, 80);
            labelControl16.Name = "labelControl16";
            labelControl16.Size = new System.Drawing.Size(49, 13);
            labelControl16.TabIndex = 43;
            labelControl16.Text = "Comissão:";
            // 
            // labelControl15
            // 
            labelControl15.Location = new System.Drawing.Point(212, 54);
            labelControl15.Name = "labelControl15";
            labelControl15.Size = new System.Drawing.Size(52, 13);
            labelControl15.TabIndex = 42;
            labelControl15.Text = "Acrécimos:";
            // 
            // labelControl14
            // 
            labelControl14.Location = new System.Drawing.Point(10, 54);
            labelControl14.Name = "labelControl14";
            labelControl14.Size = new System.Drawing.Size(49, 13);
            labelControl14.TabIndex = 37;
            labelControl14.Text = "Desconto:";
            // 
            // labelControl13
            // 
            labelControl13.Location = new System.Drawing.Point(10, 28);
            labelControl13.Name = "labelControl13";
            labelControl13.Size = new System.Drawing.Size(15, 13);
            labelControl13.TabIndex = 38;
            labelControl13.Text = "%:";
            // 
            // labelControl11
            // 
            labelControl11.Location = new System.Drawing.Point(215, 80);
            labelControl11.Name = "labelControl11";
            labelControl11.Size = new System.Drawing.Size(50, 13);
            labelControl11.TabIndex = 34;
            labelControl11.Text = "Despesas:";
            // 
            // labelControl10
            // 
            labelControl10.Location = new System.Drawing.Point(190, 106);
            labelControl10.Name = "labelControl10";
            labelControl10.Size = new System.Drawing.Size(75, 13);
            labelControl10.TabIndex = 32;
            labelControl10.Text = "Abastecimento:";
            // 
            // labelControl9
            // 
            labelControl9.Appearance.ForeColor = System.Drawing.Color.Blue;
            labelControl9.Location = new System.Drawing.Point(28, 53);
            labelControl9.Name = "labelControl9";
            labelControl9.Size = new System.Drawing.Size(30, 13);
            labelControl9.TabIndex = 30;
            labelControl9.Text = "Bruto:";
            // 
            // labelControl8
            // 
            labelControl8.Location = new System.Drawing.Point(199, 27);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new System.Drawing.Size(66, 13);
            labelControl8.TabIndex = 28;
            labelControl8.Text = "Valor p/ Ton.:";
            // 
            // labelControl7
            // 
            labelControl7.Location = new System.Drawing.Point(31, 27);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new System.Drawing.Size(27, 13);
            labelControl7.TabIndex = 26;
            labelControl7.Text = "Peso:";
            // 
            // labelControl6
            // 
            labelControl6.Location = new System.Drawing.Point(405, 90);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new System.Drawing.Size(42, 13);
            labelControl6.TabIndex = 23;
            labelControl6.Text = "Produto:";
            // 
            // labelControl5
            // 
            labelControl5.Location = new System.Drawing.Point(564, 38);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(20, 13);
            labelControl5.TabIndex = 21;
            labelControl5.Text = "Fim:";
            // 
            // labelControl4
            // 
            labelControl4.Location = new System.Drawing.Point(405, 38);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(29, 13);
            labelControl4.TabIndex = 20;
            labelControl4.Text = "Inicio:";
            // 
            // labelControl3
            // 
            labelControl3.Location = new System.Drawing.Point(405, 64);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(40, 13);
            labelControl3.TabIndex = 17;
            labelControl3.Text = "Destino:";
            // 
            // labelControl2
            // 
            labelControl2.Location = new System.Drawing.Point(5, 64);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(38, 13);
            labelControl2.TabIndex = 16;
            labelControl2.Text = "Origem:";
            // 
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(5, 12);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(51, 13);
            labelControl1.TabIndex = 14;
            labelControl1.Text = "Caminhão:";
            // 
            // number_cteLabel
            // 
            number_cteLabel.Location = new System.Drawing.Point(185, 38);
            number_cteLabel.Name = "number_cteLabel";
            number_cteLabel.Size = new System.Drawing.Size(67, 13);
            number_cteLabel.TabIndex = 12;
            number_cteLabel.Text = "Numero CT-e:";
            // 
            // number_noteLabel
            // 
            number_noteLabel.Location = new System.Drawing.Point(5, 38);
            number_noteLabel.Name = "number_noteLabel";
            number_noteLabel.Size = new System.Drawing.Size(67, 13);
            number_noteLabel.TabIndex = 10;
            number_noteLabel.Text = "Numero Nota:";
            // 
            // driver_idLabel
            // 
            driver_idLabel.Location = new System.Drawing.Point(405, 12);
            driver_idLabel.Name = "driver_idLabel";
            driver_idLabel.Size = new System.Drawing.Size(49, 13);
            driver_idLabel.TabIndex = 4;
            driver_idLabel.Text = "Motorista:";
            // 
            // idLabel
            // 
            idLabel.Location = new System.Drawing.Point(704, 12);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(27, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "Cod.:";
            // 
            // labelControl17
            // 
            labelControl17.Location = new System.Drawing.Point(3, 90);
            labelControl17.Name = "labelControl17";
            labelControl17.Size = new System.Drawing.Size(73, 13);
            labelControl17.TabIndex = 16;
            labelControl17.Text = "Transportador:";
            // 
            // labelControl18
            // 
            labelControl18.Location = new System.Drawing.Point(19, 80);
            labelControl18.Name = "labelControl18";
            labelControl18.Size = new System.Drawing.Size(39, 13);
            labelControl18.TabIndex = 32;
            labelControl18.Text = "Estádia:";
            // 
            // labelControl19
            // 
            labelControl19.Location = new System.Drawing.Point(214, 53);
            labelControl19.Name = "labelControl19";
            labelControl19.Size = new System.Drawing.Size(51, 13);
            labelControl19.TabIndex = 34;
            labelControl19.Text = "Depósitos:";
            // 
            // tfPercentComission
            // 
            this.tfPercentComission.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgFreight, "taxe_comission", true));
            this.tfPercentComission.Location = new System.Drawing.Point(65, 25);
            this.tfPercentComission.Name = "tfPercentComission";
            this.tfPercentComission.Properties.Mask.EditMask = "n2";
            this.tfPercentComission.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tfPercentComission.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfPercentComission.Size = new System.Drawing.Size(100, 20);
            this.tfPercentComission.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule1.ErrorText = "Informe a porcentagem de comissão";
            conditionValidationRule1.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.validator.SetValidationRule(this.tfPercentComission, conditionValidationRule1);
            this.tfPercentComission.EditValueChanged += new System.EventHandler(this.calcValues);
            // 
            // bdgFreight
            // 
            this.bdgFreight.DataSource = typeof(TruckSystem.freight);
            // 
            // tfValueTon
            // 
            this.tfValueTon.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgFreight, "value_ton", true));
            this.tfValueTon.Location = new System.Drawing.Point(271, 24);
            this.tfValueTon.Name = "tfValueTon";
            this.tfValueTon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfValueTon.Properties.Mask.EditMask = "c2";
            this.tfValueTon.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfValueTon.Size = new System.Drawing.Size(107, 20);
            this.tfValueTon.TabIndex = 1;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule2.ErrorText = "Informe o valor por tonelada";
            conditionValidationRule2.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.validator.SetValidationRule(this.tfValueTon, conditionValidationRule2);
            this.tfValueTon.EditValueChanged += new System.EventHandler(this.calcValues);
            // 
            // tfWeight
            // 
            this.tfWeight.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgFreight, "weight", true));
            this.tfWeight.Location = new System.Drawing.Point(64, 24);
            this.tfWeight.Name = "tfWeight";
            this.tfWeight.Properties.Mask.EditMask = "n2";
            this.tfWeight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tfWeight.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfWeight.Size = new System.Drawing.Size(107, 20);
            this.tfWeight.TabIndex = 0;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule3.ErrorText = "Informe o peso da mercadoria";
            conditionValidationRule3.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.validator.SetValidationRule(this.tfWeight, conditionValidationRule3);
            this.tfWeight.EditValueChanged += new System.EventHandler(this.calcValues);
            // 
            // tfProduct
            // 
            this.tfProduct.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgFreight, "product", true));
            this.tfProduct.Location = new System.Drawing.Point(458, 87);
            this.tfProduct.Name = "tfProduct";
            this.tfProduct.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfProduct.Size = new System.Drawing.Size(338, 20);
            this.tfProduct.TabIndex = 9;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Informe o produto";
            this.validator.SetValidationRule(this.tfProduct, conditionValidationRule4);
            // 
            // tfEnd
            // 
            this.tfEnd.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgFreight, "end", true));
            this.tfEnd.EditValue = null;
            this.tfEnd.Location = new System.Drawing.Point(590, 35);
            this.tfEnd.Name = "tfEnd";
            this.tfEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfEnd.Size = new System.Drawing.Size(108, 20);
            this.tfEnd.TabIndex = 5;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "Informe a data de término";
            this.validator.SetValidationRule(this.tfEnd, conditionValidationRule5);
            // 
            // tfStart
            // 
            this.tfStart.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgFreight, "start", true));
            this.tfStart.EditValue = null;
            this.tfStart.Location = new System.Drawing.Point(458, 35);
            this.tfStart.Name = "tfStart";
            this.tfStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfStart.Size = new System.Drawing.Size(100, 20);
            this.tfStart.TabIndex = 4;
            conditionValidationRule6.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule6.ErrorText = "Informe o início";
            this.validator.SetValidationRule(this.tfStart, conditionValidationRule6);
            this.tfStart.EditValueChanged += new System.EventHandler(this.tfStart_EditValueChanged);
            // 
            // cbCompanyDestination
            // 
            this.cbCompanyDestination.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgFreight, "company_destination", true));
            this.cbCompanyDestination.Location = new System.Drawing.Point(458, 61);
            this.cbCompanyDestination.Name = "cbCompanyDestination";
            this.cbCompanyDestination.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCompanyDestination.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cbCompanyDestination.Properties.DataSource = this.bdgCompanyDestination;
            this.cbCompanyDestination.Properties.DisplayMember = "corporate_name";
            this.cbCompanyDestination.Properties.NullText = "";
            this.cbCompanyDestination.Properties.ValueMember = "id";
            this.cbCompanyDestination.Properties.View = this.company_destinationSearchLookUpEditView;
            this.cbCompanyDestination.Size = new System.Drawing.Size(338, 20);
            this.cbCompanyDestination.TabIndex = 7;
            conditionValidationRule7.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule7.ErrorText = "Informe o destino da mercadoria";
            conditionValidationRule7.Value1 = ((long)(0));
            this.validator.SetValidationRule(this.cbCompanyDestination, conditionValidationRule7);
            // 
            // bdgCompanyDestination
            // 
            this.bdgCompanyDestination.DataSource = typeof(TruckSystem.customer);
            // 
            // company_destinationSearchLookUpEditView
            // 
            this.company_destinationSearchLookUpEditView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.company_destinationSearchLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.company_destinationSearchLookUpEditView.Name = "company_destinationSearchLookUpEditView";
            this.company_destinationSearchLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.company_destinationSearchLookUpEditView.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Cod.";
            this.gridColumn3.FieldName = "id";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 117;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Razão Social";
            this.gridColumn4.FieldName = "corporate_name";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 341;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Nome Fantasia";
            this.gridColumn5.FieldName = "fantasy_name";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 343;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "CNPJ/CPF";
            this.gridColumn6.FieldName = "document";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 277;
            // 
            // cbCompanySource
            // 
            this.cbCompanySource.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgFreight, "company_source", true));
            this.cbCompanySource.Location = new System.Drawing.Point(79, 61);
            this.cbCompanySource.Name = "cbCompanySource";
            this.cbCompanySource.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCompanySource.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cbCompanySource.Properties.DataSource = this.bdgCompanySource;
            this.cbCompanySource.Properties.DisplayMember = "corporate_name";
            this.cbCompanySource.Properties.NullText = "";
            this.cbCompanySource.Properties.ValueMember = "id";
            this.cbCompanySource.Properties.View = this.company_sourceSearchLookUpEditView;
            this.cbCompanySource.Size = new System.Drawing.Size(319, 20);
            this.cbCompanySource.TabIndex = 6;
            conditionValidationRule8.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule8.ErrorText = "Informe a origem da mercadoria";
            conditionValidationRule8.Value1 = ((long)(0));
            this.validator.SetValidationRule(this.cbCompanySource, conditionValidationRule8);
            // 
            // bdgCompanySource
            // 
            this.bdgCompanySource.DataSource = typeof(TruckSystem.customer);
            // 
            // company_sourceSearchLookUpEditView
            // 
            this.company_sourceSearchLookUpEditView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.colcorporate_name,
            this.colfantasy_name,
            this.coldocument});
            this.company_sourceSearchLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.company_sourceSearchLookUpEditView.Name = "company_sourceSearchLookUpEditView";
            this.company_sourceSearchLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.company_sourceSearchLookUpEditView.OptionsView.ShowGroupPanel = false;
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
            // tfNumberNote
            // 
            this.tfNumberNote.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgFreight, "number_note", true));
            this.tfNumberNote.Location = new System.Drawing.Point(79, 35);
            this.tfNumberNote.Name = "tfNumberNote";
            this.tfNumberNote.Properties.Mask.EditMask = "d";
            this.tfNumberNote.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tfNumberNote.Size = new System.Drawing.Size(97, 20);
            this.tfNumberNote.TabIndex = 2;
            conditionValidationRule9.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule9.ErrorText = "Informe o numero da nota";
            conditionValidationRule9.Value1 = 0;
            this.validator.SetValidationRule(this.tfNumberNote, conditionValidationRule9);
            // 
            // cbDriver
            // 
            this.cbDriver.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgFreight, "driver_id", true));
            this.cbDriver.Location = new System.Drawing.Point(458, 9);
            this.cbDriver.Name = "cbDriver";
            this.cbDriver.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDriver.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cbDriver.Properties.DataSource = this.bdgDrivers;
            this.cbDriver.Properties.DisplayMember = "full_name";
            this.cbDriver.Properties.NullText = "";
            this.cbDriver.Properties.ValueMember = "id";
            this.cbDriver.Properties.View = this.driver_idSearchLookUpEditView;
            this.cbDriver.Size = new System.Drawing.Size(240, 20);
            this.cbDriver.TabIndex = 1;
            conditionValidationRule10.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule10.ErrorText = "Informe o motorista";
            conditionValidationRule10.Value1 = ((long)(0));
            this.validator.SetValidationRule(this.cbDriver, conditionValidationRule10);
            this.cbDriver.EditValueChanged += new System.EventHandler(this.cbDriver_EditValueChanged);
            // 
            // bdgDrivers
            // 
            this.bdgDrivers.DataSource = typeof(TruckSystem.driver);
            // 
            // driver_idSearchLookUpEditView
            // 
            this.driver_idSearchLookUpEditView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colfull_name,
            this.colcpf});
            this.driver_idSearchLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.driver_idSearchLookUpEditView.Name = "driver_idSearchLookUpEditView";
            this.driver_idSearchLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.driver_idSearchLookUpEditView.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Cod.";
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 137;
            // 
            // colfull_name
            // 
            this.colfull_name.Caption = "Nome Completo";
            this.colfull_name.FieldName = "full_name";
            this.colfull_name.Name = "colfull_name";
            this.colfull_name.Visible = true;
            this.colfull_name.VisibleIndex = 1;
            this.colfull_name.Width = 618;
            // 
            // colcpf
            // 
            this.colcpf.Caption = "CPF";
            this.colcpf.FieldName = "cpf";
            this.colcpf.Name = "colcpf";
            this.colcpf.Visible = true;
            this.colcpf.VisibleIndex = 2;
            this.colcpf.Width = 323;
            // 
            // cbTruck
            // 
            this.cbTruck.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgFreight, "truck_id", true));
            this.cbTruck.Location = new System.Drawing.Point(79, 9);
            this.cbTruck.Name = "cbTruck";
            this.cbTruck.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTruck.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cbTruck.Properties.CloseUpKey = new DevExpress.Utils.KeyShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
                | System.Windows.Forms.Keys.Z));
            this.cbTruck.Properties.DataSource = this.bdgTrucks;
            this.cbTruck.Properties.DisplayMember = "board";
            this.cbTruck.Properties.NullText = "";
            this.cbTruck.Properties.ValueMember = "id";
            this.cbTruck.Properties.View = this.truck_idSearchLookUpEditView;
            this.cbTruck.Size = new System.Drawing.Size(97, 20);
            this.cbTruck.TabIndex = 0;
            conditionValidationRule11.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule11.ErrorText = "Informe o Caminhão";
            conditionValidationRule11.Value1 = ((long)(0));
            this.validator.SetValidationRule(this.cbTruck, conditionValidationRule11);
            this.cbTruck.EditValueChanged += new System.EventHandler(this.cbTruck_EditValueChanged);
            // 
            // bdgTrucks
            // 
            this.bdgTrucks.DataSource = typeof(TruckSystem.truck);
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
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 179;
            // 
            // colboard
            // 
            this.colboard.Caption = "Placa";
            this.colboard.FieldName = "board";
            this.colboard.Name = "colboard";
            this.colboard.Visible = true;
            this.colboard.VisibleIndex = 1;
            this.colboard.Width = 899;
            // 
            // cbCarrier
            // 
            this.cbCarrier.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgFreight, "carrier", true));
            this.cbCarrier.Location = new System.Drawing.Point(79, 87);
            this.cbCarrier.Name = "cbCarrier";
            this.cbCarrier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCarrier.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cbCarrier.Properties.DataSource = this.bdgCarrier;
            this.cbCarrier.Properties.DisplayMember = "corporate_name";
            this.cbCarrier.Properties.NullText = "";
            this.cbCarrier.Properties.ValueMember = "id";
            this.cbCarrier.Properties.View = this.gridView1;
            this.cbCarrier.Size = new System.Drawing.Size(319, 20);
            this.cbCarrier.TabIndex = 8;
            conditionValidationRule12.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule12.ErrorText = "Informe o Transportador";
            conditionValidationRule12.Value1 = ((long)(0));
            this.validator.SetValidationRule(this.cbCarrier, conditionValidationRule12);
            // 
            // bdgCarrier
            // 
            this.bdgCarrier.DataSource = typeof(TruckSystem.customer);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Cod.";
            this.gridColumn7.FieldName = "id";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            this.gridColumn7.Width = 117;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Razão Social";
            this.gridColumn8.FieldName = "corporate_name";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            this.gridColumn8.Width = 341;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Nome Fantasia";
            this.gridColumn9.FieldName = "fantasy_name";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 2;
            this.gridColumn9.Width = 343;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "CNPJ/CPF";
            this.gridColumn10.FieldName = "document";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 3;
            this.gridColumn10.Width = 277;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnDeposits);
            this.panelControl2.Controls.Add(this.btnStay);
            this.panelControl2.Controls.Add(this.groupControl3);
            this.panelControl2.Controls.Add(this.lbTrailers);
            this.panelControl2.Controls.Add(this.btnFueled);
            this.panelControl2.Controls.Add(this.btnOutputs);
            this.panelControl2.Controls.Add(labelControl12);
            this.panelControl2.Controls.Add(this.groupControl2);
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Controls.Add(labelControl6);
            this.panelControl2.Controls.Add(this.tfLiquidFreight);
            this.panelControl2.Controls.Add(this.tfProduct);
            this.panelControl2.Controls.Add(labelControl5);
            this.panelControl2.Controls.Add(labelControl4);
            this.panelControl2.Controls.Add(this.tfEnd);
            this.panelControl2.Controls.Add(this.tfStart);
            this.panelControl2.Controls.Add(labelControl3);
            this.panelControl2.Controls.Add(this.cbCompanyDestination);
            this.panelControl2.Controls.Add(this.cbCarrier);
            this.panelControl2.Controls.Add(this.cbCompanySource);
            this.panelControl2.Controls.Add(labelControl17);
            this.panelControl2.Controls.Add(labelControl2);
            this.panelControl2.Controls.Add(labelControl1);
            this.panelControl2.Controls.Add(number_cteLabel);
            this.panelControl2.Controls.Add(this.tfNumberCte);
            this.panelControl2.Controls.Add(number_noteLabel);
            this.panelControl2.Controls.Add(this.tfNumberNote);
            this.panelControl2.Controls.Add(driver_idLabel);
            this.panelControl2.Controls.Add(this.cbDriver);
            this.panelControl2.Controls.Add(this.cbTruck);
            this.panelControl2.Controls.Add(idLabel);
            this.panelControl2.Controls.Add(this.tfId);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(800, 396);
            this.panelControl2.TabIndex = 0;
            // 
            // btnDeposits
            // 
            this.btnDeposits.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnDeposits.Appearance.Options.UseFont = true;
            this.btnDeposits.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnDeposits.Location = new System.Drawing.Point(237, 253);
            this.btnDeposits.Name = "btnDeposits";
            this.btnDeposits.Size = new System.Drawing.Size(110, 23);
            this.btnDeposits.TabIndex = 40;
            this.btnDeposits.Text = "Depósitos";
            this.btnDeposits.Click += new System.EventHandler(this.btnDeposits_Click);
            // 
            // btnStay
            // 
            this.btnStay.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStay.Appearance.Options.UseFont = true;
            this.btnStay.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnStay.Location = new System.Drawing.Point(353, 253);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(110, 23);
            this.btnStay.TabIndex = 14;
            this.btnStay.Text = "Estadia";
            this.btnStay.Visible = false;
            this.btnStay.Click += new System.EventHandler(this.btnStay_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.tfObservations);
            this.groupControl3.Location = new System.Drawing.Point(5, 281);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(790, 108);
            this.groupControl3.TabIndex = 15;
            this.groupControl3.Text = "Observações";
            // 
            // tfObservations
            // 
            this.tfObservations.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgFreight, "observations", true));
            this.tfObservations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tfObservations.EditValue = "";
            this.tfObservations.Location = new System.Drawing.Point(2, 21);
            this.tfObservations.Name = "tfObservations";
            this.tfObservations.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfObservations.Size = new System.Drawing.Size(786, 85);
            this.tfObservations.TabIndex = 0;
            this.tfObservations.UseOptimizedRendering = true;
            // 
            // lbTrailers
            // 
            this.lbTrailers.Location = new System.Drawing.Point(182, 12);
            this.lbTrailers.Name = "lbTrailers";
            this.lbTrailers.Size = new System.Drawing.Size(52, 13);
            this.lbTrailers.TabIndex = 39;
            this.lbTrailers.Text = "Reboques:";
            // 
            // btnFueled
            // 
            this.btnFueled.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFueled.Appearance.Options.UseFont = true;
            this.btnFueled.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnFueled.Location = new System.Drawing.Point(121, 253);
            this.btnFueled.Name = "btnFueled";
            this.btnFueled.Size = new System.Drawing.Size(110, 23);
            this.btnFueled.TabIndex = 13;
            this.btnFueled.Text = "Abastecimento";
            this.btnFueled.Click += new System.EventHandler(this.btnFueled_Click);
            // 
            // btnOutputs
            // 
            this.btnOutputs.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutputs.Appearance.Options.UseFont = true;
            this.btnOutputs.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnOutputs.Location = new System.Drawing.Point(5, 253);
            this.btnOutputs.Name = "btnOutputs";
            this.btnOutputs.Size = new System.Drawing.Size(110, 23);
            this.btnOutputs.TabIndex = 12;
            this.btnOutputs.Text = "Despesas";
            this.btnOutputs.Click += new System.EventHandler(this.btnOutputs_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(labelControl16);
            this.groupControl2.Controls.Add(labelControl15);
            this.groupControl2.Controls.Add(labelControl14);
            this.groupControl2.Controls.Add(this.tfValueComission);
            this.groupControl2.Controls.Add(this.tfExtraComission);
            this.groupControl2.Controls.Add(this.tfDiscountComission);
            this.groupControl2.Controls.Add(labelControl13);
            this.groupControl2.Controls.Add(this.tfPercentComission);
            this.groupControl2.Location = new System.Drawing.Point(403, 113);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(393, 134);
            this.groupControl2.TabIndex = 11;
            this.groupControl2.Text = "Comissão do Motorista";
            // 
            // tfValueComission
            // 
            this.tfValueComission.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgFreight, "value_comission", true));
            this.tfValueComission.Location = new System.Drawing.Point(270, 77);
            this.tfValueComission.Name = "tfValueComission";
            this.tfValueComission.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfValueComission.Properties.Mask.EditMask = "c2";
            this.tfValueComission.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfValueComission.Properties.ReadOnly = true;
            this.tfValueComission.Size = new System.Drawing.Size(100, 20);
            this.tfValueComission.TabIndex = 41;
            this.tfValueComission.TabStop = false;
            // 
            // tfExtraComission
            // 
            this.tfExtraComission.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgFreight, "extra_comission", true));
            this.tfExtraComission.Location = new System.Drawing.Point(270, 51);
            this.tfExtraComission.Name = "tfExtraComission";
            this.tfExtraComission.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfExtraComission.Properties.Mask.EditMask = "c2";
            this.tfExtraComission.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfExtraComission.Size = new System.Drawing.Size(100, 20);
            this.tfExtraComission.TabIndex = 2;
            this.tfExtraComission.EditValueChanged += new System.EventHandler(this.calcValues);
            // 
            // tfDiscountComission
            // 
            this.tfDiscountComission.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgFreight, "discounts_comission", true));
            this.tfDiscountComission.Location = new System.Drawing.Point(65, 51);
            this.tfDiscountComission.Name = "tfDiscountComission";
            this.tfDiscountComission.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfDiscountComission.Properties.Mask.EditMask = "c2";
            this.tfDiscountComission.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfDiscountComission.Size = new System.Drawing.Size(100, 20);
            this.tfDiscountComission.TabIndex = 1;
            this.tfDiscountComission.EditValueChanged += new System.EventHandler(this.calcValues);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tfDeposits);
            this.groupControl1.Controls.Add(labelControl19);
            this.groupControl1.Controls.Add(labelControl11);
            this.groupControl1.Controls.Add(this.tfOutputs);
            this.groupControl1.Controls.Add(labelControl18);
            this.groupControl1.Controls.Add(labelControl10);
            this.groupControl1.Controls.Add(this.tfStay);
            this.groupControl1.Controls.Add(this.tfFueled);
            this.groupControl1.Controls.Add(labelControl9);
            this.groupControl1.Controls.Add(this.tfValueTon);
            this.groupControl1.Controls.Add(labelControl8);
            this.groupControl1.Controls.Add(this.tfGross);
            this.groupControl1.Controls.Add(this.tfWeight);
            this.groupControl1.Controls.Add(labelControl7);
            this.groupControl1.Location = new System.Drawing.Point(5, 113);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(392, 134);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Peso e Valores";
            // 
            // tfDeposits
            // 
            this.tfDeposits.Location = new System.Drawing.Point(271, 50);
            this.tfDeposits.Name = "tfDeposits";
            this.tfDeposits.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfDeposits.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfDeposits.Properties.ReadOnly = true;
            this.tfDeposits.Size = new System.Drawing.Size(107, 20);
            this.tfDeposits.TabIndex = 35;
            // 
            // tfOutputs
            // 
            this.tfOutputs.Location = new System.Drawing.Point(271, 77);
            this.tfOutputs.Name = "tfOutputs";
            this.tfOutputs.Properties.Mask.EditMask = "c2";
            this.tfOutputs.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tfOutputs.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfOutputs.Properties.ReadOnly = true;
            this.tfOutputs.Size = new System.Drawing.Size(107, 20);
            this.tfOutputs.TabIndex = 33;
            this.tfOutputs.TabStop = false;
            // 
            // tfStay
            // 
            this.tfStay.Location = new System.Drawing.Point(64, 77);
            this.tfStay.Name = "tfStay";
            this.tfStay.Properties.Mask.EditMask = "c2";
            this.tfStay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tfStay.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfStay.Properties.ReadOnly = true;
            this.tfStay.Size = new System.Drawing.Size(107, 20);
            this.tfStay.TabIndex = 31;
            this.tfStay.TabStop = false;
            // 
            // tfFueled
            // 
            this.tfFueled.Location = new System.Drawing.Point(271, 103);
            this.tfFueled.Name = "tfFueled";
            this.tfFueled.Properties.Mask.EditMask = "c2";
            this.tfFueled.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tfFueled.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfFueled.Properties.ReadOnly = true;
            this.tfFueled.Size = new System.Drawing.Size(107, 20);
            this.tfFueled.TabIndex = 31;
            this.tfFueled.TabStop = false;
            // 
            // tfGross
            // 
            this.tfGross.Location = new System.Drawing.Point(64, 50);
            this.tfGross.Name = "tfGross";
            this.tfGross.Properties.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.tfGross.Properties.Appearance.Options.UseForeColor = true;
            this.tfGross.Properties.Mask.EditMask = "c2";
            this.tfGross.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tfGross.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfGross.Properties.ReadOnly = true;
            this.tfGross.Size = new System.Drawing.Size(107, 20);
            this.tfGross.TabIndex = 2;
            this.tfGross.Enter += new System.EventHandler(this.tfGross_Enter);
            this.tfGross.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tfGross_KeyDown);
            // 
            // tfLiquidFreight
            // 
            this.tfLiquidFreight.Location = new System.Drawing.Point(617, 251);
            this.tfLiquidFreight.Name = "tfLiquidFreight";
            this.tfLiquidFreight.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfLiquidFreight.Properties.Appearance.ForeColor = System.Drawing.Color.Green;
            this.tfLiquidFreight.Properties.Appearance.Options.UseFont = true;
            this.tfLiquidFreight.Properties.Appearance.Options.UseForeColor = true;
            this.tfLiquidFreight.Properties.Mask.EditMask = "c2";
            this.tfLiquidFreight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tfLiquidFreight.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfLiquidFreight.Properties.ReadOnly = true;
            this.tfLiquidFreight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tfLiquidFreight.Size = new System.Drawing.Size(178, 26);
            this.tfLiquidFreight.TabIndex = 35;
            this.tfLiquidFreight.TabStop = false;
            // 
            // tfNumberCte
            // 
            this.tfNumberCte.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgFreight, "number_cte", true));
            this.tfNumberCte.Location = new System.Drawing.Point(260, 35);
            this.tfNumberCte.Name = "tfNumberCte";
            this.tfNumberCte.Size = new System.Drawing.Size(137, 20);
            this.tfNumberCte.TabIndex = 3;
            // 
            // tfId
            // 
            this.tfId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgFreight, "id", true));
            this.tfId.Location = new System.Drawing.Point(740, 9);
            this.tfId.Name = "tfId";
            this.tfId.Properties.ReadOnly = true;
            this.tfId.Size = new System.Drawing.Size(56, 20);
            this.tfId.TabIndex = 1;
            this.tfId.TabStop = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnUpdateData);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 396);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 46);
            this.panelControl1.TabIndex = 1;
            // 
            // btnUpdateData
            // 
            this.btnUpdateData.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnUpdateData.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateData.Image")));
            this.btnUpdateData.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnUpdateData.Location = new System.Drawing.Point(5, 6);
            this.btnUpdateData.Name = "btnUpdateData";
            this.btnUpdateData.Size = new System.Drawing.Size(33, 33);
            this.btnUpdateData.TabIndex = 2;
            this.btnUpdateData.Click += new System.EventHandler(this.btnUpdateData_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(569, 6);
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
            this.btnCancel.Location = new System.Drawing.Point(685, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 33);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FreightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FreightForm";
            this.Size = new System.Drawing.Size(800, 442);
            ((System.ComponentModel.ISupportInitialize)(this.validator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfPercentComission.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgFreight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValueTon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfWeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCompanyDestination.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCompanyDestination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.company_destinationSearchLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCompanySource.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCompanySource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.company_sourceSearchLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfNumberNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDriver.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driver_idSearchLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTruck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgTrucks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truck_idSearchLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCarrier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCarrier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tfObservations.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfValueComission.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfExtraComission.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDiscountComission.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfDeposits.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfOutputs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfStay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfFueled.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfGross.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfLiquidFreight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfNumberCte.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bdgFreight;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validator;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private WCButtons.Black.ButtonSaveBlack btnSave;
        private WCButtons.Black.ButtonCancelBlack btnCancel;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit tfId;
        private DevExpress.XtraEditors.SearchLookUpEdit cbTruck;
        private DevExpress.XtraGrid.Views.Grid.GridView truck_idSearchLookUpEditView;
        private DevExpress.XtraEditors.TextEdit tfNumberCte;
        private DevExpress.XtraEditors.TextEdit tfNumberNote;
        private DevExpress.XtraEditors.SearchLookUpEdit cbCompanyDestination;
        private DevExpress.XtraGrid.Views.Grid.GridView company_destinationSearchLookUpEditView;
        private DevExpress.XtraEditors.SearchLookUpEdit cbCompanySource;
        private DevExpress.XtraGrid.Views.Grid.GridView company_sourceSearchLookUpEditView;
        private DevExpress.XtraEditors.SearchLookUpEdit cbDriver;
        private DevExpress.XtraGrid.Views.Grid.GridView driver_idSearchLookUpEditView;
        private DevExpress.XtraEditors.DateEdit tfEnd;
        private DevExpress.XtraEditors.DateEdit tfStart;
        private DevExpress.XtraEditors.TextEdit tfProduct;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit tfWeight;
        private DevExpress.XtraEditors.CalcEdit tfValueTon;
        private DevExpress.XtraEditors.TextEdit tfGross;
        private DevExpress.XtraEditors.TextEdit tfFueled;
        private DevExpress.XtraEditors.TextEdit tfOutputs;
        private DevExpress.XtraEditors.TextEdit tfLiquidFreight;
        private DevExpress.XtraEditors.TextEdit tfPercentComission;
        private DevExpress.XtraEditors.CalcEdit tfValueComission;
        private DevExpress.XtraEditors.CalcEdit tfExtraComission;
        private DevExpress.XtraEditors.CalcEdit tfDiscountComission;
        private DevExpress.XtraEditors.SimpleButton btnFueled;
        private DevExpress.XtraEditors.SimpleButton btnOutputs;
        private System.Windows.Forms.BindingSource bdgDrivers;
        private System.Windows.Forms.BindingSource bdgCompanySource;
        private System.Windows.Forms.BindingSource bdgCompanyDestination;
        private System.Windows.Forms.BindingSource bdgTrucks;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colfull_name;
        private DevExpress.XtraGrid.Columns.GridColumn colcpf;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colboard;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colcorporate_name;
        private DevExpress.XtraGrid.Columns.GridColumn colfantasy_name;
        private DevExpress.XtraGrid.Columns.GridColumn coldocument;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.LabelControl lbTrailers;
        private DevExpress.XtraEditors.SimpleButton btnUpdateData;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.MemoEdit tfObservations;
        private DevExpress.XtraEditors.SearchLookUpEdit cbCarrier;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private System.Windows.Forms.BindingSource bdgCarrier;
        private DevExpress.XtraEditors.TextEdit tfStay;
        private DevExpress.XtraEditors.SimpleButton btnStay;
        private DevExpress.XtraEditors.SimpleButton btnDeposits;
        private DevExpress.XtraEditors.TextEdit tfDeposits;
    }
}
