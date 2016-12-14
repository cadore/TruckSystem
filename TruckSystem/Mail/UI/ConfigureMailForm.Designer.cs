namespace TruckSystem.Mail.UI
{
    partial class ConfigureMailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigureMailForm));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnViewSignature = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new WCButtons.Black.ButtonSaveBlack();
            this.btnCancel = new WCButtons.Black.ButtonCancelBlack();
            this.tfSignature = new DevExpress.XtraEditors.MemoEdit();
            this.bdgMail = new System.Windows.Forms.BindingSource(this.components);
            this.ckSSL = new DevExpress.XtraEditors.CheckEdit();
            this.tfPort = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.tfPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tfUser = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tfSmtp = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.validator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfSignature.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckSSL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfPort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfSmtp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnViewSignature);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.btnCancel);
            this.groupControl1.Controls.Add(this.tfSignature);
            this.groupControl1.Controls.Add(this.ckSSL);
            this.groupControl1.Controls.Add(this.tfPort);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.tfPassword);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.tfUser);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.tfSmtp);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(522, 380);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Configurações de email";
            // 
            // btnViewSignature
            // 
            this.btnViewSignature.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnViewSignature.Location = new System.Drawing.Point(12, 314);
            this.btnViewSignature.Name = "btnViewSignature";
            this.btnViewSignature.Size = new System.Drawing.Size(112, 23);
            this.btnViewSignature.TabIndex = 6;
            this.btnViewSignature.Text = "Visualizar Assinatura";
            this.btnViewSignature.Click += new System.EventHandler(this.btnViewSignature_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(296, 349);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 33);
            this.btnSave.TabIndex = 7;
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
            this.btnCancel.Location = new System.Drawing.Point(412, 349);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 33);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tfSignature
            // 
            this.tfSignature.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgMail, "signature", true));
            this.tfSignature.Location = new System.Drawing.Point(12, 154);
            this.tfSignature.Name = "tfSignature";
            this.tfSignature.Size = new System.Drawing.Size(510, 154);
            this.tfSignature.TabIndex = 5;
            this.tfSignature.UseOptimizedRendering = true;
            this.tfSignature.EditValueChanged += new System.EventHandler(this.tfSignature_EditValueChanged);
            // 
            // bdgMail
            // 
            this.bdgMail.DataSource = typeof(TruckSystem.mails);
            // 
            // ckSSL
            // 
            this.ckSSL.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgMail, "ssl", true));
            this.ckSSL.Location = new System.Drawing.Point(91, 106);
            this.ckSSL.Name = "ckSSL";
            this.ckSSL.Properties.Caption = "SSL/TLS";
            this.ckSSL.Size = new System.Drawing.Size(76, 15);
            this.ckSSL.TabIndex = 4;
            // 
            // tfPort
            // 
            this.tfPort.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgMail, "port", true));
            this.tfPort.Location = new System.Drawing.Point(468, 26);
            this.tfPort.Name = "tfPort";
            this.tfPort.Properties.Mask.EditMask = "d";
            this.tfPort.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tfPort.Size = new System.Drawing.Size(54, 20);
            this.tfPort.TabIndex = 1;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule1.ErrorText = "Informe a Porta";
            conditionValidationRule1.Value1 = 0;
            this.validator.SetValidationRule(this.tfPort, conditionValidationRule1);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(432, 29);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Porta:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 135);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(92, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Assinatura (HTML):";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 107);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Encriptação:";
            // 
            // tfPassword
            // 
            this.tfPassword.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgMail, "password", true));
            this.tfPassword.Location = new System.Drawing.Point(91, 78);
            this.tfPassword.Name = "tfPassword";
            this.tfPassword.Size = new System.Drawing.Size(335, 20);
            this.tfPassword.TabIndex = 3;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Informe a Senha";
            this.validator.SetValidationRule(this.tfPassword, conditionValidationRule2);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 81);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Senha:";
            // 
            // tfUser
            // 
            this.tfUser.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgMail, "user", true));
            this.tfUser.Location = new System.Drawing.Point(91, 52);
            this.tfUser.Name = "tfUser";
            this.tfUser.Size = new System.Drawing.Size(335, 20);
            this.tfUser.TabIndex = 2;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Informe o usuário";
            this.validator.SetValidationRule(this.tfUser, conditionValidationRule3);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 55);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Usuário:";
            // 
            // tfSmtp
            // 
            this.tfSmtp.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgMail, "smtp_server", true));
            this.tfSmtp.Location = new System.Drawing.Point(91, 26);
            this.tfSmtp.Name = "tfSmtp";
            this.tfSmtp.Size = new System.Drawing.Size(335, 20);
            this.tfSmtp.TabIndex = 0;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Informe o endereço do servidor SMTP";
            this.validator.SetValidationRule(this.tfSmtp, conditionValidationRule4);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Servidor SMTP:";
            // 
            // ConfigureMailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 380);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "ConfigureMailForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfSignature.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckSSL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfPort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfSmtp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tfSmtp;
        private DevExpress.XtraEditors.TextEdit tfPort;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit tfPassword;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tfUser;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.CheckEdit ckSSL;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.MemoEdit tfSignature;
        private WCButtons.Black.ButtonSaveBlack btnSave;
        private WCButtons.Black.ButtonCancelBlack btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnViewSignature;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validator;
        private System.Windows.Forms.BindingSource bdgMail;
    }
}