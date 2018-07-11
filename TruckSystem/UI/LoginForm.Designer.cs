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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.tfCPF = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pnLogin = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.tfPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.validator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.btnExit = new FreeButtons.Buttons.iOS_Icons.Button_iOS_Exit_32px();
            this.btnLogin = new FreeButtons.Buttons.iOS_Icons.Button_iOS_Login_32px();
            ((System.ComponentModel.ISupportInitialize)(this.tfCPF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnLogin)).BeginInit();
            this.pnLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).BeginInit();
            this.SuspendLayout();
            // 
            // tfCPF
            // 
            this.tfCPF.EditValue = "";
            this.tfCPF.Location = new System.Drawing.Point(12, 184);
            this.tfCPF.Name = "tfCPF";
            this.tfCPF.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfCPF.Properties.Appearance.Options.UseFont = true;
            this.tfCPF.Properties.Mask.EditMask = "000.000.000-00";
            this.tfCPF.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.tfCPF.Size = new System.Drawing.Size(298, 24);
            this.tfCPF.TabIndex = 0;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Informe o CPF para prosseguir";
            this.validator.SetValidationRule(this.tfCPF, conditionValidationRule3);
            this.tfCPF.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tfCPF_KeyUp);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 165);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(23, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "CPF:";
            // 
            // pnLogin
            // 
            this.pnLogin.Controls.Add(this.btnLogin);
            this.pnLogin.Controls.Add(this.btnExit);
            this.pnLogin.Controls.Add(this.pictureEdit1);
            this.pnLogin.Controls.Add(this.tfPassword);
            this.pnLogin.Controls.Add(this.labelControl2);
            this.pnLogin.Controls.Add(this.labelControl1);
            this.pnLogin.Controls.Add(this.tfCPF);
            this.pnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLogin.Location = new System.Drawing.Point(0, 0);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(322, 346);
            this.pnLogin.TabIndex = 3;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::TruckSystem.Properties.Resources.wjm;
            this.pictureEdit1.Location = new System.Drawing.Point(12, 7);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowMenu = false;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(298, 152);
            this.pictureEdit1.TabIndex = 4;
            // 
            // tfPassword
            // 
            this.tfPassword.Location = new System.Drawing.Point(12, 239);
            this.tfPassword.Name = "tfPassword";
            this.tfPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfPassword.Properties.Appearance.Options.UseFont = true;
            this.tfPassword.Properties.UseSystemPasswordChar = true;
            this.tfPassword.Size = new System.Drawing.Size(298, 24);
            this.tfPassword.TabIndex = 1;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Informe a Senha para prosseguir";
            this.validator.SetValidationRule(this.tfPassword, conditionValidationRule1);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 220);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Senha:";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(195, 282);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 52);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Sair";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(12, 282);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(115, 52);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 346);
            this.ControlBox = false;
            this.Controls.Add(this.pnLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(338, 173);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Truck System - Cadore Tecnologia";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tfCPF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnLogin)).EndInit();
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
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
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validator;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private FreeButtons.Buttons.iOS_Icons.Button_iOS_Exit_32px btnExit;
        private FreeButtons.Buttons.iOS_Icons.Button_iOS_Login_32px btnLogin;

    }
}