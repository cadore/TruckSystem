namespace TruckSystem.UI.Deposits
{
    partial class ViewDepositsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewDepositsForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bdgDeposits = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaccount_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcustomer_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltype = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltruck_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAdd = new FreeButtons.Buttons.iOS_Icons.Button_iOS_AddNew_24px();
            this.btnDelete = new FreeButtons.Buttons.iOS_Icons.Button_iOS_Delete_24px();
            this.btnConfirm = new FreeButtons.Buttons.iOS_Icons.Button_iOS_Confirm_24px();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgDeposits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnConfirm);
            this.panelControl1.Controls.Add(this.btnDelete);
            this.panelControl1.Controls.Add(this.btnAdd);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 272);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(896, 45);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(896, 272);
            this.panelControl2.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bdgDeposits;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(892, 268);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl_DoubleClick);
            // 
            // bdgDeposits
            // 
            this.bdgDeposits.DataSource = typeof(TruckSystem.deposits);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colaccount_id,
            this.colcustomer_id,
            this.coldate,
            this.colvalue,
            this.coldescription,
            this.coltype,
            this.coltruck_id});
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
            this.colid.Width = 38;
            // 
            // colaccount_id
            // 
            this.colaccount_id.Caption = "Conta";
            this.colaccount_id.FieldName = "account";
            this.colaccount_id.Name = "colaccount_id";
            this.colaccount_id.OptionsColumn.AllowEdit = false;
            this.colaccount_id.Visible = true;
            this.colaccount_id.VisibleIndex = 1;
            this.colaccount_id.Width = 129;
            // 
            // colcustomer_id
            // 
            this.colcustomer_id.Caption = "Local - Posto";
            this.colcustomer_id.FieldName = "customer_name";
            this.colcustomer_id.Name = "colcustomer_id";
            this.colcustomer_id.OptionsColumn.AllowEdit = false;
            this.colcustomer_id.Visible = true;
            this.colcustomer_id.VisibleIndex = 2;
            this.colcustomer_id.Width = 220;
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
            this.coldate.Width = 70;
            // 
            // colvalue
            // 
            this.colvalue.Caption = "Valor";
            this.colvalue.DisplayFormat.FormatString = "c2";
            this.colvalue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colvalue.FieldName = "value";
            this.colvalue.Name = "colvalue";
            this.colvalue.OptionsColumn.AllowEdit = false;
            this.colvalue.Visible = true;
            this.colvalue.VisibleIndex = 4;
            this.colvalue.Width = 77;
            // 
            // coldescription
            // 
            this.coldescription.Caption = "Descrição";
            this.coldescription.FieldName = "description";
            this.coldescription.Name = "coldescription";
            this.coldescription.OptionsColumn.AllowEdit = false;
            this.coldescription.Visible = true;
            this.coldescription.VisibleIndex = 5;
            this.coldescription.Width = 171;
            // 
            // coltype
            // 
            this.coltype.Caption = "Tipo";
            this.coltype.FieldName = "type_name";
            this.coltype.Name = "coltype";
            this.coltype.OptionsColumn.AllowEdit = false;
            this.coltype.Visible = true;
            this.coltype.VisibleIndex = 6;
            this.coltype.Width = 56;
            // 
            // coltruck_id
            // 
            this.coltruck_id.Caption = "Veículo";
            this.coltruck_id.FieldName = "truck_board";
            this.coltruck_id.Name = "coltruck_id";
            this.coltruck_id.OptionsColumn.AllowEdit = false;
            this.coltruck_id.Visible = true;
            this.coltruck_id.VisibleIndex = 7;
            this.coltruck_id.Width = 112;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(12, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 33);
            this.btnAdd.TabIndex = 1;
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
            this.btnDelete.Location = new System.Drawing.Point(128, 6);
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
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirm.Location = new System.Drawing.Point(774, 6);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(110, 33);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // ViewDepositsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 317);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ViewDepositsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Depósitos";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgDeposits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public System.Windows.Forms.BindingSource bdgDeposits;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colaccount_id;
        private DevExpress.XtraGrid.Columns.GridColumn colcustomer_id;
        private DevExpress.XtraGrid.Columns.GridColumn coldate;
        private DevExpress.XtraGrid.Columns.GridColumn colvalue;
        private DevExpress.XtraGrid.Columns.GridColumn coldescription;
        private DevExpress.XtraGrid.Columns.GridColumn coltype;
        private DevExpress.XtraGrid.Columns.GridColumn coltruck_id;
        private FreeButtons.Buttons.iOS_Icons.Button_iOS_Confirm_24px btnConfirm;
        private FreeButtons.Buttons.iOS_Icons.Button_iOS_Delete_24px btnDelete;
        private FreeButtons.Buttons.iOS_Icons.Button_iOS_AddNew_24px btnAdd;
    }
}