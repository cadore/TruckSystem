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

namespace TruckSystem.UI.Business
{
    public partial class FindNewBusiness : DevExpress.XtraEditors.XtraForm
    {
        public FindNewBusiness()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void tfName_EditValueChanged(object sender, EventArgs e)
        {
            if (tfName.Text.Trim().Length >= 3)
            {

                bdgBusiness.DataSource = customer.Fetch(String.Format("SELECT * FROM customers WHERE corporate_name ILIKE '{0}' AND is_business = FALSE" +
                                                                        " UNION SELECT * FROM customers WHERE fantasy_name ILIKE '{0}' AND is_business = FALSE",
                    customer.Concat(tfName.Text)));
            }
            else if (tfName.Text.Trim().Length == 0)
                bdgBusiness.DataSource = customer.Fetch("WHERE is_business = FALSE");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            customer c = (customer)bdgBusiness.Current;
            DialogResult dr = XtraMessageBox.Show(String.Format("Confirma adicionar/alterar {0} para o tipo Empresa Administradora?",
                c.corporate_name), "Confirmação", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
                return;

            DialogResult rs = XtraMessageBox.Show("Essa alteração não podera ser desfeita por nenhum administrador,"
                + " \napenas pela equipe técnica após analise do banco de dados.\nPodendo gerar custos adicionais!\n Deseja continuar?", 
                "Confirmação", MessageBoxButtons.YesNo);
            if (rs == DialogResult.No)
                return;

            if (!Singleton.autenticateAdmin())
                return;
            try
            {
                if (c == null)
                    return;

                antts a = antts.SingleOrDefault("WHERE customer_id = @0", c.id);
                if (a == null)
                {
                    XtraMessageBox.Show("CNPJ/CPF selecionado nao contem ANTT cadastrada, verifique!");
                    return;
                }

                c.is_business = true;
                c.Save();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Ocoreu um erro.\n\n" + ex.Message);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}