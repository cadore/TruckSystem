namespace TruckSystem.UI.BankAccounts
{
    partial class BankAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankAccountForm));
            TruckSystem.Utils.Validations.ValidatorCPFCNPJ validatorCPFCNPJ1 = new TruckSystem.Utils.Validations.ValidatorCPFCNPJ();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new WCButtons.Black.ButtonCancelBlack();
            this.btnSave = new WCButtons.Black.ButtonSaveBlack();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.rgType = new DevExpress.XtraEditors.RadioGroup();
            this.tfId = new DevExpress.XtraEditors.TextEdit();
            this.bdgBankAccount = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tfDocument = new DevExpress.XtraEditors.TextEdit();
            this.lbDocument = new DevExpress.XtraEditors.LabelControl();
            this.tfAccount = new DevExpress.XtraEditors.TextEdit();
            this.tfHolder = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.tfAgency = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tfNameBank = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tfNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.validator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgBankAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDocument.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfHolder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfAgency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfNameBank.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 178);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(597, 44);
            this.panelControl1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(487, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 33);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(371, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 33);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Salvar";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupControl2);
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(597, 178);
            this.panelControl2.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.rgType);
            this.groupControl2.Controls.Add(this.tfId);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.tfDocument);
            this.groupControl2.Controls.Add(this.lbDocument);
            this.groupControl2.Controls.Add(this.tfAccount);
            this.groupControl2.Controls.Add(this.tfHolder);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.tfAgency);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Location = new System.Drawing.Point(0, 62);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(604, 108);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Conta Bancária";
            // 
            // rgType
            // 
            this.rgType.Location = new System.Drawing.Point(58, 78);
            this.rgType.Name = "rgType";
            this.rgType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgType.Properties.Appearance.Options.UseBackColor = true;
            this.rgType.Properties.Columns = 2;
            this.rgType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("cnpj", "CNPJ"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("cpf", "CPF")});
            this.rgType.Size = new System.Drawing.Size(107, 25);
            this.rgType.TabIndex = 3;
            this.rgType.SelectedIndexChanged += new System.EventHandler(this.rgType_SelectedIndexChanged);
            // 
            // tfId
            // 
            this.tfId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgBankAccount, "id", true));
            this.tfId.Location = new System.Drawing.Point(537, 24);
            this.tfId.Name = "tfId";
            this.tfId.Properties.ReadOnly = true;
            this.tfId.Size = new System.Drawing.Size(60, 20);
            this.tfId.TabIndex = 1;
            this.tfId.TabStop = false;
            // 
            // bdgBankAccount
            // 
            this.bdgBankAccount.DataSource = typeof(TruckSystem.bank_account);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(504, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Cod.:";
            // 
            // tfDocument
            // 
            this.tfDocument.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgBankAccount, "document", true));
            this.tfDocument.Location = new System.Drawing.Point(221, 81);
            this.tfDocument.Name = "tfDocument";
            this.tfDocument.Properties.Mask.EditMask = "00.000.000/0000-00";
            this.tfDocument.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.tfDocument.Size = new System.Drawing.Size(376, 20);
            this.tfDocument.TabIndex = 4;
            validatorCPFCNPJ1.ErrorText = "O CNPJ/CPF é inválido";
            this.validator.SetValidationRule(this.tfDocument, validatorCPFCNPJ1);
            // 
            // lbDocument
            // 
            this.lbDocument.Location = new System.Drawing.Point(186, 84);
            this.lbDocument.Name = "lbDocument";
            this.lbDocument.Size = new System.Drawing.Size(29, 13);
            this.lbDocument.TabIndex = 3;
            this.lbDocument.Text = "CNPJ:";
            // 
            // tfAccount
            // 
            this.tfAccount.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgBankAccount, "account", true));
            this.tfAccount.Location = new System.Drawing.Point(186, 24);
            this.tfAccount.Name = "tfAccount";
            this.tfAccount.Size = new System.Drawing.Size(133, 20);
            this.tfAccount.TabIndex = 1;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Informe a Conta Bancária";
            this.validator.SetValidationRule(this.tfAccount, conditionValidationRule1);
            // 
            // tfHolder
            // 
            this.tfHolder.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgBankAccount, "holder", true));
            this.tfHolder.Location = new System.Drawing.Point(58, 50);
            this.tfHolder.Name = "tfHolder";
            this.tfHolder.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfHolder.Size = new System.Drawing.Size(539, 20);
            this.tfHolder.TabIndex = 2;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Informe o Titular";
            this.validator.SetValidationRule(this.tfHolder, conditionValidationRule2);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(146, 27);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(33, 13);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Conta:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(10, 84);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(24, 13);
            this.labelControl8.TabIndex = 3;
            this.labelControl8.Text = "Tipo:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(10, 53);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(34, 13);
            this.labelControl6.TabIndex = 3;
            this.labelControl6.Text = "Titular:";
            // 
            // tfAgency
            // 
            this.tfAgency.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgBankAccount, "agency", true));
            this.tfAgency.Location = new System.Drawing.Point(58, 24);
            this.tfAgency.Name = "tfAgency";
            this.tfAgency.Size = new System.Drawing.Size(70, 20);
            this.tfAgency.TabIndex = 0;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Informe a Agência";
            this.validator.SetValidationRule(this.tfAgency, conditionValidationRule3);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(10, 27);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Agencia:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tfNameBank);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.tfNumber);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(604, 56);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Banco";
            // 
            // tfNameBank
            // 
            this.tfNameBank.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgBankAccount, "name_bank", true));
            this.tfNameBank.Location = new System.Drawing.Point(168, 24);
            this.tfNameBank.Name = "tfNameBank";
            this.tfNameBank.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfNameBank.Size = new System.Drawing.Size(429, 20);
            this.tfNameBank.TabIndex = 1;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Informe o nome do Banco";
            this.validator.SetValidationRule(this.tfNameBank, conditionValidationRule4);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(134, 27);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Nome:";
            // 
            // tfNumber
            // 
            this.tfNumber.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgBankAccount, "number_bank", true));
            this.tfNumber.Location = new System.Drawing.Point(54, 24);
            this.tfNumber.Name = "tfNumber";
            this.tfNumber.Size = new System.Drawing.Size(70, 20);
            this.tfNumber.TabIndex = 0;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule5.ErrorText = "Informe o Numero do Banco";
            conditionValidationRule5.Value1 = 0;
            this.validator.SetValidationRule(this.tfNumber, conditionValidationRule5);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 27);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Numero:";
            // 
            // BankAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 222);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BankAccountForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Conta Bacária";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgBankAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDocument.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfHolder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfAgency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfNameBank.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private WCButtons.Black.ButtonSaveBlack btnSave;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private WCButtons.Black.ButtonCancelBlack btnCancel;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit tfNameBank;
        private DevExpress.XtraEditors.TextEdit tfNumber;
        private DevExpress.XtraEditors.TextEdit tfId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit tfAccount;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit tfAgency;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.RadioGroup rgType;
        private DevExpress.XtraEditors.TextEdit tfDocument;
        private DevExpress.XtraEditors.LabelControl lbDocument;
        private DevExpress.XtraEditors.TextEdit tfHolder;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.BindingSource bdgBankAccount;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validator;
        private TruckSystem.Utils.Validations.ValidatorCPFCNPJ validatorCPFCNPJ;
    }
}