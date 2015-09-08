using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TruckSystem.Utils.CPFCNPJ;

namespace TruckSystem.UI.SearchCNPJ
{
    public partial class SearchCNPJForm : TruckSystem.UI.Utils.UserControlUtil
    {
        public SearchCNPJForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!validator.Validate())
                return;
            try
            {
                //validações
                var countcnpj = customer.repo.ExecuteScalar<string>("SELECT COUNT(id) FROM customers WHERE document=@0",
                    tfCNPJ.EditValue);
                if (!countcnpj.Equals(DBNull.Value) && !String.IsNullOrEmpty(countcnpj))
                {
                    if (Convert.ToInt32(countcnpj) >= 1)
                    {
                        XtraMessageBox.Show("CNPJ já consta cadastrado!", "Cadore Tecnologia");
                        return;
                    }
                }
                SearchCPFCNPJUtil cc = new SearchCPFCNPJUtil();
                if (cc.Search(Document.CNPJ, tfCNPJ.Text))
                {
                    customer cre = new customer();
                    address d = new address();

                    cre.document = cc.NCNPJ;
                    cre.corporate_name = cc.RAZAOSOCIAL;
                    cre.fantasy_name = cc.FANTASIA;
                    d.name = cc.ENDERECO;
                    d.number = cc.NUMERO;
                    d.complement = cc.COMPLEMENTO;
                    d.district = cc.BAIRRO;
                    d.cep = cc.CEP;
                    state st = state.SingleOrDefault("WHERE symbol=@0", cc.UF);
                    d.state_id = st != null ? st.id : 0;
                    List<city> lci = city.Fetch("WHERE name ILIKE @0 AND state_id=@1", city.Concat(cc.CIDADE), st.id);
                    d.city_id = lci[0] != null ? lci[0].id : 0;

                    string[] f = cc.TELEFONE.Replace(" ", "").Split('/');
                    if (f.Length >= 1)
                        cre.phone_fixed = f[0];
                    if (f.Length >= 2)
                        cre.phone_mobile = f[1];

                    /*bdgAddress.DataSource = d;
                    bdgCredentialed.DataSource = cre;*/
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("Ocorreu um erro:\n\n{0}\n{1}", ex.Message, ex.InnerException));
            }
        }
    }
}
