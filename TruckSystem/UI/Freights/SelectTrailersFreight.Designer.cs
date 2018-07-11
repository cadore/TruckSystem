namespace TruckSystem.UI.Freights
{
    partial class SelectTrailersFreight
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tfSearch = new DevExpress.XtraEditors.TextEdit();
            this.listBox = new DevExpress.XtraEditors.ListBoxControl();
            this.listBoxSelected = new DevExpress.XtraEditors.ListBoxControl();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.bdgSelectedTrailes = new System.Windows.Forms.BindingSource(this.components);
            this.bdgTrailes = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tfSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSelectedTrailes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgTrailes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(208, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Escolha os Reboques para vincular ao frete";
            // 
            // tfSearch
            // 
            this.tfSearch.Location = new System.Drawing.Point(12, 51);
            this.tfSearch.Name = "tfSearch";
            this.tfSearch.Size = new System.Drawing.Size(127, 20);
            this.tfSearch.TabIndex = 3;
            this.tfSearch.EditValueChanged += new System.EventHandler(this.tfSearch_EditValueChanged);
            // 
            // listBox
            // 
            this.listBox.DataSource = this.bdgTrailes;
            this.listBox.DisplayMember = "board";
            this.listBox.HorizontalScrollbar = true;
            this.listBox.Location = new System.Drawing.Point(12, 77);
            this.listBox.MultiColumn = true;
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(266, 123);
            this.listBox.TabIndex = 4;
            this.listBox.ValueMember = "id";
            // 
            // listBoxSelected
            // 
            this.listBoxSelected.DataSource = this.bdgSelectedTrailes;
            this.listBoxSelected.DisplayMember = "board";
            this.listBoxSelected.Location = new System.Drawing.Point(380, 77);
            this.listBoxSelected.Name = "listBoxSelected";
            this.listBoxSelected.Size = new System.Drawing.Size(266, 123);
            this.listBoxSelected.TabIndex = 5;
            this.listBoxSelected.ValueMember = "id";
            // 
            // btnRemove
            // 
            this.btnRemove.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnRemove.Location = new System.Drawing.Point(297, 139);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(65, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "<";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAdd.Location = new System.Drawing.Point(297, 110);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = ">";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 212);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(650, 41);
            this.panelControl1.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnSave.Location = new System.Drawing.Point(463, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 31);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Salvar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnCancel.Location = new System.Drawing.Point(561, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 31);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // bdgSelectedTrailes
            // 
            this.bdgSelectedTrailes.DataSource = typeof(TruckSystem.trailer);
            // 
            // bdgTrailes
            // 
            this.bdgTrailes.DataSource = typeof(TruckSystem.trailer);
            // 
            // SelectTrailersFreight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 253);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.listBoxSelected);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.tfSearch);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SelectTrailersFreight";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Escolha de reboques";
            ((System.ComponentModel.ISupportInitialize)(this.tfSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdgSelectedTrailes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgTrailes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource bdgTrailes;
        private DevExpress.XtraEditors.TextEdit tfSearch;
        private DevExpress.XtraEditors.ListBoxControl listBox;
        private DevExpress.XtraEditors.ListBoxControl listBoxSelected;
        private System.Windows.Forms.BindingSource bdgSelectedTrailes;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}