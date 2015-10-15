using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TruckSystem.UI.Category
{
    public partial class NewCategoryForm : DevExpress.XtraEditors.XtraForm
    {
        category.Categorys CategoryT;
        public NewCategoryForm(category.Categorys ct)
        {
            InitializeComponent();
            CategoryT = ct;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validator.Validate())
                return;

            try
            {
                category c = new category()
                {
                    name = tfCategoryName.EditValue.ToString(),
                    type = (int)CategoryT
                };
                c.Save();
                this.DialogResult = DialogResult.OK;
                XtraMessageBox.Show("Categoria cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                this.DialogResult = DialogResult.Cancel;
                XtraMessageBox.Show(String.Format("Ocorreu um erro:\n\n{0}\n{1}", ex.Message, ex.InnerException));
            }            
            this.Close();
        }

        private void NewCategoryForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSave_Click(sender, e);
            else if (e.KeyCode == Keys.Escape)
                btnCancel_Click(sender, e);
        }
    }
}