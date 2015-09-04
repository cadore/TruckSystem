namespace TruckSystem.UI.Utils
{
    partial class InputMessageForm
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
            this.tfValue = new DevExpress.XtraEditors.TextEdit();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.pnPrincipal = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.tfValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnPrincipal)).BeginInit();
            this.pnPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tfValue
            // 
            this.tfValue.Location = new System.Drawing.Point(12, 33);
            this.tfValue.Name = "tfValue";
            this.tfValue.Size = new System.Drawing.Size(310, 20);
            this.tfValue.TabIndex = 1;
            this.tfValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tfValue_KeyDown);
            // 
            // btnOK
            // 
            this.btnOK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnOK.Location = new System.Drawing.Point(78, 59);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 25);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "Confirmar";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnCancel.Location = new System.Drawing.Point(164, 59);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 25);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.Controls.Add(this.tfValue);
            this.pnPrincipal.Controls.Add(this.btnCancel);
            this.pnPrincipal.Controls.Add(this.btnOK);
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(332, 93);
            this.pnPrincipal.TabIndex = 3;
            this.pnPrincipal.Text = "Caption";
            // 
            // InputMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 93);
            this.ControlBox = false;
            this.Controls.Add(this.pnPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InputMessageForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.tfValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnPrincipal)).EndInit();
            this.pnPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit tfValue;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.GroupControl pnPrincipal;

    }
}