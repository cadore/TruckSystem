using TruckSystem.Utils;
namespace TruckSystem.UI.Customer
{
    partial class CustomerForm
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule6 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule7 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule8 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pnAddress = new DevExpress.XtraEditors.GroupControl();
            this.cbCity = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdgAddress = new System.Windows.Forms.BindingSource(this.components);
            this.bdgCity = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcod_ibge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstate_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpopulation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldemographic = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgentilic = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colarea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colzip_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbStateAddress = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdgStates = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsymbol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.tfCep = new DevExpress.XtraEditors.TextEdit();
            this.tfDistrict = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.tfComplement = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.tfNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.tfAddress = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new WCButtons.Black.ButtonSaveBlack();
            this.btnCancel = new WCButtons.Black.ButtonCancelBlack();
            this.pnData = new DevExpress.XtraEditors.GroupControl();
            this.subPnData = new DevExpress.XtraEditors.GroupControl();
            this.tfCnpj = new DevExpress.XtraEditors.TextEdit();
            this.bdgCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.tfId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tfIE = new DevExpress.XtraEditors.TextEdit();
            this.lbIE = new DevExpress.XtraEditors.LabelControl();
            this.tfPhoneMobile = new DevExpress.XtraEditors.TextEdit();
            this.tfPhoneFixed = new DevExpress.XtraEditors.TextEdit();
            this.tfFantasyName = new DevExpress.XtraEditors.TextEdit();
            this.tfCorporateName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lbFantasyName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbCNPJ = new DevExpress.XtraEditors.LabelControl();
            this.lbCorporateName = new DevExpress.XtraEditors.LabelControl();
            this.rgType = new DevExpress.XtraEditors.RadioGroup();
            this.validator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnAddress)).BeginInit();
            this.pnAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStateAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgStates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfCep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDistrict.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfComplement.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnData)).BeginInit();
            this.pnData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subPnData)).BeginInit();
            this.subPnData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfCnpj.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfIE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfPhoneMobile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfPhoneFixed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfFantasyName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfCorporateName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.pnAddress);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.pnData);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(907, 276);
            this.panelControl1.TabIndex = 0;
            // 
            // pnAddress
            // 
            this.pnAddress.Controls.Add(this.cbCity);
            this.pnAddress.Controls.Add(this.cbStateAddress);
            this.pnAddress.Controls.Add(this.labelControl13);
            this.pnAddress.Controls.Add(this.tfCep);
            this.pnAddress.Controls.Add(this.tfDistrict);
            this.pnAddress.Controls.Add(this.labelControl14);
            this.pnAddress.Controls.Add(this.labelControl12);
            this.pnAddress.Controls.Add(this.labelControl11);
            this.pnAddress.Controls.Add(this.tfComplement);
            this.pnAddress.Controls.Add(this.labelControl10);
            this.pnAddress.Controls.Add(this.tfNumber);
            this.pnAddress.Controls.Add(this.labelControl9);
            this.pnAddress.Controls.Add(this.tfAddress);
            this.pnAddress.Controls.Add(this.labelControl15);
            this.pnAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnAddress.Enabled = false;
            this.pnAddress.Location = new System.Drawing.Point(2, 152);
            this.pnAddress.Name = "pnAddress";
            this.pnAddress.Size = new System.Drawing.Size(903, 79);
            this.pnAddress.TabIndex = 1;
            this.pnAddress.Text = "Endereço";
            // 
            // cbCity
            // 
            this.cbCity.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgAddress, "city_id", true));
            this.cbCity.Location = new System.Drawing.Point(474, 50);
            this.cbCity.Name = "cbCity";
            this.cbCity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCity.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cbCity.Properties.DataSource = this.bdgCity;
            this.cbCity.Properties.DisplayMember = "name";
            this.cbCity.Properties.NullText = "";
            this.cbCity.Properties.ValueMember = "id";
            this.cbCity.Properties.View = this.gridView1;
            this.cbCity.Size = new System.Drawing.Size(274, 20);
            this.cbCity.TabIndex = 5;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule1.ErrorText = "Informe a cidade";
            conditionValidationRule1.Value1 = ((long)(0));
            this.validator.SetValidationRule(this.cbCity, conditionValidationRule1);
            // 
            // bdgAddress
            // 
            this.bdgAddress.DataSource = typeof(TruckSystem.address);
            // 
            // bdgCity
            // 
            this.bdgCity.DataSource = typeof(TruckSystem.city);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.colcod_ibge,
            this.colstate_id,
            this.colpopulation,
            this.coldemographic,
            this.colgentilic,
            this.colarea,
            this.colzip_code});
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
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 176;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Name";
            this.gridColumn2.FieldName = "name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 476;
            // 
            // colcod_ibge
            // 
            this.colcod_ibge.FieldName = "cod_ibge";
            this.colcod_ibge.Name = "colcod_ibge";
            this.colcod_ibge.OptionsColumn.AllowEdit = false;
            // 
            // colstate_id
            // 
            this.colstate_id.FieldName = "state_id";
            this.colstate_id.Name = "colstate_id";
            this.colstate_id.OptionsColumn.AllowEdit = false;
            // 
            // colpopulation
            // 
            this.colpopulation.FieldName = "population";
            this.colpopulation.Name = "colpopulation";
            this.colpopulation.OptionsColumn.AllowEdit = false;
            // 
            // coldemographic
            // 
            this.coldemographic.FieldName = "demographic";
            this.coldemographic.Name = "coldemographic";
            this.coldemographic.OptionsColumn.AllowEdit = false;
            // 
            // colgentilic
            // 
            this.colgentilic.FieldName = "gentilic";
            this.colgentilic.Name = "colgentilic";
            this.colgentilic.OptionsColumn.AllowEdit = false;
            // 
            // colarea
            // 
            this.colarea.FieldName = "area";
            this.colarea.Name = "colarea";
            this.colarea.OptionsColumn.AllowEdit = false;
            // 
            // colzip_code
            // 
            this.colzip_code.Caption = "CEP";
            this.colzip_code.FieldName = "zip_code";
            this.colzip_code.Name = "colzip_code";
            this.colzip_code.OptionsColumn.AllowEdit = false;
            this.colzip_code.Visible = true;
            this.colzip_code.VisibleIndex = 2;
            this.colzip_code.Width = 426;
            // 
            // cbStateAddress
            // 
            this.cbStateAddress.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgAddress, "state_id", true));
            this.cbStateAddress.Location = new System.Drawing.Point(331, 50);
            this.cbStateAddress.Name = "cbStateAddress";
            this.cbStateAddress.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbStateAddress.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cbStateAddress.Properties.DataSource = this.bdgStates;
            this.cbStateAddress.Properties.DisplayMember = "symbol";
            this.cbStateAddress.Properties.NullText = "";
            this.cbStateAddress.Properties.ValueMember = "id";
            this.cbStateAddress.Properties.View = this.searchLookUpEdit1View;
            this.cbStateAddress.Size = new System.Drawing.Size(94, 20);
            this.cbStateAddress.TabIndex = 4;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule2.ErrorText = "Informe o Estado";
            conditionValidationRule2.Value1 = ((long)(0));
            this.validator.SetValidationRule(this.cbStateAddress, conditionValidationRule2);
            this.cbStateAddress.EditValueChanged += new System.EventHandler(this.cbStateAddress_EditValueChanged);
            // 
            // bdgStates
            // 
            this.bdgStates.DataSource = typeof(TruckSystem.state);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colname,
            this.colsymbol});
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
            this.colid.Width = 115;
            // 
            // colname
            // 
            this.colname.Caption = "Nome";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.OptionsColumn.AllowEdit = false;
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            this.colname.Width = 480;
            // 
            // colsymbol
            // 
            this.colsymbol.Caption = "Sigla";
            this.colsymbol.FieldName = "symbol";
            this.colsymbol.Name = "colsymbol";
            this.colsymbol.OptionsColumn.AllowEdit = false;
            this.colsymbol.Visible = true;
            this.colsymbol.VisibleIndex = 2;
            this.colsymbol.Width = 483;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(431, 53);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(37, 13);
            this.labelControl13.TabIndex = 0;
            this.labelControl13.Text = "Cidade:";
            // 
            // tfCep
            // 
            this.tfCep.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgAddress, "cep", true));
            this.tfCep.Location = new System.Drawing.Point(783, 50);
            this.tfCep.Name = "tfCep";
            this.tfCep.Properties.Mask.EditMask = "00000-000";
            this.tfCep.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.tfCep.Size = new System.Drawing.Size(114, 20);
            this.tfCep.TabIndex = 6;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Informe o CEP";
            this.validator.SetValidationRule(this.tfCep, conditionValidationRule3);
            // 
            // tfDistrict
            // 
            this.tfDistrict.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgAddress, "district", true));
            this.tfDistrict.Location = new System.Drawing.Point(60, 50);
            this.tfDistrict.Name = "tfDistrict";
            this.tfDistrict.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfDistrict.Size = new System.Drawing.Size(242, 20);
            this.tfDistrict.TabIndex = 3;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Informe o bairro";
            this.validator.SetValidationRule(this.tfDistrict, conditionValidationRule4);
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(754, 53);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(23, 13);
            this.labelControl14.TabIndex = 0;
            this.labelControl14.Text = "CEP:";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(308, 53);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(17, 13);
            this.labelControl12.TabIndex = 0;
            this.labelControl12.Text = "UF:";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(4, 53);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(32, 13);
            this.labelControl11.TabIndex = 0;
            this.labelControl11.Text = "Bairro:";
            // 
            // tfComplement
            // 
            this.tfComplement.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgAddress, "complement", true));
            this.tfComplement.Location = new System.Drawing.Point(594, 24);
            this.tfComplement.Name = "tfComplement";
            this.tfComplement.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfComplement.Size = new System.Drawing.Size(303, 20);
            this.tfComplement.TabIndex = 2;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(519, 27);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(69, 13);
            this.labelControl10.TabIndex = 0;
            this.labelControl10.Text = "Complemento:";
            // 
            // tfNumber
            // 
            this.tfNumber.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgAddress, "number", true));
            this.tfNumber.Location = new System.Drawing.Point(416, 24);
            this.tfNumber.Name = "tfNumber";
            this.tfNumber.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfNumber.Size = new System.Drawing.Size(94, 20);
            this.tfNumber.TabIndex = 1;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(369, 27);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(41, 13);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "Numero:";
            // 
            // tfAddress
            // 
            this.tfAddress.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgAddress, "name", true));
            this.tfAddress.Location = new System.Drawing.Point(60, 24);
            this.tfAddress.Name = "tfAddress";
            this.tfAddress.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfAddress.Size = new System.Drawing.Size(296, 20);
            this.tfAddress.TabIndex = 0;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "Informe o endereço";
            this.validator.SetValidationRule(this.tfAddress, conditionValidationRule5);
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(5, 27);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(49, 13);
            this.labelControl15.TabIndex = 0;
            this.labelControl15.Text = "Endereço:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnSave);
            this.panelControl2.Controls.Add(this.btnCancel);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(2, 231);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(903, 43);
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
            this.btnSave.Location = new System.Drawing.Point(671, 5);
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
            this.btnCancel.Location = new System.Drawing.Point(787, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 33);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnData
            // 
            this.pnData.Controls.Add(this.subPnData);
            this.pnData.Controls.Add(this.rgType);
            this.pnData.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnData.Location = new System.Drawing.Point(2, 2);
            this.pnData.Name = "pnData";
            this.pnData.Size = new System.Drawing.Size(903, 150);
            this.pnData.TabIndex = 0;
            this.pnData.Text = "Informações Gerais";
            // 
            // subPnData
            // 
            this.subPnData.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.subPnData.Controls.Add(this.tfCnpj);
            this.subPnData.Controls.Add(this.tfId);
            this.subPnData.Controls.Add(this.labelControl3);
            this.subPnData.Controls.Add(this.tfIE);
            this.subPnData.Controls.Add(this.lbIE);
            this.subPnData.Controls.Add(this.tfPhoneMobile);
            this.subPnData.Controls.Add(this.tfPhoneFixed);
            this.subPnData.Controls.Add(this.tfFantasyName);
            this.subPnData.Controls.Add(this.tfCorporateName);
            this.subPnData.Controls.Add(this.labelControl2);
            this.subPnData.Controls.Add(this.lbFantasyName);
            this.subPnData.Controls.Add(this.labelControl1);
            this.subPnData.Controls.Add(this.lbCNPJ);
            this.subPnData.Controls.Add(this.lbCorporateName);
            this.subPnData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.subPnData.Enabled = false;
            this.subPnData.Location = new System.Drawing.Point(2, 49);
            this.subPnData.Name = "subPnData";
            this.subPnData.Size = new System.Drawing.Size(899, 99);
            this.subPnData.TabIndex = 1;
            // 
            // tfCnpj
            // 
            this.tfCnpj.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCustomer, "document", true));
            this.tfCnpj.Location = new System.Drawing.Point(80, 4);
            this.tfCnpj.Name = "tfCnpj";
            this.tfCnpj.Size = new System.Drawing.Size(166, 20);
            this.tfCnpj.TabIndex = 0;
            // 
            // bdgCustomer
            // 
            this.bdgCustomer.DataSource = typeof(TruckSystem.customer);
            // 
            // tfId
            // 
            this.tfId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCustomer, "id", true));
            this.tfId.Location = new System.Drawing.Point(819, 6);
            this.tfId.Name = "tfId";
            this.tfId.Size = new System.Drawing.Size(72, 20);
            this.tfId.TabIndex = 2;
            this.tfId.TabStop = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(786, 9);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(27, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Cod.:";
            // 
            // tfIE
            // 
            this.tfIE.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCustomer, "ie_rg", true));
            this.tfIE.Location = new System.Drawing.Point(285, 4);
            this.tfIE.Name = "tfIE";
            this.tfIE.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfIE.Size = new System.Drawing.Size(160, 20);
            this.tfIE.TabIndex = 1;
            // 
            // lbIE
            // 
            this.lbIE.Location = new System.Drawing.Point(252, 6);
            this.lbIE.Name = "lbIE";
            this.lbIE.Size = new System.Drawing.Size(14, 13);
            this.lbIE.TabIndex = 1;
            this.lbIE.Text = "IE:";
            // 
            // tfPhoneMobile
            // 
            this.tfPhoneMobile.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCustomer, "phone_mobile", true));
            this.tfPhoneMobile.Location = new System.Drawing.Point(530, 73);
            this.tfPhoneMobile.Name = "tfPhoneMobile";
            this.tfPhoneMobile.Properties.Mask.EditMask = "(00) 0000-0000";
            this.tfPhoneMobile.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.tfPhoneMobile.Size = new System.Drawing.Size(361, 20);
            this.tfPhoneMobile.TabIndex = 5;
            // 
            // tfPhoneFixed
            // 
            this.tfPhoneFixed.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCustomer, "phone_fixed", true));
            this.tfPhoneFixed.Location = new System.Drawing.Point(80, 73);
            this.tfPhoneFixed.Name = "tfPhoneFixed";
            this.tfPhoneFixed.Properties.Mask.EditMask = "(00) 0000-0000";
            this.tfPhoneFixed.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.tfPhoneFixed.Size = new System.Drawing.Size(365, 20);
            this.tfPhoneFixed.TabIndex = 4;
            conditionValidationRule6.ErrorText = "This value is not valid";
            this.validator.SetValidationRule(this.tfPhoneFixed, conditionValidationRule6);
            // 
            // tfFantasyName
            // 
            this.tfFantasyName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCustomer, "fantasy_name", true));
            this.tfFantasyName.Location = new System.Drawing.Point(530, 39);
            this.tfFantasyName.Name = "tfFantasyName";
            this.tfFantasyName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfFantasyName.Size = new System.Drawing.Size(361, 20);
            this.tfFantasyName.TabIndex = 3;
            // 
            // tfCorporateName
            // 
            this.tfCorporateName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCustomer, "corporate_name", true));
            this.tfCorporateName.Location = new System.Drawing.Point(80, 39);
            this.tfCorporateName.Name = "tfCorporateName";
            this.tfCorporateName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfCorporateName.Properties.Mask.EditMask = "[A-Z0-9 /-]+";
            this.tfCorporateName.Size = new System.Drawing.Size(365, 20);
            this.tfCorporateName.TabIndex = 2;
            conditionValidationRule7.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule7.ErrorText = "Informe a Razão Social/Nome";
            this.validator.SetValidationRule(this.tfCorporateName, conditionValidationRule7);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(453, 76);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Celular:";
            // 
            // lbFantasyName
            // 
            this.lbFantasyName.Location = new System.Drawing.Point(453, 42);
            this.lbFantasyName.Name = "lbFantasyName";
            this.lbFantasyName.Size = new System.Drawing.Size(75, 13);
            this.lbFantasyName.TabIndex = 0;
            this.lbFantasyName.Text = "Nome Fantasia:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 76);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Telefone:";
            // 
            // lbCNPJ
            // 
            this.lbCNPJ.Location = new System.Drawing.Point(12, 10);
            this.lbCNPJ.Name = "lbCNPJ";
            this.lbCNPJ.Size = new System.Drawing.Size(29, 13);
            this.lbCNPJ.TabIndex = 1;
            this.lbCNPJ.Text = "CNPJ:";
            // 
            // lbCorporateName
            // 
            this.lbCorporateName.Location = new System.Drawing.Point(10, 42);
            this.lbCorporateName.Name = "lbCorporateName";
            this.lbCorporateName.Size = new System.Drawing.Size(64, 13);
            this.lbCorporateName.TabIndex = 0;
            this.lbCorporateName.Text = "Razão Social:";
            // 
            // rgType
            // 
            this.rgType.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCustomer, "type", true));
            this.rgType.Location = new System.Drawing.Point(341, 24);
            this.rgType.Name = "rgType";
            this.rgType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgType.Properties.Appearance.Options.UseBackColor = true;
            this.rgType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Pessoa Jurídica"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Pessoa Física")});
            this.rgType.Size = new System.Drawing.Size(209, 22);
            this.rgType.TabIndex = 0;
            conditionValidationRule8.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.GreaterOrEqual;
            conditionValidationRule8.ErrorText = "Informe o Tipo de Pessoa";
            conditionValidationRule8.Value1 = 0;
            this.validator.SetValidationRule(this.rgType, conditionValidationRule8);
            this.rgType.SelectedIndexChanged += new System.EventHandler(this.rgType_SelectedIndexChanged);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "CustomerForm";
            this.Size = new System.Drawing.Size(907, 276);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnAddress)).EndInit();
            this.pnAddress.ResumeLayout(false);
            this.pnAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStateAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgStates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfCep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDistrict.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfComplement.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnData)).EndInit();
            this.pnData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subPnData)).EndInit();
            this.subPnData.ResumeLayout(false);
            this.subPnData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfCnpj.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfIE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfPhoneMobile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfPhoneFixed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfFantasyName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfCorporateName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private WCButtons.Black.ButtonCancelBlack btnCancel;
        private DevExpress.XtraEditors.GroupControl pnData;
        private WCButtons.Black.ButtonSaveBlack btnSave;
        private DevExpress.XtraEditors.GroupControl pnAddress;
        private DevExpress.XtraEditors.SearchLookUpEdit cbCity;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_ibge;
        private DevExpress.XtraGrid.Columns.GridColumn colstate_id;
        private DevExpress.XtraGrid.Columns.GridColumn colpopulation;
        private DevExpress.XtraGrid.Columns.GridColumn coldemographic;
        private DevExpress.XtraGrid.Columns.GridColumn colgentilic;
        private DevExpress.XtraGrid.Columns.GridColumn colarea;
        private DevExpress.XtraGrid.Columns.GridColumn colzip_code;
        private DevExpress.XtraEditors.SearchLookUpEdit cbStateAddress;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colsymbol;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit tfCep;
        private DevExpress.XtraEditors.TextEdit tfDistrict;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit tfComplement;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit tfNumber;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit tfAddress;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl lbCorporateName;
        private DevExpress.XtraEditors.RadioGroup rgType;
        private DevExpress.XtraEditors.GroupControl subPnData;
        private DevExpress.XtraEditors.TextEdit tfIE;
        private DevExpress.XtraEditors.LabelControl lbIE;
        private DevExpress.XtraEditors.TextEdit tfFantasyName;
        private DevExpress.XtraEditors.TextEdit tfCorporateName;
        private DevExpress.XtraEditors.LabelControl lbFantasyName;
        private DevExpress.XtraEditors.LabelControl lbCNPJ;
        private DevExpress.XtraEditors.TextEdit tfPhoneMobile;
        private DevExpress.XtraEditors.TextEdit tfPhoneFixed;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource bdgCustomer;
        private System.Windows.Forms.BindingSource bdgAddress;
        private DevExpress.XtraEditors.TextEdit tfId;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.BindingSource bdgStates;
        private System.Windows.Forms.BindingSource bdgCity;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validator;
        private DevExpress.XtraEditors.TextEdit tfCnpj;

    }
}
