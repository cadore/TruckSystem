namespace TruckSystem.UI.Freights.Fueled
{
    partial class ViewFueledsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewFueledsForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnAdd = new WCButtons.Black.ButtonAddBlack();
            this.btnRemove = new WCButtons.Black.ButtonDeleteBlack();
            this.btnConfirm = new WCButtons.Black.ButtonConfirmBlack();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bdgFueleds = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfreight_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colliters = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalue_liters = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgas_station_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgFueleds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnAdd);
            this.panelControl1.Controls.Add(this.btnRemove);
            this.panelControl1.Controls.Add(this.btnConfirm);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 276);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(875, 43);
            this.panelControl1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(5, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 33);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(121, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(110, 33);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remover";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirm.Location = new System.Drawing.Point(760, 5);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(114, 33);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Concluido";
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(875, 276);
            this.panelControl2.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bdgFueleds;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(871, 272);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdgFueleds
            // 
            this.bdgFueleds.DataSource = typeof(TruckSystem.fueled);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colfreight_id,
            this.coldate,
            this.colkm,
            this.colliters,
            this.colvalue_liters,
            this.coldiscount,
            this.colgas_station_name,
            this.coltotal});
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
            this.colid.Width = 37;
            // 
            // colfreight_id
            // 
            this.colfreight_id.Caption = "Frete";
            this.colfreight_id.FieldName = "freight_id";
            this.colfreight_id.Name = "colfreight_id";
            this.colfreight_id.OptionsColumn.AllowEdit = false;
            this.colfreight_id.Visible = true;
            this.colfreight_id.VisibleIndex = 1;
            this.colfreight_id.Width = 49;
            // 
            // coldate
            // 
            this.coldate.Caption = "Data";
            this.coldate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.coldate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.coldate.FieldName = "date";
            this.coldate.Name = "coldate";
            this.coldate.OptionsColumn.AllowEdit = false;
            this.coldate.Visible = true;
            this.coldate.VisibleIndex = 3;
            this.coldate.Width = 71;
            // 
            // colkm
            // 
            this.colkm.Caption = "KM";
            this.colkm.FieldName = "km";
            this.colkm.Name = "colkm";
            this.colkm.OptionsColumn.AllowEdit = false;
            this.colkm.Visible = true;
            this.colkm.VisibleIndex = 4;
            this.colkm.Width = 97;
            // 
            // colliters
            // 
            this.colliters.Caption = "Litros";
            this.colliters.DisplayFormat.FormatString = "n2";
            this.colliters.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colliters.FieldName = "liters";
            this.colliters.Name = "colliters";
            this.colliters.OptionsColumn.AllowEdit = false;
            this.colliters.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "liters", "{0:c2}")});
            this.colliters.Visible = true;
            this.colliters.VisibleIndex = 5;
            this.colliters.Width = 94;
            // 
            // colvalue_liters
            // 
            this.colvalue_liters.Caption = "R$ p/ Litro";
            this.colvalue_liters.DisplayFormat.FormatString = "c3";
            this.colvalue_liters.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colvalue_liters.FieldName = "value_liters";
            this.colvalue_liters.Name = "colvalue_liters";
            this.colvalue_liters.OptionsColumn.AllowEdit = false;
            this.colvalue_liters.Visible = true;
            this.colvalue_liters.VisibleIndex = 6;
            this.colvalue_liters.Width = 82;
            // 
            // coldiscount
            // 
            this.coldiscount.Caption = "R$ Desconto";
            this.coldiscount.DisplayFormat.FormatString = "c2";
            this.coldiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldiscount.FieldName = "discount";
            this.coldiscount.Name = "coldiscount";
            this.coldiscount.OptionsColumn.AllowEdit = false;
            this.coldiscount.Visible = true;
            this.coldiscount.VisibleIndex = 7;
            this.coldiscount.Width = 97;
            // 
            // colgas_station_name
            // 
            this.colgas_station_name.Caption = "Posto";
            this.colgas_station_name.FieldName = "gas_station_name";
            this.colgas_station_name.Name = "colgas_station_name";
            this.colgas_station_name.OptionsColumn.AllowEdit = false;
            this.colgas_station_name.Visible = true;
            this.colgas_station_name.VisibleIndex = 2;
            this.colgas_station_name.Width = 244;
            // 
            // coltotal
            // 
            this.coltotal.Caption = "R$ Total";
            this.coltotal.DisplayFormat.FormatString = "c2";
            this.coltotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal.FieldName = "total";
            this.coltotal.Name = "coltotal";
            this.coltotal.OptionsColumn.AllowEdit = false;
            this.coltotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total", "{0:c2}")});
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 8;
            this.coltotal.Width = 116;
            // 
            // ViewFueledsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 319);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ViewFueledsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Visualização de Abastecidas";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgFueleds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private WCButtons.Black.ButtonDeleteBlack btnRemove;
        private WCButtons.Black.ButtonConfirmBlack btnConfirm;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colfreight_id;
        private DevExpress.XtraGrid.Columns.GridColumn coldate;
        private DevExpress.XtraGrid.Columns.GridColumn colkm;
        private DevExpress.XtraGrid.Columns.GridColumn colliters;
        private DevExpress.XtraGrid.Columns.GridColumn colvalue_liters;
        private DevExpress.XtraGrid.Columns.GridColumn coldiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colgas_station_name;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private WCButtons.Black.ButtonAddBlack btnAdd;
        public System.Windows.Forms.BindingSource bdgFueleds;
    }
}