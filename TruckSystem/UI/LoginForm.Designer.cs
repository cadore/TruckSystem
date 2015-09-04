namespace TruckSystem.UI
{
    partial class LoginForm
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.tfCPF = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pnLogin = new DevExpress.XtraEditors.PanelControl();
            this.btnLogin = new WCButtons.Black.ButtonConfirmBlack();
            this.btnExit = new WCButtons.Black.ButtonCancelBlack();
            this.tfPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.validator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tfCPF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnLogin)).BeginInit();
            this.pnLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).BeginInit();
            this.SuspendLayout();
            // 
            // tfCPF
            // 
            this.tfCPF.EditValue = "";
            this.tfCPF.Location = new System.Drawing.Point(60, 16);
            this.tfCPF.Name = "tfCPF";
            this.tfCPF.Properties.Mask.EditMask = "000.000.000-00";
            this.tfCPF.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.tfCPF.Size = new System.Drawing.Size(241, 20);
            this.tfCPF.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Informe o CPF para prosseguir";
            this.validator.SetValidationRule(this.tfCPF, conditionValidationRule1);
            this.tfCPF.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tfCPF_KeyUp);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(20, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(23, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "CPF:";
            // 
            // pnLogin
            // 
            this.pnLogin.Controls.Add(this.btnLogin);
            this.pnLogin.Controls.Add(this.btnExit);
            this.pnLogin.Controls.Add(this.tfPassword);
            this.pnLogin.Controls.Add(this.labelControl2);
            this.pnLogin.Controls.Add(this.labelControl1);
            this.pnLogin.Controls.Add(this.tfCPF);
            this.pnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLogin.Location = new System.Drawing.Point(0, 0);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(322, 135);
            this.pnLogin.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(20, 92);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(110, 33);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(191, 92);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 33);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Sair";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tfPassword
            // 
            this.tfPassword.Location = new System.Drawing.Point(60, 52);
            this.tfPassword.Name = "tfPassword";
            this.tfPassword.Properties.UseSystemPasswordChar = true;
            this.tfPassword.Size = new System.Drawing.Size(241, 20);
            this.tfPassword.TabIndex = 1;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Informe a Senha para prosseguir";
            this.validator.SetValidationRule(this.tfPassword, conditionValidationRule2);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(20, 55);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Senha:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 135);
            this.ControlBox = false;
            this.Controls.Add(this.pnLogin);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(338, 174);
            this.MinimumSize = new System.Drawing.Size(338, 174);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Truck System - Cadore Tecnologia";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tfCPF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnLogin)).EndInit();
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit tfCPF;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl pnLogin;
        private DevExpress.XtraEditors.TextEdit tfPassword;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private WCButtons.Black.ButtonConfirmBlack btnLogin;
        private WCButtons.Black.ButtonCancelBlack btnExit;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validator;

    }
}