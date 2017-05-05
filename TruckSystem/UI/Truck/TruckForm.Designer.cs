using DevExpress.XtraEditors.DXErrorProvider;
namespace TruckSystem.UI.Truck
{
    partial class TruckForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TruckForm));
            this.pnButtons = new DevExpress.XtraEditors.PanelControl();
            this.btnFiles = new WCButtons.Black.ButtonFolderBlack();
            this.btnNew = new WCButtons.Black.ButtonAddBlack();
            this.btnSave = new WCButtons.Black.ButtonSaveBlack();
            this.btnCancel = new WCButtons.Black.ButtonCancelBlack();
            this.pnGeneral = new DevExpress.XtraEditors.PanelControl();
            this.pnTruck = new DevExpress.XtraEditors.PanelControl();
            this.cbAntt = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdgTruck = new System.Windows.Forms.BindingSource(this.components);
            this.bdgAntt = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrntrc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalidation_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcustomer_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcustomer_cnpj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnUpdateDrivers = new DevExpress.XtraEditors.SimpleButton();
            this.cbDriver = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdgDriver = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfull_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcpf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tfIdTruck = new DevExpress.XtraEditors.TextEdit();
            this.tfRenavamTruck = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tfColorTruck = new DevExpress.XtraEditors.TextEdit();
            this.tfModelTruck = new DevExpress.XtraEditors.TextEdit();
            this.tfYearModelTruck = new DevExpress.XtraEditors.TextEdit();
            this.tfYearFabricationTruck = new DevExpress.XtraEditors.TextEdit();
            this.tfMarkTruck = new DevExpress.XtraEditors.TextEdit();
            this.tfChassiTruck = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.tfBoardTruck = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnButtons)).BeginInit();
            this.pnButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnGeneral)).BeginInit();
            this.pnGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnTruck)).BeginInit();
            this.pnTruck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbAntt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgTruck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgAntt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDriver.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgDriver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfIdTruck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfRenavamTruck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfColorTruck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfModelTruck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfYearModelTruck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfYearFabricationTruck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfMarkTruck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfChassiTruck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfBoardTruck.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnButtons
            // 
            this.pnButtons.Controls.Add(this.btnFiles);
            this.pnButtons.Controls.Add(this.btnNew);
            this.pnButtons.Controls.Add(this.btnSave);
            this.pnButtons.Controls.Add(this.btnCancel);
            this.pnButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnButtons.Location = new System.Drawing.Point(0, 177);
            this.pnButtons.Name = "pnButtons";
            this.pnButtons.Size = new System.Drawing.Size(585, 43);
            this.pnButtons.TabIndex = 0;
            // 
            // btnFiles
            // 
            this.btnFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiles.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnFiles.ForeColor = System.Drawing.Color.White;
            this.btnFiles.Image = ((System.Drawing.Image)(resources.GetObject("btnFiles.Image")));
            this.btnFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiles.Location = new System.Drawing.Point(123, 5);
            this.btnFiles.Name = "btnFiles";
            this.btnFiles.Size = new System.Drawing.Size(110, 33);
            this.btnFiles.TabIndex = 3;
            this.btnFiles.Text = "Arquivos";
            this.btnFiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiles.UseVisualStyleBackColor = false;
            this.btnFiles.Click += new System.EventHandler(this.btnFiles_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(7, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(110, 33);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Novo";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
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
            this.btnSave.Location = new System.Drawing.Point(354, 5);
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
            this.btnCancel.Location = new System.Drawing.Point(470, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 33);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnGeneral
            // 
            this.pnGeneral.Controls.Add(this.pnTruck);
            this.pnGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnGeneral.Location = new System.Drawing.Point(0, 0);
            this.pnGeneral.Name = "pnGeneral";
            this.pnGeneral.Size = new System.Drawing.Size(585, 177);
            this.pnGeneral.TabIndex = 1;
            // 
            // pnTruck
            // 
            this.pnTruck.Controls.Add(this.cbAntt);
            this.pnTruck.Controls.Add(this.btnUpdateDrivers);
            this.pnTruck.Controls.Add(this.cbDriver);
            this.pnTruck.Controls.Add(this.tfIdTruck);
            this.pnTruck.Controls.Add(this.tfRenavamTruck);
            this.pnTruck.Controls.Add(this.labelControl4);
            this.pnTruck.Controls.Add(this.tfColorTruck);
            this.pnTruck.Controls.Add(this.tfModelTruck);
            this.pnTruck.Controls.Add(this.tfYearModelTruck);
            this.pnTruck.Controls.Add(this.tfYearFabricationTruck);
            this.pnTruck.Controls.Add(this.tfMarkTruck);
            this.pnTruck.Controls.Add(this.tfChassiTruck);
            this.pnTruck.Controls.Add(this.labelControl3);
            this.pnTruck.Controls.Add(this.labelControl7);
            this.pnTruck.Controls.Add(this.tfBoardTruck);
            this.pnTruck.Controls.Add(this.labelControl9);
            this.pnTruck.Controls.Add(this.labelControl6);
            this.pnTruck.Controls.Add(this.labelControl11);
            this.pnTruck.Controls.Add(this.labelControl8);
            this.pnTruck.Controls.Add(this.labelControl10);
            this.pnTruck.Controls.Add(this.labelControl2);
            this.pnTruck.Controls.Add(this.labelControl5);
            this.pnTruck.Controls.Add(this.labelControl1);
            this.pnTruck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTruck.Location = new System.Drawing.Point(2, 2);
            this.pnTruck.Name = "pnTruck";
            this.pnTruck.Size = new System.Drawing.Size(581, 173);
            this.pnTruck.TabIndex = 1;
            // 
            // cbAntt
            // 
            this.cbAntt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgTruck, "antt_id", true));
            this.cbAntt.Location = new System.Drawing.Point(301, 32);
            this.cbAntt.Name = "cbAntt";
            this.cbAntt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbAntt.Properties.DataSource = this.bdgAntt;
            this.cbAntt.Properties.DisplayMember = "rntrc";
            this.cbAntt.Properties.NullText = "";
            this.cbAntt.Properties.ValueMember = "id";
            this.cbAntt.Properties.View = this.gridView1;
            this.cbAntt.Size = new System.Drawing.Size(270, 20);
            this.cbAntt.TabIndex = 10;
            // 
            // bdgTruck
            // 
            this.bdgTruck.DataSource = typeof(TruckSystem.truck);
            // 
            // bdgAntt
            // 
            this.bdgAntt.DataSource = typeof(TruckSystem.antts);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colrntrc,
            this.colvalidation_date,
            this.colcustomer_name,
            this.colcustomer_cnpj});
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
            this.gridColumn1.Width = 61;
            // 
            // colrntrc
            // 
            this.colrntrc.Caption = "RNTRC";
            this.colrntrc.FieldName = "rntrc";
            this.colrntrc.Name = "colrntrc";
            this.colrntrc.OptionsColumn.AllowEdit = false;
            this.colrntrc.Visible = true;
            this.colrntrc.VisibleIndex = 1;
            this.colrntrc.Width = 106;
            // 
            // colvalidation_date
            // 
            this.colvalidation_date.Caption = "Validade";
            this.colvalidation_date.FieldName = "validation_date";
            this.colvalidation_date.Name = "colvalidation_date";
            this.colvalidation_date.OptionsColumn.AllowEdit = false;
            this.colvalidation_date.Visible = true;
            this.colvalidation_date.VisibleIndex = 2;
            this.colvalidation_date.Width = 105;
            // 
            // colcustomer_name
            // 
            this.colcustomer_name.Caption = "Cliente";
            this.colcustomer_name.FieldName = "customer_name";
            this.colcustomer_name.Name = "colcustomer_name";
            this.colcustomer_name.OptionsColumn.AllowEdit = false;
            this.colcustomer_name.Visible = true;
            this.colcustomer_name.VisibleIndex = 3;
            this.colcustomer_name.Width = 266;
            // 
            // colcustomer_cnpj
            // 
            this.colcustomer_cnpj.Caption = "Documento";
            this.colcustomer_cnpj.FieldName = "customer_cnpj";
            this.colcustomer_cnpj.Name = "colcustomer_cnpj";
            this.colcustomer_cnpj.OptionsColumn.AllowEdit = false;
            this.colcustomer_cnpj.Visible = true;
            this.colcustomer_cnpj.VisibleIndex = 4;
            this.colcustomer_cnpj.Width = 158;
            // 
            // btnUpdateDrivers
            // 
            this.btnUpdateDrivers.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnUpdateDrivers.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateDrivers.Image")));
            this.btnUpdateDrivers.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnUpdateDrivers.Location = new System.Drawing.Point(540, 141);
            this.btnUpdateDrivers.Name = "btnUpdateDrivers";
            this.btnUpdateDrivers.Size = new System.Drawing.Size(31, 23);
            this.btnUpdateDrivers.TabIndex = 4;
            this.btnUpdateDrivers.TabStop = false;
            // 
            // cbDriver
            // 
            this.cbDriver.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgTruck, "driver_id", true));
            this.cbDriver.Location = new System.Drawing.Point(70, 142);
            this.cbDriver.Name = "cbDriver";
            this.cbDriver.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDriver.Properties.DataSource = this.bdgDriver;
            this.cbDriver.Properties.DisplayMember = "full_name";
            this.cbDriver.Properties.NullText = "";
            this.cbDriver.Properties.ValueMember = "id";
            this.cbDriver.Properties.View = this.searchLookUpEdit1View;
            this.cbDriver.Size = new System.Drawing.Size(467, 20);
            this.cbDriver.TabIndex = 9;
            // 
            // bdgDriver
            // 
            this.bdgDriver.DataSource = typeof(TruckSystem.driver);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colfull_name,
            this.colcpf});
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
            this.colid.Width = 146;
            // 
            // colfull_name
            // 
            this.colfull_name.Caption = "Nome Completo";
            this.colfull_name.FieldName = "full_name";
            this.colfull_name.Name = "colfull_name";
            this.colfull_name.OptionsColumn.AllowEdit = false;
            this.colfull_name.Visible = true;
            this.colfull_name.VisibleIndex = 1;
            this.colfull_name.Width = 464;
            // 
            // colcpf
            // 
            this.colcpf.Caption = "CPF";
            this.colcpf.FieldName = "cpf";
            this.colcpf.Name = "colcpf";
            this.colcpf.OptionsColumn.AllowEdit = false;
            this.colcpf.Visible = true;
            this.colcpf.VisibleIndex = 2;
            this.colcpf.Width = 468;
            // 
            // tfIdTruck
            // 
            this.tfIdTruck.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgTruck, "id", true));
            this.tfIdTruck.Location = new System.Drawing.Point(510, 6);
            this.tfIdTruck.Name = "tfIdTruck";
            this.tfIdTruck.Properties.ReadOnly = true;
            this.tfIdTruck.Size = new System.Drawing.Size(61, 20);
            this.tfIdTruck.TabIndex = 2;
            this.tfIdTruck.TabStop = false;
            // 
            // tfRenavamTruck
            // 
            this.tfRenavamTruck.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgTruck, "renavam", true));
            this.tfRenavamTruck.Location = new System.Drawing.Point(70, 32);
            this.tfRenavamTruck.Name = "tfRenavamTruck";
            this.tfRenavamTruck.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfRenavamTruck.Properties.Mask.EditMask = "d";
            this.tfRenavamTruck.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tfRenavamTruck.Size = new System.Drawing.Size(181, 20);
            this.tfRenavamTruck.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(478, 9);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(27, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Cod.:";
            // 
            // tfColorTruck
            // 
            this.tfColorTruck.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgTruck, "color", true));
            this.tfColorTruck.Location = new System.Drawing.Point(70, 86);
            this.tfColorTruck.Name = "tfColorTruck";
            this.tfColorTruck.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfColorTruck.Properties.Mask.EditMask = "[a-zA-Z]+";
            this.tfColorTruck.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.tfColorTruck.Size = new System.Drawing.Size(181, 20);
            this.tfColorTruck.TabIndex = 6;
            // 
            // tfModelTruck
            // 
            this.tfModelTruck.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgTruck, "model", true));
            this.tfModelTruck.Location = new System.Drawing.Point(301, 60);
            this.tfModelTruck.Name = "tfModelTruck";
            this.tfModelTruck.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfModelTruck.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.tfModelTruck.Properties.Mask.EditMask = "\\p{Lu}+";
            this.tfModelTruck.Size = new System.Drawing.Size(270, 20);
            this.tfModelTruck.TabIndex = 5;
            // 
            // tfYearModelTruck
            // 
            this.tfYearModelTruck.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgTruck, "year_model", true));
            this.tfYearModelTruck.Location = new System.Drawing.Point(301, 112);
            this.tfYearModelTruck.Name = "tfYearModelTruck";
            this.tfYearModelTruck.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfYearModelTruck.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.tfYearModelTruck.Properties.Mask.EditMask = "[0-9]{4}";
            this.tfYearModelTruck.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.tfYearModelTruck.Size = new System.Drawing.Size(270, 20);
            this.tfYearModelTruck.TabIndex = 8;
            // 
            // tfYearFabricationTruck
            // 
            this.tfYearFabricationTruck.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgTruck, "year_fabrication", true));
            this.tfYearFabricationTruck.Location = new System.Drawing.Point(70, 112);
            this.tfYearFabricationTruck.Name = "tfYearFabricationTruck";
            this.tfYearFabricationTruck.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfYearFabricationTruck.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.tfYearFabricationTruck.Properties.Mask.EditMask = "[0-9]{4}";
            this.tfYearFabricationTruck.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.tfYearFabricationTruck.Size = new System.Drawing.Size(181, 20);
            this.tfYearFabricationTruck.TabIndex = 7;
            // 
            // tfMarkTruck
            // 
            this.tfMarkTruck.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgTruck, "mark", true));
            this.tfMarkTruck.Location = new System.Drawing.Point(70, 60);
            this.tfMarkTruck.Name = "tfMarkTruck";
            this.tfMarkTruck.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfMarkTruck.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.tfMarkTruck.Properties.Mask.EditMask = "\\p{Lu}+";
            this.tfMarkTruck.Size = new System.Drawing.Size(181, 20);
            this.tfMarkTruck.TabIndex = 4;
            // 
            // tfChassiTruck
            // 
            this.tfChassiTruck.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgTruck, "chassi", true));
            this.tfChassiTruck.Location = new System.Drawing.Point(205, 6);
            this.tfChassiTruck.Name = "tfChassiTruck";
            this.tfChassiTruck.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfChassiTruck.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.tfChassiTruck.Properties.Mask.EditMask = "[A-Z0-9]+";
            this.tfChassiTruck.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.tfChassiTruck.Size = new System.Drawing.Size(270, 20);
            this.tfChassiTruck.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 35);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Renavam:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(7, 89);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(21, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Cor:";
            // 
            // tfBoardTruck
            // 
            this.tfBoardTruck.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgTruck, "board", true));
            this.tfBoardTruck.EditValue = "";
            this.tfBoardTruck.Location = new System.Drawing.Point(70, 6);
            this.tfBoardTruck.Name = "tfBoardTruck";
            this.tfBoardTruck.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfBoardTruck.Properties.Mask.EditMask = "[A-Z]{3}-[0-9]{4}";
            this.tfBoardTruck.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.tfBoardTruck.Size = new System.Drawing.Size(88, 20);
            this.tfBoardTruck.TabIndex = 0;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(257, 115);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(38, 13);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "Modelo:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(257, 63);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(38, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Modelo:";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(7, 145);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(49, 13);
            this.labelControl11.TabIndex = 0;
            this.labelControl11.Text = "Motorista:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(7, 115);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(56, 13);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Fabricação:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(257, 35);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(30, 13);
            this.labelControl10.TabIndex = 0;
            this.labelControl10.Text = "ANTT:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(164, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Chassi:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(7, 63);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(33, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Marca:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Placa:";
            // 
            // TruckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnGeneral);
            this.Controls.Add(this.pnButtons);
            this.Name = "TruckForm";
            this.Size = new System.Drawing.Size(585, 220);
            ((System.ComponentModel.ISupportInitialize)(this.pnButtons)).EndInit();
            this.pnButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnGeneral)).EndInit();
            this.pnGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnTruck)).EndInit();
            this.pnTruck.ResumeLayout(false);
            this.pnTruck.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbAntt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgTruck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgAntt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDriver.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgDriver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfIdTruck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfRenavamTruck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfColorTruck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfModelTruck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfYearModelTruck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfYearFabricationTruck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfMarkTruck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfChassiTruck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfBoardTruck.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnButtons;
        private WCButtons.Black.ButtonSaveBlack btnSave;
        private WCButtons.Black.ButtonCancelBlack btnCancel;
        private DevExpress.XtraEditors.PanelControl pnGeneral;
        private System.Windows.Forms.BindingSource bdgTruck;
        private System.Windows.Forms.BindingSource bdgDriver;
        private DevExpress.XtraEditors.PanelControl pnTruck;
        private DevExpress.XtraEditors.SimpleButton btnUpdateDrivers;
        private DevExpress.XtraEditors.SearchLookUpEdit cbDriver;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colfull_name;
        private DevExpress.XtraGrid.Columns.GridColumn colcpf;
        private DevExpress.XtraEditors.TextEdit tfIdTruck;
        private DevExpress.XtraEditors.TextEdit tfRenavamTruck;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit tfColorTruck;
        private DevExpress.XtraEditors.TextEdit tfModelTruck;
        private DevExpress.XtraEditors.TextEdit tfYearModelTruck;
        private DevExpress.XtraEditors.TextEdit tfYearFabricationTruck;
        private DevExpress.XtraEditors.TextEdit tfMarkTruck;
        private DevExpress.XtraEditors.TextEdit tfChassiTruck;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit tfBoardTruck;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private WCButtons.Black.ButtonFolderBlack btnFiles;
        private WCButtons.Black.ButtonAddBlack btnNew;
        private DevExpress.XtraEditors.SearchLookUpEdit cbAntt;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bdgAntt;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colrntrc;
        private DevExpress.XtraGrid.Columns.GridColumn colvalidation_date;
        private DevExpress.XtraGrid.Columns.GridColumn colcustomer_name;
        private DevExpress.XtraGrid.Columns.GridColumn colcustomer_cnpj;
    }
}
