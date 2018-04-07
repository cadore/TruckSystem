namespace TruckSystem.UI.Backup
{
    partial class ConfigBackupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigBackupForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new WCButtons.Black.ButtonCancelBlack();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.tfDateLastBackup = new DevExpress.XtraEditors.TextEdit();
            this.btnFindPathPG = new DevExpress.XtraEditors.SimpleButton();
            this.btnFindPathBackup = new DevExpress.XtraEditors.SimpleButton();
            this.tfPathPG = new DevExpress.XtraEditors.TextEdit();
            this.tfPathBackup = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfDateLastBackup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfPathPG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfPathBackup.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.xtraTabControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(657, 298);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnCancel);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(2, 252);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(653, 44);
            this.panelControl2.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(538, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 33);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Fechar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(2, 2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(653, 294);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.tfDateLastBackup);
            this.xtraTabPage1.Controls.Add(this.btnFindPathPG);
            this.xtraTabPage1.Controls.Add(this.btnFindPathBackup);
            this.xtraTabPage1.Controls.Add(this.tfPathPG);
            this.xtraTabPage1.Controls.Add(this.tfPathBackup);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(647, 266);
            this.xtraTabPage1.Text = "Diretórios";
            // 
            // tfDateLastBackup
            // 
            this.tfDateLastBackup.EditValue = "";
            this.tfDateLastBackup.Location = new System.Drawing.Point(9, 170);
            this.tfDateLastBackup.Name = "tfDateLastBackup";
            this.tfDateLastBackup.Properties.ReadOnly = true;
            this.tfDateLastBackup.Size = new System.Drawing.Size(545, 20);
            this.tfDateLastBackup.TabIndex = 4;
            // 
            // btnFindPathPG
            // 
            this.btnFindPathPG.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnFindPathPG.Location = new System.Drawing.Point(560, 97);
            this.btnFindPathPG.Name = "btnFindPathPG";
            this.btnFindPathPG.Size = new System.Drawing.Size(75, 23);
            this.btnFindPathPG.TabIndex = 3;
            this.btnFindPathPG.Text = "Escolher";
            this.btnFindPathPG.Click += new System.EventHandler(this.btnFindPathPG_Click);
            // 
            // btnFindPathBackup
            // 
            this.btnFindPathBackup.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnFindPathBackup.Location = new System.Drawing.Point(560, 35);
            this.btnFindPathBackup.Name = "btnFindPathBackup";
            this.btnFindPathBackup.Size = new System.Drawing.Size(75, 23);
            this.btnFindPathBackup.TabIndex = 3;
            this.btnFindPathBackup.Text = "Escolher";
            this.btnFindPathBackup.Click += new System.EventHandler(this.btnFindPathBackup_Click);
            // 
            // tfPathPG
            // 
            this.tfPathPG.Location = new System.Drawing.Point(9, 99);
            this.tfPathPG.Name = "tfPathPG";
            this.tfPathPG.Properties.ReadOnly = true;
            this.tfPathPG.Size = new System.Drawing.Size(545, 20);
            this.tfPathPG.TabIndex = 2;
            // 
            // tfPathBackup
            // 
            this.tfPathBackup.Location = new System.Drawing.Point(9, 37);
            this.tfPathBackup.Name = "tfPathBackup";
            this.tfPathBackup.Properties.ReadOnly = true;
            this.tfPathBackup.Size = new System.Drawing.Size(545, 20);
            this.tfPathBackup.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(9, 151);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(133, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Ultimo Backup realizado em:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(9, 80);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(141, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Diretório \'PgDump\' PostgreSql";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(149, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Diretório de Backup Secundário";
            // 
            // ConfigBackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 298);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "ConfigBackupForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configurações de Backup";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfDateLastBackup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfPathPG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfPathBackup.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.TextEdit tfPathBackup;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tfPathPG;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnFindPathPG;
        private DevExpress.XtraEditors.SimpleButton btnFindPathBackup;
        private WCButtons.Black.ButtonCancelBlack btnCancel;
        private DevExpress.XtraEditors.TextEdit tfDateLastBackup;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}