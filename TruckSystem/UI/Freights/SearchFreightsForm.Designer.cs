namespace TruckSystem.UI.Freights
{
    partial class SearchFreightsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchFreightsForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSelect = new WCButtons.Black.ButtonConfirmBlack();
            this.btnCancel = new WCButtons.Black.ButtonCancelBlack();
            this.bdgFreights = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.tfEnd = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.tfStart = new DevExpress.XtraEditors.DateEdit();
            this.cbTruck = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdgTruck = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colboard = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tfNumberNote = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tfId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new WCButtons.Black.ButtonSearchBlack();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumber_note = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcompany_destination_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcompany_source_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colweight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalue_gross = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltruck_board = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldriver_name = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgFreights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTruck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgTruck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfNumberNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSelect);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 411);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1013, 43);
            this.panelControl1.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.Location = new System.Drawing.Point(778, 5);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(114, 33);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Selecionar";
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(898, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 33);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // bdgFreights
            // 
            this.bdgFreights.DataSource = typeof(TruckSystem.freight);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.tfEnd);
            this.panelControl3.Controls.Add(this.labelControl5);
            this.panelControl3.Controls.Add(this.tfStart);
            this.panelControl3.Controls.Add(this.cbTruck);
            this.panelControl3.Controls.Add(this.tfNumberNote);
            this.panelControl3.Controls.Add(this.labelControl4);
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Controls.Add(this.tfId);
            this.panelControl3.Controls.Add(this.labelControl3);
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Controls.Add(this.btnSearch);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1013, 42);
            this.panelControl3.TabIndex = 2;
            // 
            // tfEnd
            // 
            this.tfEnd.EditValue = null;
            this.tfEnd.Location = new System.Drawing.Point(608, 13);
            this.tfEnd.Name = "tfEnd";
            this.tfEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfEnd.Size = new System.Drawing.Size(100, 20);
            this.tfEnd.TabIndex = 8;
            this.tfEnd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_KeyDown);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(588, 16);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(6, 13);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "à";
            // 
            // tfStart
            // 
            this.tfStart.EditValue = null;
            this.tfStart.Location = new System.Drawing.Point(475, 13);
            this.tfStart.Name = "tfStart";
            this.tfStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfStart.Size = new System.Drawing.Size(100, 20);
            this.tfStart.TabIndex = 6;
            this.tfStart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_KeyDown);
            // 
            // cbTruck
            // 
            this.cbTruck.Location = new System.Drawing.Point(156, 13);
            this.cbTruck.Name = "cbTruck";
            this.cbTruck.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTruck.Properties.DataSource = this.bdgTruck;
            this.cbTruck.Properties.DisplayMember = "board";
            this.cbTruck.Properties.NullText = "";
            this.cbTruck.Properties.ValueMember = "id";
            this.cbTruck.Properties.View = this.searchLookUpEdit1View;
            this.cbTruck.Size = new System.Drawing.Size(100, 20);
            this.cbTruck.TabIndex = 5;
            this.cbTruck.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_KeyDown);
            // 
            // bdgTruck
            // 
            this.bdgTruck.DataSource = typeof(TruckSystem.truck);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colboard});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Cod.";
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 179;
            // 
            // colboard
            // 
            this.colboard.Caption = "Placa";
            this.colboard.FieldName = "board";
            this.colboard.Name = "colboard";
            this.colboard.OptionsColumn.AllowEdit = false;
            this.colboard.Visible = true;
            this.colboard.VisibleIndex = 1;
            this.colboard.Width = 899;
            // 
            // tfNumberNote
            // 
            this.tfNumberNote.Location = new System.Drawing.Point(295, 13);
            this.tfNumberNote.Name = "tfNumberNote";
            this.tfNumberNote.Properties.Mask.EditMask = "d";
            this.tfNumberNote.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tfNumberNote.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfNumberNote.Size = new System.Drawing.Size(90, 20);
            this.tfNumberNote.TabIndex = 4;
            this.tfNumberNote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_KeyDown);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(414, 16);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(55, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Período de:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(262, 16);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Nota:";
            // 
            // tfId
            // 
            this.tfId.Location = new System.Drawing.Point(38, 13);
            this.tfId.Name = "tfId";
            this.tfId.Properties.Mask.EditMask = "d";
            this.tfId.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tfId.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfId.Size = new System.Drawing.Size(55, 20);
            this.tfId.TabIndex = 2;
            this.tfId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_KeyDown);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(99, 16);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Caminhão:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Cod.:";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(898, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 33);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 42);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1013, 369);
            this.panelControl2.TabIndex = 3;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bdgFreights;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1009, 365);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.btnSelect_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colnumber_note,
            this.colcompany_destination_name,
            this.colcompany_source_name,
            this.colstart,
            this.colweight,
            this.colvalue_gross,
            this.coltotal,
            this.coltruck_board,
            this.coldriver_name});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colid
            // 
            this.colid.Caption = "Cod.";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 45;
            // 
            // colnumber_note
            // 
            this.colnumber_note.Caption = "Nota";
            this.colnumber_note.FieldName = "number_note";
            this.colnumber_note.Name = "colnumber_note";
            this.colnumber_note.OptionsColumn.AllowEdit = false;
            this.colnumber_note.Visible = true;
            this.colnumber_note.VisibleIndex = 2;
            this.colnumber_note.Width = 56;
            // 
            // colcompany_destination_name
            // 
            this.colcompany_destination_name.Caption = "Destino";
            this.colcompany_destination_name.FieldName = "company_destination_name";
            this.colcompany_destination_name.Name = "colcompany_destination_name";
            this.colcompany_destination_name.OptionsColumn.AllowEdit = false;
            this.colcompany_destination_name.Visible = true;
            this.colcompany_destination_name.VisibleIndex = 4;
            this.colcompany_destination_name.Width = 167;
            // 
            // colcompany_source_name
            // 
            this.colcompany_source_name.Caption = "Origem";
            this.colcompany_source_name.FieldName = "company_source_name";
            this.colcompany_source_name.Name = "colcompany_source_name";
            this.colcompany_source_name.OptionsColumn.AllowEdit = false;
            this.colcompany_source_name.Visible = true;
            this.colcompany_source_name.VisibleIndex = 3;
            this.colcompany_source_name.Width = 167;
            // 
            // colstart
            // 
            this.colstart.Caption = "Inicio";
            this.colstart.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colstart.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colstart.FieldName = "start";
            this.colstart.Name = "colstart";
            this.colstart.OptionsColumn.AllowEdit = false;
            this.colstart.Visible = true;
            this.colstart.VisibleIndex = 5;
            this.colstart.Width = 69;
            // 
            // colweight
            // 
            this.colweight.Caption = "Peso";
            this.colweight.DisplayFormat.FormatString = "n2";
            this.colweight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colweight.FieldName = "weight";
            this.colweight.Name = "colweight";
            this.colweight.OptionsColumn.AllowEdit = false;
            this.colweight.Visible = true;
            this.colweight.VisibleIndex = 6;
            this.colweight.Width = 64;
            // 
            // colvalue_gross
            // 
            this.colvalue_gross.Caption = "Bruto R$";
            this.colvalue_gross.DisplayFormat.FormatString = "{0:c2}";
            this.colvalue_gross.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colvalue_gross.FieldName = "value_gross";
            this.colvalue_gross.Name = "colvalue_gross";
            this.colvalue_gross.OptionsColumn.AllowEdit = false;
            this.colvalue_gross.Visible = true;
            this.colvalue_gross.VisibleIndex = 7;
            this.colvalue_gross.Width = 84;
            // 
            // coltotal
            // 
            this.coltotal.Caption = "Liquido R$";
            this.coltotal.DisplayFormat.FormatString = "c2";
            this.coltotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal.FieldName = "total";
            this.coltotal.Name = "coltotal";
            this.coltotal.OptionsColumn.AllowEdit = false;
            this.coltotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total", "{0:c2}")});
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 8;
            this.coltotal.Width = 82;
            // 
            // coltruck_board
            // 
            this.coltruck_board.Caption = "Caminhão";
            this.coltruck_board.FieldName = "truck_board";
            this.coltruck_board.Name = "coltruck_board";
            this.coltruck_board.OptionsColumn.AllowEdit = false;
            this.coltruck_board.Visible = true;
            this.coltruck_board.VisibleIndex = 1;
            this.coltruck_board.Width = 63;
            // 
            // coldriver_name
            // 
            this.coldriver_name.Caption = "Motorista";
            this.coldriver_name.FieldName = "driver_name";
            this.coldriver_name.Name = "coldriver_name";
            this.coldriver_name.OptionsColumn.AllowEdit = false;
            this.coldriver_name.Visible = true;
            this.coldriver_name.VisibleIndex = 9;
            this.coldriver_name.Width = 194;
            // 
            // SearchFreightsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl1);
            this.Name = "SearchFreightsForm";
            this.Size = new System.Drawing.Size(1013, 454);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdgFreights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTruck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgTruck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfNumberNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private WCButtons.Black.ButtonConfirmBlack btnSelect;
        private WCButtons.Black.ButtonCancelBlack btnCancel;
        private System.Windows.Forms.BindingSource bdgFreights;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private WCButtons.Black.ButtonSearchBlack btnSearch;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colnumber_note;
        private DevExpress.XtraGrid.Columns.GridColumn colstart;
        private DevExpress.XtraGrid.Columns.GridColumn colweight;
        private DevExpress.XtraGrid.Columns.GridColumn colcompany_destination_name;
        private DevExpress.XtraGrid.Columns.GridColumn colcompany_source_name;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraGrid.Columns.GridColumn coltruck_board;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tfId;
        private DevExpress.XtraEditors.TextEdit tfNumberNote;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SearchLookUpEdit cbTruck;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.DateEdit tfEnd;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit tfStart;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.BindingSource bdgTruck;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colboard;
        private DevExpress.XtraGrid.Columns.GridColumn coldriver_name;
        private DevExpress.XtraGrid.Columns.GridColumn colvalue_gross;
    }
}
