namespace TruckSystem.UI.Freights.Outputs
{
    partial class ViewOutputsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOutputsForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnAdd = new FreeButtons.Buttons.iOS_Icons.Button_iOS_AddNew_24px();
            this.btnDelete = new FreeButtons.Buttons.iOS_Icons.Button_iOS_Delete_24px();
            this.btnConfirm = new FreeButtons.Buttons.iOS_Icons.Button_iOS_Confirm_24px();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.outputGridControl = new DevExpress.XtraGrid.GridControl();
            this.bdgOutputs = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcustomer_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colothers_outputs = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgOutputs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnAdd);
            this.panelControl1.Controls.Add(this.btnDelete);
            this.panelControl1.Controls.Add(this.btnConfirm);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 263);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(773, 45);
            this.panelControl1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(12, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 33);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(128, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 33);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Remover";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirm.Location = new System.Drawing.Point(652, 5);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(110, 33);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.outputGridControl);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(773, 263);
            this.panelControl2.TabIndex = 1;
            // 
            // outputGridControl
            // 
            this.outputGridControl.DataSource = this.bdgOutputs;
            this.outputGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputGridControl.Location = new System.Drawing.Point(2, 2);
            this.outputGridControl.MainView = this.gridView1;
            this.outputGridControl.Name = "outputGridControl";
            this.outputGridControl.Size = new System.Drawing.Size(769, 259);
            this.outputGridControl.TabIndex = 0;
            this.outputGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdgOutputs
            // 
            this.bdgOutputs.DataSource = typeof(TruckSystem.output);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescription,
            this.colcustomer_name,
            this.coldate,
            this.colvalue,
            this.colothers_outputs});
            this.gridView1.GridControl = this.outputGridControl;
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
            this.colid.Width = 49;
            // 
            // coldescription
            // 
            this.coldescription.Caption = "Descrição";
            this.coldescription.FieldName = "description";
            this.coldescription.Name = "coldescription";
            this.coldescription.OptionsColumn.AllowEdit = false;
            this.coldescription.Visible = true;
            this.coldescription.VisibleIndex = 2;
            this.coldescription.Width = 203;
            // 
            // colcustomer_name
            // 
            this.colcustomer_name.Caption = "Prestador";
            this.colcustomer_name.FieldName = "customer_name";
            this.colcustomer_name.Name = "colcustomer_name";
            this.colcustomer_name.OptionsColumn.AllowEdit = false;
            this.colcustomer_name.Visible = true;
            this.colcustomer_name.VisibleIndex = 3;
            this.colcustomer_name.Width = 197;
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
            this.coldate.VisibleIndex = 1;
            this.coldate.Width = 77;
            // 
            // colvalue
            // 
            this.colvalue.Caption = "R$ Valor";
            this.colvalue.DisplayFormat.FormatString = "c2";
            this.colvalue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colvalue.FieldName = "value";
            this.colvalue.Name = "colvalue";
            this.colvalue.OptionsColumn.AllowEdit = false;
            this.colvalue.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "value", "{0:c2}")});
            this.colvalue.Visible = true;
            this.colvalue.VisibleIndex = 4;
            this.colvalue.Width = 127;
            // 
            // colothers_outputs
            // 
            this.colothers_outputs.Caption = "Outras";
            this.colothers_outputs.FieldName = "others_outputs";
            this.colothers_outputs.Name = "colothers_outputs";
            this.colothers_outputs.OptionsColumn.AllowEdit = false;
            this.colothers_outputs.Visible = true;
            this.colothers_outputs.VisibleIndex = 5;
            this.colothers_outputs.Width = 87;
            // 
            // ViewOutputsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 308);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ViewOutputsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Visualização de Despesas do Frete";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.outputGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgOutputs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl outputGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescription;
        private DevExpress.XtraGrid.Columns.GridColumn colcustomer_name;
        private DevExpress.XtraGrid.Columns.GridColumn coldate;
        private DevExpress.XtraGrid.Columns.GridColumn colvalue;
        public System.Windows.Forms.BindingSource bdgOutputs;
        private FreeButtons.Buttons.iOS_Icons.Button_iOS_Confirm_24px btnConfirm;
        private FreeButtons.Buttons.iOS_Icons.Button_iOS_Delete_24px btnDelete;
        private FreeButtons.Buttons.iOS_Icons.Button_iOS_AddNew_24px btnAdd;
        private DevExpress.XtraGrid.Columns.GridColumn colothers_outputs;
    }
}