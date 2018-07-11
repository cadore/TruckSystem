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
            DevExpress.XtraEditors.LabelControl labelControl14;
            DevExpress.XtraEditors.LabelControl labelControl13;
            DevExpress.XtraEditors.LabelControl labelControl11;
            DevExpress.XtraEditors.LabelControl labelControl10;
            DevExpress.XtraEditors.LabelControl labelControl9;
            DevExpress.XtraEditors.LabelControl labelControl8;
            DevExpress.XtraEditors.LabelControl labelControl7;
            DevExpress.XtraEditors.LabelControl labelControl6;
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
            DevExpress.XtraEditors.LabelControl labelControl20;
            DevExpress.XtraEditors.LabelControl labelControl21;
            DevExpress.XtraEditors.LabelControl labelControl22;
            DevExpress.XtraEditors.LabelControl labelControl23;
            DevExpress.XtraEditors.LabelControl labelControl24;
            DevExpress.XtraEditors.LabelControl labelControl27;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FreightForm));
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.validator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.tfPercentComissionGross = new DevExpress.XtraEditors.TextEdit();
            this.tfValueTon = new DevExpress.XtraEditors.CalcEdit();
            this.bdgFreight = new System.Windows.Forms.BindingSource(this.components);
            this.tfWeight = new DevExpress.XtraEditors.TextEdit();
            this.tfProduct = new DevExpress.XtraEditors.TextEdit();
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
            this.tfEnd = new DevExpress.XtraEditors.DateEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl8 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl7 = new DevExpress.XtraEditors.GroupControl();
            this.tfId = new DevExpress.XtraEditors.TextEdit();
            this.tfNumberCte = new DevExpress.XtraEditors.TextEdit();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl25 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.lbTrailers = new DevExpress.XtraEditors.LabelControl();
            this.btnDeposits = new DevExpress.XtraEditors.SimpleButton();
            this.btnStay = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.tfObservations = new DevExpress.XtraEditors.MemoEdit();
            this.btnFueled = new DevExpress.XtraEditors.SimpleButton();
            this.btnOutputs = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lbBaseComissionLiquid = new DevExpress.XtraEditors.LabelControl();
            this.lbBaseComissionGross = new DevExpress.XtraEditors.LabelControl();
            this.tfPartialComissionLiquid = new DevExpress.XtraEditors.CalcEdit();
            this.tfPartialComissionGross = new DevExpress.XtraEditors.CalcEdit();
            this.tfValueComission = new DevExpress.XtraEditors.CalcEdit();
            this.tfExtraComission = new DevExpress.XtraEditors.CalcEdit();
            this.tfDiscountComission = new DevExpress.XtraEditors.CalcEdit();
            this.tfPercentComissionLiquid = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tfDeposits = new DevExpress.XtraEditors.TextEdit();
            this.tfSubTotalFreight = new DevExpress.XtraEditors.TextEdit();
            this.tfOthersOutputs = new DevExpress.XtraEditors.TextEdit();
            this.tfOutputs = new DevExpress.XtraEditors.TextEdit();
            this.tfStay = new DevExpress.XtraEditors.TextEdit();
            this.tfFueled = new DevExpress.XtraEditors.TextEdit();
            this.tfGross = new DevExpress.XtraEditors.TextEdit();
            this.tfLiquidFreight = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdateData = new DevExpress.XtraEditors.SimpleButton();
            labelControl12 = new DevExpress.XtraEditors.LabelControl();
            labelControl16 = new DevExpress.XtraEditors.LabelControl();
            labelControl14 = new DevExpress.XtraEditors.LabelControl();
            labelControl13 = new DevExpress.XtraEditors.LabelControl();
            labelControl11 = new DevExpress.XtraEditors.LabelControl();
            labelControl10 = new DevExpress.XtraEditors.LabelControl();
            labelControl9 = new DevExpress.XtraEditors.LabelControl();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
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
            labelControl20 = new DevExpress.XtraEditors.LabelControl();
            labelControl21 = new DevExpress.XtraEditors.LabelControl();
            labelControl22 = new DevExpress.XtraEditors.LabelControl();
            labelControl23 = new DevExpress.XtraEditors.LabelControl();
            labelControl24 = new DevExpress.XtraEditors.LabelControl();
            labelControl27 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfPercentComissionGross.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValueTon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgFreight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfWeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfProduct.Properties)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.tfEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).BeginInit();
            this.groupControl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).BeginInit();
            this.groupControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfNumberCte.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfObservations.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfPartialComissionLiquid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfPartialComissionGross.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValueComission.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfExtraComission.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDiscountComission.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfPercentComissionLiquid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfDeposits.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfSubTotalFreight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfOthersOutputs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfOutputs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfStay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfFueled.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfGross.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfLiquidFreight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl12
            // 
            labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelControl12.Appearance.ForeColor = System.Drawing.Color.Green;
            labelControl12.Location = new System.Drawing.Point(517, 308);
            labelControl12.Name = "labelControl12";
            labelControl12.Size = new System.Drawing.Size(121, 19);
            labelControl12.TabIndex = 36;
            labelControl12.Text = "Liquido do Frete:";
            // 
            // labelControl16
            // 
            labelControl16.Location = new System.Drawing.Point(432, 49);
            labelControl16.Name = "labelControl16";
            labelControl16.Size = new System.Drawing.Size(49, 13);
            labelControl16.TabIndex = 43;
            labelControl16.Text = "Comissão:";
            // 
            // labelControl14
            // 
            labelControl14.Location = new System.Drawing.Point(11, 131);
            labelControl14.Name = "labelControl14";
            labelControl14.Size = new System.Drawing.Size(49, 13);
            labelControl14.TabIndex = 37;
            labelControl14.Text = "Desconto:";
            // 
            // labelControl13
            // 
            labelControl13.Location = new System.Drawing.Point(11, 49);
            labelControl13.Name = "labelControl13";
            labelControl13.Size = new System.Drawing.Size(71, 13);
            labelControl13.TabIndex = 38;
            labelControl13.Text = "% frete bruto:";
            // 
            // labelControl11
            // 
            labelControl11.Location = new System.Drawing.Point(172, 79);
            labelControl11.Name = "labelControl11";
            labelControl11.Size = new System.Drawing.Size(102, 13);
            labelControl11.TabIndex = 34;
            labelControl11.Text = "Despesas de viagem:";
            // 
            // labelControl10
            // 
            labelControl10.Location = new System.Drawing.Point(199, 54);
            labelControl10.Name = "labelControl10";
            labelControl10.Size = new System.Drawing.Size(75, 13);
            labelControl10.TabIndex = 32;
            labelControl10.Text = "Abastecimento:";
            // 
            // labelControl9
            // 
            labelControl9.Appearance.ForeColor = System.Drawing.Color.Blue;
            labelControl9.Location = new System.Drawing.Point(25, 53);
            labelControl9.Name = "labelControl9";
            labelControl9.Size = new System.Drawing.Size(30, 13);
            labelControl9.TabIndex = 30;
            labelControl9.Text = "Bruto:";
            // 
            // labelControl8
            // 
            labelControl8.Location = new System.Drawing.Point(208, 27);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new System.Drawing.Size(66, 13);
            labelControl8.TabIndex = 28;
            labelControl8.Text = "Valor p/ Ton.:";
            // 
            // labelControl7
            // 
            labelControl7.Location = new System.Drawing.Point(28, 27);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new System.Drawing.Size(27, 13);
            labelControl7.TabIndex = 26;
            labelControl7.Text = "Peso:";
            // 
            // labelControl6
            // 
            labelControl6.Location = new System.Drawing.Point(6, 57);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new System.Drawing.Size(42, 13);
            labelControl6.TabIndex = 23;
            labelControl6.Text = "Produto:";
            // 
            // labelControl4
            // 
            labelControl4.Location = new System.Drawing.Point(9, 27);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(27, 13);
            labelControl4.TabIndex = 20;
            labelControl4.Text = "Data:";
            // 
            // labelControl3
            // 
            labelControl3.Location = new System.Drawing.Point(344, 27);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(40, 13);
            labelControl3.TabIndex = 17;
            labelControl3.Text = "Destino:";
            // 
            // labelControl2
            // 
            labelControl2.Location = new System.Drawing.Point(7, 27);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(38, 13);
            labelControl2.TabIndex = 16;
            labelControl2.Text = "Origem:";
            // 
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(7, 27);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(51, 13);
            labelControl1.TabIndex = 14;
            labelControl1.Text = "Caminhão:";
            // 
            // number_cteLabel
            // 
            number_cteLabel.Location = new System.Drawing.Point(122, 27);
            number_cteLabel.Name = "number_cteLabel";
            number_cteLabel.Size = new System.Drawing.Size(27, 13);
            number_cteLabel.TabIndex = 12;
            number_cteLabel.Text = "CT-e:";
            // 
            // number_noteLabel
            // 
            number_noteLabel.Location = new System.Drawing.Point(6, 27);
            number_noteLabel.Name = "number_noteLabel";
            number_noteLabel.Size = new System.Drawing.Size(27, 13);
            number_noteLabel.TabIndex = 10;
            number_noteLabel.Text = "Nota:";
            // 
            // driver_idLabel
            // 
            driver_idLabel.Location = new System.Drawing.Point(8, 53);
            driver_idLabel.Name = "driver_idLabel";
            driver_idLabel.Size = new System.Drawing.Size(49, 13);
            driver_idLabel.TabIndex = 4;
            driver_idLabel.Text = "Motorista:";
            // 
            // idLabel
            // 
            idLabel.Location = new System.Drawing.Point(239, 27);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(27, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "Cod.:";
            // 
            // labelControl17
            // 
            labelControl17.Location = new System.Drawing.Point(677, 27);
            labelControl17.Name = "labelControl17";
            labelControl17.Size = new System.Drawing.Size(79, 13);
            labelControl17.TabIndex = 16;
            labelControl17.Text = "Transportadora:";
            // 
            // labelControl18
            // 
            labelControl18.Location = new System.Drawing.Point(16, 80);
            labelControl18.Name = "labelControl18";
            labelControl18.Size = new System.Drawing.Size(39, 13);
            labelControl18.TabIndex = 32;
            labelControl18.Text = "Estádia:";
            // 
            // labelControl19
            // 
            labelControl19.Location = new System.Drawing.Point(5, 106);
            labelControl19.Name = "labelControl19";
            labelControl19.Size = new System.Drawing.Size(51, 13);
            labelControl19.TabIndex = 34;
            labelControl19.Text = "Depósitos:";
            // 
            // labelControl20
            // 
            labelControl20.Location = new System.Drawing.Point(189, 105);
            labelControl20.Name = "labelControl20";
            labelControl20.Size = new System.Drawing.Size(85, 13);
            labelControl20.TabIndex = 34;
            labelControl20.Text = "Outras despesas:";
            // 
            // labelControl21
            // 
            labelControl21.Location = new System.Drawing.Point(11, 99);
            labelControl21.Name = "labelControl21";
            labelControl21.Size = new System.Drawing.Size(75, 13);
            labelControl21.TabIndex = 38;
            labelControl21.Text = "% frete liquido:";
            // 
            // labelControl22
            // 
            labelControl22.Location = new System.Drawing.Point(241, 49);
            labelControl22.Name = "labelControl22";
            labelControl22.Size = new System.Drawing.Size(35, 13);
            labelControl22.TabIndex = 38;
            labelControl22.Text = "Parcial:";
            // 
            // labelControl23
            // 
            labelControl23.Location = new System.Drawing.Point(241, 99);
            labelControl23.Name = "labelControl23";
            labelControl23.Size = new System.Drawing.Size(35, 13);
            labelControl23.TabIndex = 38;
            labelControl23.Text = "Parcial:";
            // 
            // labelControl24
            // 
            labelControl24.Location = new System.Drawing.Point(225, 131);
            labelControl24.Name = "labelControl24";
            labelControl24.Size = new System.Drawing.Size(49, 13);
            labelControl24.TabIndex = 34;
            labelControl24.Text = "Sub Total:";
            // 
            // labelControl27
            // 
            labelControl27.Location = new System.Drawing.Point(9, 27);
            labelControl27.Name = "labelControl27";
            labelControl27.Size = new System.Drawing.Size(27, 13);
            labelControl27.TabIndex = 20;
            labelControl27.Text = "Data:";
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(224, 131);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(52, 13);
            this.labelControl15.TabIndex = 42;
            this.labelControl15.Text = "Acrécimos:";
            // 
            // tfPercentComissionGross
            // 
            this.tfPercentComissionGross.Location = new System.Drawing.Point(92, 46);
            this.tfPercentComissionGross.Name = "tfPercentComissionGross";
            this.tfPercentComissionGross.Properties.Mask.EditMask = "n2";
            this.tfPercentComissionGross.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tfPercentComissionGross.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfPercentComissionGross.Size = new System.Drawing.Size(100, 20);
            this.tfPercentComissionGross.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule1.ErrorText = "Informe a porcentagem de comissão";
            conditionValidationRule1.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.validator.SetValidationRule(this.tfPercentComissionGross, conditionValidationRule1);
            this.tfPercentComissionGross.EditValueChanged += new System.EventHandler(this.calcValues);
            // 
            // tfValueTon
            // 
            this.tfValueTon.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgFreight, "value_ton", true));
            this.tfValueTon.Location = new System.Drawing.Point(279, 24);
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
            // bdgFreight
            // 
            this.bdgFreight.DataSource = typeof(TruckSystem.freight);
            // 
            // tfWeight
            // 
            this.tfWeight.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgFreight, "weight", true));
            this.tfWeight.Location = new System.Drawing.Point(61, 24);
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
            this.tfProduct.Location = new System.Drawing.Point(54, 54);
            this.tfProduct.Name = "tfProduct";
            this.tfProduct.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfProduct.Size = new System.Drawing.Size(256, 20);
            this.tfProduct.TabIndex = 9;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Informe o produto";
            this.validator.SetValidationRule(this.tfProduct, conditionValidationRule4);
            // 
            // tfStart
            // 
            this.tfStart.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgFreight, "start", true));
            this.tfStart.EditValue = null;
            this.tfStart.Location = new System.Drawing.Point(42, 24);
            this.tfStart.Name = "tfStart";
            this.tfStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfStart.Size = new System.Drawing.Size(108, 20);
            this.tfStart.TabIndex = 4;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "Informe o início";
            this.validator.SetValidationRule(this.tfStart, conditionValidationRule5);
            this.tfStart.EditValueChanged += new System.EventHandler(this.tfStart_EditValueChanged);
            // 
            // cbCompanyDestination
            // 
            this.cbCompanyDestination.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgFreight, "company_destination", true));
            this.cbCompanyDestination.Location = new System.Drawing.Point(390, 24);
            this.cbCompanyDestination.Name = "cbCompanyDestination";
            this.cbCompanyDestination.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCompanyDestination.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cbCompanyDestination.Properties.DataSource = this.bdgCompanyDestination;
            this.cbCompanyDestination.Properties.DisplayMember = "corporate_name";
            this.cbCompanyDestination.Properties.NullText = "";
            this.cbCompanyDestination.Properties.ValueMember = "id";
            this.cbCompanyDestination.Properties.View = this.company_destinationSearchLookUpEditView;
            this.cbCompanyDestination.Size = new System.Drawing.Size(281, 20);
            this.cbCompanyDestination.TabIndex = 7;
            conditionValidationRule6.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule6.ErrorText = "Informe o destino da mercadoria";
            conditionValidationRule6.Value1 = ((long)(0));
            this.validator.SetValidationRule(this.cbCompanyDestination, conditionValidationRule6);
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
            this.cbCompanySource.Location = new System.Drawing.Point(51, 24);
            this.cbCompanySource.Name = "cbCompanySource";
            this.cbCompanySource.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCompanySource.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cbCompanySource.Properties.DataSource = this.bdgCompanySource;
            this.cbCompanySource.Properties.DisplayMember = "corporate_name";
            this.cbCompanySource.Properties.NullText = "";
            this.cbCompanySource.Properties.ValueMember = "id";
            this.cbCompanySource.Properties.View = this.company_sourceSearchLookUpEditView;
            this.cbCompanySource.Size = new System.Drawing.Size(287, 20);
            this.cbCompanySource.TabIndex = 6;
            conditionValidationRule7.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule7.ErrorText = "Informe a origem da mercadoria";
            conditionValidationRule7.Value1 = ((long)(0));
            this.validator.SetValidationRule(this.cbCompanySource, conditionValidationRule7);
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
            this.tfNumberNote.Location = new System.Drawing.Point(38, 24);
            this.tfNumberNote.Name = "tfNumberNote";
            this.tfNumberNote.Properties.Mask.EditMask = "d";
            this.tfNumberNote.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tfNumberNote.Size = new System.Drawing.Size(79, 20);
            this.tfNumberNote.TabIndex = 2;
            conditionValidationRule8.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule8.ErrorText = "Informe o numero da nota";
            conditionValidationRule8.Value1 = 0;
            this.validator.SetValidationRule(this.tfNumberNote, conditionValidationRule8);
            // 
            // cbDriver
            // 
            this.cbDriver.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgFreight, "driver_id", true));
            this.cbDriver.Location = new System.Drawing.Point(64, 50);
            this.cbDriver.Name = "cbDriver";
            this.cbDriver.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDriver.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cbDriver.Properties.DataSource = this.bdgDrivers;
            this.cbDriver.Properties.DisplayMember = "full_name";
            this.cbDriver.Properties.NullText = "";
            this.cbDriver.Properties.ValueMember = "id";
            this.cbDriver.Properties.View = this.driver_idSearchLookUpEditView;
            this.cbDriver.Size = new System.Drawing.Size(325, 20);
            this.cbDriver.TabIndex = 1;
            conditionValidationRule9.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule9.ErrorText = "Informe o motorista";
            conditionValidationRule9.Value1 = ((long)(0));
            this.validator.SetValidationRule(this.cbDriver, conditionValidationRule9);
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
            this.cbTruck.Location = new System.Drawing.Point(64, 24);
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
            this.cbTruck.Size = new System.Drawing.Size(88, 20);
            this.cbTruck.TabIndex = 0;
            conditionValidationRule10.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule10.ErrorText = "Informe o Caminhão";
            conditionValidationRule10.Value1 = ((long)(0));
            this.validator.SetValidationRule(this.cbTruck, conditionValidationRule10);
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
            this.cbCarrier.Location = new System.Drawing.Point(764, 24);
            this.cbCarrier.Name = "cbCarrier";
            this.cbCarrier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCarrier.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cbCarrier.Properties.DataSource = this.bdgCarrier;
            this.cbCarrier.Properties.DisplayMember = "corporate_name";
            this.cbCarrier.Properties.NullText = "";
            this.cbCarrier.Properties.ValueMember = "id";
            this.cbCarrier.Properties.View = this.gridView1;
            this.cbCarrier.Size = new System.Drawing.Size(269, 20);
            this.cbCarrier.TabIndex = 8;
            conditionValidationRule11.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule11.ErrorText = "Informe o Transportador";
            conditionValidationRule11.Value1 = ((long)(0));
            this.validator.SetValidationRule(this.cbCarrier, conditionValidationRule11);
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
            // tfEnd
            // 
            this.tfEnd.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgFreight, "end", true));
            this.tfEnd.EditValue = null;
            this.tfEnd.Location = new System.Drawing.Point(42, 24);
            this.tfEnd.Name = "tfEnd";
            this.tfEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfEnd.Size = new System.Drawing.Size(108, 20);
            this.tfEnd.TabIndex = 5;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupControl8);
            this.panelControl2.Controls.Add(this.groupControl7);
            this.panelControl2.Controls.Add(this.groupControl6);
            this.panelControl2.Controls.Add(this.groupControl5);
            this.panelControl2.Controls.Add(this.groupControl4);
            this.panelControl2.Controls.Add(this.btnDeposits);
            this.panelControl2.Controls.Add(this.btnStay);
            this.panelControl2.Controls.Add(this.groupControl3);
            this.panelControl2.Controls.Add(this.btnFueled);
            this.panelControl2.Controls.Add(this.btnOutputs);
            this.panelControl2.Controls.Add(labelControl12);
            this.panelControl2.Controls.Add(this.groupControl2);
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Controls.Add(this.tfLiquidFreight);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1044, 435);
            this.panelControl2.TabIndex = 0;
            // 
            // groupControl8
            // 
            this.groupControl8.Controls.Add(labelControl3);
            this.groupControl8.Controls.Add(this.cbCompanySource);
            this.groupControl8.Controls.Add(labelControl2);
            this.groupControl8.Controls.Add(this.cbCompanyDestination);
            this.groupControl8.Controls.Add(labelControl17);
            this.groupControl8.Controls.Add(this.cbCarrier);
            this.groupControl8.Location = new System.Drawing.Point(3, 87);
            this.groupControl8.Name = "groupControl8";
            this.groupControl8.Size = new System.Drawing.Size(1038, 55);
            this.groupControl8.TabIndex = 44;
            this.groupControl8.Text = "Informações de Logistica";
            // 
            // groupControl7
            // 
            this.groupControl7.Controls.Add(this.tfId);
            this.groupControl7.Controls.Add(idLabel);
            this.groupControl7.Controls.Add(this.tfNumberNote);
            this.groupControl7.Controls.Add(number_noteLabel);
            this.groupControl7.Controls.Add(this.tfNumberCte);
            this.groupControl7.Controls.Add(number_cteLabel);
            this.groupControl7.Controls.Add(labelControl6);
            this.groupControl7.Controls.Add(this.tfProduct);
            this.groupControl7.Location = new System.Drawing.Point(726, -1);
            this.groupControl7.Name = "groupControl7";
            this.groupControl7.Size = new System.Drawing.Size(314, 88);
            this.groupControl7.TabIndex = 43;
            this.groupControl7.Text = "Outras informações";
            // 
            // tfId
            // 
            this.tfId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgFreight, "id", true));
            this.tfId.Location = new System.Drawing.Point(272, 24);
            this.tfId.Name = "tfId";
            this.tfId.Properties.ReadOnly = true;
            this.tfId.Size = new System.Drawing.Size(38, 20);
            this.tfId.TabIndex = 1;
            this.tfId.TabStop = false;
            // 
            // tfNumberCte
            // 
            this.tfNumberCte.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgFreight, "number_cte", true));
            this.tfNumberCte.Location = new System.Drawing.Point(154, 24);
            this.tfNumberCte.Name = "tfNumberCte";
            this.tfNumberCte.Size = new System.Drawing.Size(79, 20);
            this.tfNumberCte.TabIndex = 3;
            // 
            // groupControl6
            // 
            this.groupControl6.Controls.Add(this.textEdit2);
            this.groupControl6.Controls.Add(this.labelControl26);
            this.groupControl6.Controls.Add(labelControl27);
            this.groupControl6.Controls.Add(this.tfEnd);
            this.groupControl6.Location = new System.Drawing.Point(562, -1);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(163, 88);
            this.groupControl6.TabIndex = 42;
            this.groupControl6.Text = "Fim";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(42, 50);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Mask.EditMask = "\\d+.[0-9]";
            this.textEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEdit2.Size = new System.Drawing.Size(108, 20);
            this.textEdit2.TabIndex = 22;
            // 
            // labelControl26
            // 
            this.labelControl26.Location = new System.Drawing.Point(9, 53);
            this.labelControl26.Name = "labelControl26";
            this.labelControl26.Size = new System.Drawing.Size(18, 13);
            this.labelControl26.TabIndex = 21;
            this.labelControl26.Text = "KM:";
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.textEdit1);
            this.groupControl5.Controls.Add(this.labelControl25);
            this.groupControl5.Controls.Add(this.tfStart);
            this.groupControl5.Controls.Add(labelControl4);
            this.groupControl5.Location = new System.Drawing.Point(398, -1);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(163, 88);
            this.groupControl5.TabIndex = 42;
            this.groupControl5.Text = "Inicio";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(42, 50);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Mask.EditMask = "\\d+.[0-9]";
            this.textEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEdit1.Properties.Mask.ShowPlaceHolders = false;
            this.textEdit1.Size = new System.Drawing.Size(108, 20);
            this.textEdit1.TabIndex = 22;
            // 
            // labelControl25
            // 
            this.labelControl25.Location = new System.Drawing.Point(9, 53);
            this.labelControl25.Name = "labelControl25";
            this.labelControl25.Size = new System.Drawing.Size(18, 13);
            this.labelControl25.TabIndex = 21;
            this.labelControl25.Text = "KM:";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(labelControl1);
            this.groupControl4.Controls.Add(this.cbTruck);
            this.groupControl4.Controls.Add(this.lbTrailers);
            this.groupControl4.Controls.Add(this.cbDriver);
            this.groupControl4.Controls.Add(driver_idLabel);
            this.groupControl4.Location = new System.Drawing.Point(3, -1);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(394, 88);
            this.groupControl4.TabIndex = 41;
            this.groupControl4.Text = "Veículo";
            // 
            // lbTrailers
            // 
            this.lbTrailers.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lbTrailers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbTrailers.LineColor = System.Drawing.Color.White;
            this.lbTrailers.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.lbTrailers.Location = new System.Drawing.Point(158, 27);
            this.lbTrailers.Name = "lbTrailers";
            this.lbTrailers.Size = new System.Drawing.Size(52, 13);
            this.lbTrailers.TabIndex = 39;
            this.lbTrailers.Text = "Reboques:";
            this.lbTrailers.Click += new System.EventHandler(this.lbTrailers_Click);
            this.lbTrailers.MouseEnter += new System.EventHandler(this.lbTrailers_MouseEnter);
            this.lbTrailers.MouseLeave += new System.EventHandler(this.lbTrailers_MouseLeave);
            // 
            // btnDeposits
            // 
            this.btnDeposits.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnDeposits.Appearance.Options.UseFont = true;
            this.btnDeposits.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnDeposits.Image = global::TruckSystem.Properties.Resources.Money_Bag_22px_green;
            this.btnDeposits.Location = new System.Drawing.Point(251, 303);
            this.btnDeposits.Name = "btnDeposits";
            this.btnDeposits.Size = new System.Drawing.Size(117, 31);
            this.btnDeposits.TabIndex = 40;
            this.btnDeposits.Text = "Depósitos";
            this.btnDeposits.Click += new System.EventHandler(this.btnDeposits_Click);
            // 
            // btnStay
            // 
            this.btnStay.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStay.Appearance.Options.UseFont = true;
            this.btnStay.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnStay.Image = ((System.Drawing.Image)(resources.GetObject("btnStay.Image")));
            this.btnStay.Location = new System.Drawing.Point(374, 303);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(117, 31);
            this.btnStay.TabIndex = 14;
            this.btnStay.Text = "Estadia";
            this.btnStay.Visible = false;
            this.btnStay.Click += new System.EventHandler(this.btnStay_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.tfObservations);
            this.groupControl3.Location = new System.Drawing.Point(3, 341);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(792, 82);
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
            this.tfObservations.Size = new System.Drawing.Size(788, 59);
            this.tfObservations.TabIndex = 0;
            this.tfObservations.UseOptimizedRendering = true;
            // 
            // btnFueled
            // 
            this.btnFueled.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFueled.Appearance.Options.UseFont = true;
            this.btnFueled.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnFueled.Image = global::TruckSystem.Properties.Resources.Gas_Station_22px_blue;
            this.btnFueled.Location = new System.Drawing.Point(128, 303);
            this.btnFueled.Name = "btnFueled";
            this.btnFueled.Size = new System.Drawing.Size(117, 31);
            this.btnFueled.TabIndex = 13;
            this.btnFueled.Text = "Abastecimento";
            this.btnFueled.Click += new System.EventHandler(this.btnFueled_Click);
            // 
            // btnOutputs
            // 
            this.btnOutputs.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutputs.Appearance.Options.UseFont = true;
            this.btnOutputs.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnOutputs.Image = global::TruckSystem.Properties.Resources.General_Ledger_22px_red;
            this.btnOutputs.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnOutputs.Location = new System.Drawing.Point(5, 303);
            this.btnOutputs.Name = "btnOutputs";
            this.btnOutputs.Size = new System.Drawing.Size(117, 31);
            this.btnOutputs.TabIndex = 12;
            this.btnOutputs.Text = "Despesas";
            this.btnOutputs.Click += new System.EventHandler(this.btnOutputs_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.groupControl2.Controls.Add(this.lbBaseComissionLiquid);
            this.groupControl2.Controls.Add(this.lbBaseComissionGross);
            this.groupControl2.Controls.Add(this.tfPartialComissionLiquid);
            this.groupControl2.Controls.Add(this.tfPartialComissionGross);
            this.groupControl2.Controls.Add(labelControl16);
            this.groupControl2.Controls.Add(this.labelControl15);
            this.groupControl2.Controls.Add(labelControl14);
            this.groupControl2.Controls.Add(this.tfValueComission);
            this.groupControl2.Controls.Add(this.tfExtraComission);
            this.groupControl2.Controls.Add(this.tfDiscountComission);
            this.groupControl2.Controls.Add(labelControl21);
            this.groupControl2.Controls.Add(labelControl23);
            this.groupControl2.Controls.Add(labelControl22);
            this.groupControl2.Controls.Add(labelControl13);
            this.groupControl2.Controls.Add(this.tfPercentComissionLiquid);
            this.groupControl2.Controls.Add(this.tfPercentComissionGross);
            this.groupControl2.Location = new System.Drawing.Point(395, 140);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(530, 157);
            this.groupControl2.TabIndex = 11;
            this.groupControl2.Text = "Comissões Motorista";
            // 
            // lbBaseComissionLiquid
            // 
            this.lbBaseComissionLiquid.Location = new System.Drawing.Point(11, 77);
            this.lbBaseComissionLiquid.Name = "lbBaseComissionLiquid";
            this.lbBaseComissionLiquid.Size = new System.Drawing.Size(92, 13);
            this.lbBaseComissionLiquid.TabIndex = 45;
            this.lbBaseComissionLiquid.Text = "Valor Base: R$0,00";
            // 
            // lbBaseComissionGross
            // 
            this.lbBaseComissionGross.Location = new System.Drawing.Point(11, 27);
            this.lbBaseComissionGross.Name = "lbBaseComissionGross";
            this.lbBaseComissionGross.Size = new System.Drawing.Size(92, 13);
            this.lbBaseComissionGross.TabIndex = 45;
            this.lbBaseComissionGross.Text = "Valor Base: R$0,00";
            // 
            // tfPartialComissionLiquid
            // 
            this.tfPartialComissionLiquid.Location = new System.Drawing.Point(282, 96);
            this.tfPartialComissionLiquid.Name = "tfPartialComissionLiquid";
            this.tfPartialComissionLiquid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfPartialComissionLiquid.Properties.Mask.EditMask = "c2";
            this.tfPartialComissionLiquid.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfPartialComissionLiquid.Properties.ReadOnly = true;
            this.tfPartialComissionLiquid.Size = new System.Drawing.Size(100, 20);
            this.tfPartialComissionLiquid.TabIndex = 44;
            // 
            // tfPartialComissionGross
            // 
            this.tfPartialComissionGross.Location = new System.Drawing.Point(282, 46);
            this.tfPartialComissionGross.Name = "tfPartialComissionGross";
            this.tfPartialComissionGross.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfPartialComissionGross.Properties.Mask.EditMask = "c2";
            this.tfPartialComissionGross.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfPartialComissionGross.Properties.ReadOnly = true;
            this.tfPartialComissionGross.Size = new System.Drawing.Size(100, 20);
            this.tfPartialComissionGross.TabIndex = 44;
            // 
            // tfValueComission
            // 
            this.tfValueComission.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgFreight, "value_comission", true));
            this.tfValueComission.Location = new System.Drawing.Point(425, 96);
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
            this.tfExtraComission.Location = new System.Drawing.Point(282, 128);
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
            this.tfDiscountComission.Location = new System.Drawing.Point(92, 128);
            this.tfDiscountComission.Name = "tfDiscountComission";
            this.tfDiscountComission.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfDiscountComission.Properties.Mask.EditMask = "c2";
            this.tfDiscountComission.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfDiscountComission.Size = new System.Drawing.Size(100, 20);
            this.tfDiscountComission.TabIndex = 1;
            this.tfDiscountComission.EditValueChanged += new System.EventHandler(this.calcValues);
            // 
            // tfPercentComissionLiquid
            // 
            this.tfPercentComissionLiquid.Location = new System.Drawing.Point(92, 96);
            this.tfPercentComissionLiquid.Name = "tfPercentComissionLiquid";
            this.tfPercentComissionLiquid.Properties.Mask.EditMask = "n2";
            this.tfPercentComissionLiquid.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tfPercentComissionLiquid.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfPercentComissionLiquid.Size = new System.Drawing.Size(100, 20);
            this.tfPercentComissionLiquid.TabIndex = 0;
            this.tfPercentComissionLiquid.EditValueChanged += new System.EventHandler(this.calcValues);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tfDeposits);
            this.groupControl1.Controls.Add(labelControl19);
            this.groupControl1.Controls.Add(labelControl24);
            this.groupControl1.Controls.Add(labelControl20);
            this.groupControl1.Controls.Add(labelControl11);
            this.groupControl1.Controls.Add(this.tfSubTotalFreight);
            this.groupControl1.Controls.Add(this.tfOthersOutputs);
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
            this.groupControl1.Location = new System.Drawing.Point(3, 140);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(391, 157);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Peso e Valores";
            // 
            // tfDeposits
            // 
            this.tfDeposits.Location = new System.Drawing.Point(61, 103);
            this.tfDeposits.Name = "tfDeposits";
            this.tfDeposits.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfDeposits.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfDeposits.Properties.ReadOnly = true;
            this.tfDeposits.Size = new System.Drawing.Size(107, 20);
            this.tfDeposits.TabIndex = 35;
            // 
            // tfSubTotalFreight
            // 
            this.tfSubTotalFreight.Location = new System.Drawing.Point(279, 128);
            this.tfSubTotalFreight.Name = "tfSubTotalFreight";
            this.tfSubTotalFreight.Properties.Mask.EditMask = "c2";
            this.tfSubTotalFreight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tfSubTotalFreight.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfSubTotalFreight.Properties.ReadOnly = true;
            this.tfSubTotalFreight.Size = new System.Drawing.Size(107, 20);
            this.tfSubTotalFreight.TabIndex = 33;
            this.tfSubTotalFreight.TabStop = false;
            // 
            // tfOthersOutputs
            // 
            this.tfOthersOutputs.Location = new System.Drawing.Point(279, 102);
            this.tfOthersOutputs.Name = "tfOthersOutputs";
            this.tfOthersOutputs.Properties.Mask.EditMask = "c2";
            this.tfOthersOutputs.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tfOthersOutputs.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfOthersOutputs.Properties.ReadOnly = true;
            this.tfOthersOutputs.Size = new System.Drawing.Size(107, 20);
            this.tfOthersOutputs.TabIndex = 33;
            this.tfOthersOutputs.TabStop = false;
            // 
            // tfOutputs
            // 
            this.tfOutputs.Location = new System.Drawing.Point(279, 76);
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
            this.tfStay.Location = new System.Drawing.Point(61, 77);
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
            this.tfFueled.Location = new System.Drawing.Point(279, 50);
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
            this.tfGross.Location = new System.Drawing.Point(61, 50);
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
            this.tfLiquidFreight.Location = new System.Drawing.Point(644, 306);
            this.tfLiquidFreight.Name = "tfLiquidFreight";
            this.tfLiquidFreight.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfLiquidFreight.Properties.Appearance.ForeColor = System.Drawing.Color.Green;
            this.tfLiquidFreight.Properties.Appearance.Options.UseFont = true;
            this.tfLiquidFreight.Properties.Appearance.Options.UseForeColor = true;
            this.tfLiquidFreight.Properties.Mask.EditMask = "c2";
            this.tfLiquidFreight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tfLiquidFreight.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfLiquidFreight.Properties.ReadOnly = true;
            this.tfLiquidFreight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tfLiquidFreight.Size = new System.Drawing.Size(152, 24);
            this.tfLiquidFreight.TabIndex = 35;
            this.tfLiquidFreight.TabStop = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.btnUpdateData);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 435);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1044, 67);
            this.panelControl1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSave.Location = new System.Drawing.Point(643, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(58, 58);
            this.btnSave.TabIndex = 2;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnCancel.Image = global::TruckSystem.Properties.Resources.Cancel_48px;
            this.btnCancel.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnCancel.Location = new System.Drawing.Point(728, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(58, 58);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdateData
            // 
            this.btnUpdateData.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnUpdateData.Image = global::TruckSystem.Properties.Resources.Refresh_48px;
            this.btnUpdateData.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnUpdateData.Location = new System.Drawing.Point(15, 5);
            this.btnUpdateData.Name = "btnUpdateData";
            this.btnUpdateData.Size = new System.Drawing.Size(58, 58);
            this.btnUpdateData.TabIndex = 2;
            this.btnUpdateData.Click += new System.EventHandler(this.btnUpdateData_Click);
            // 
            // FreightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FreightForm";
            this.Size = new System.Drawing.Size(1044, 502);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FreightForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.validator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfPercentComissionGross.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValueTon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgFreight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfWeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfProduct.Properties)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.tfEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).EndInit();
            this.groupControl8.ResumeLayout(false);
            this.groupControl8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).EndInit();
            this.groupControl7.ResumeLayout(false);
            this.groupControl7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfNumberCte.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            this.groupControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tfObservations.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfPartialComissionLiquid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfPartialComissionGross.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValueComission.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfExtraComission.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDiscountComission.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfPercentComissionLiquid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfDeposits.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfSubTotalFreight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfOthersOutputs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfOutputs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfStay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfFueled.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfGross.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfLiquidFreight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bdgFreight;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validator;
        private DevExpress.XtraEditors.PanelControl panelControl1;
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
        private DevExpress.XtraEditors.TextEdit tfPercentComissionGross;
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
        private DevExpress.XtraEditors.TextEdit tfOthersOutputs;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.CalcEdit tfPartialComissionLiquid;
        private DevExpress.XtraEditors.CalcEdit tfPartialComissionGross;
        private DevExpress.XtraEditors.TextEdit tfPercentComissionLiquid;
        private DevExpress.XtraEditors.LabelControl lbBaseComissionLiquid;
        private DevExpress.XtraEditors.LabelControl lbBaseComissionGross;
        private DevExpress.XtraEditors.TextEdit tfSubTotalFreight;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl25;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl26;
        private DevExpress.XtraEditors.GroupControl groupControl7;
        private DevExpress.XtraEditors.GroupControl groupControl8;
    }
}
