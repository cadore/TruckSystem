﻿using System;
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
using TruckSystem.UI.Customer;

namespace TruckSystem.UI.SearchCNPJ
{
    public partial class SearchCNPJForm : TruckSystem.UI.Utils.UserControlUtil
    {
        public SearchCNPJForm()
        {
            InitializeComponent();
            bdgStates.DataSource = state.Fetch("ORDER BY symbol");
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
                        XtraMessageBox.Show("CNPJ já cadastrado, verifique!", "Cadore Tecnologia");
                        return;
                    }
                }
                SearchCPFCNPJUtil cc = new SearchCPFCNPJUtil();
                if (cc.Search(Document.CNPJ, tfCNPJ.Text))
                {
                    customer cre = new customer();
                    address d = new address();

                    cre.document = cc.NCNPJ;
                    if (cre.document.Length == 18)
                        cre.type = 0;
                    else
                        cre.type = 1;
                    cre.inactive = false;
                    cre.corporate_name = cc.RAZAOSOCIAL;
                    cre.fantasy_name = cc.FANTASIA;
                    d.name = cc.ENDERECO;
                    d.number = cc.NUMERO;
                    d.complement = cc.COMPLEMENTO;
                    d.district = cc.BAIRRO;
                    d.cep = cc.CEP;
                    state st = state.SingleOrDefault("WHERE symbol=@0", cc.UF);
                    Console.WriteLine(st.symbol);
                    d.state_id = st != null ? st.id : 0;
                    List<city> lci = city.Fetch("WHERE name ILIKE @0 AND state_id=@1", city.Concat(cc.CIDADE), st.id);
                    d.city_id = lci[0] != null ? lci[0].id : 0;

                    string[] f = cc.TELEFONE.Replace(" ", "").Split('/');
                    if (f.Length >= 1)
                        cre.phone_fixed = f[0];
                    if (f.Length >= 2)
                        cre.phone_mobile = f[1];

                    bdgAddress.DataSource = d;
                    bdgCustomer.DataSource = cre;
                    tfCNPJ.Properties.ReadOnly = true;
                    tfType.EditValue = cc.TIPO;
                    tfSituation.EditValue = cc.SITUACAOCNPJ;
                    tfDateOpening.EditValue = cc.ABERTURA;
                    tfCnae1.EditValue = cc.CNAE1;
                    tfCnae2.EditValue = cc.CNAE2;
                    tfJuridic.EditValue = cc.NATUREZA;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("Ocorreu um erro:\n\n{0}\n{1}", ex.Message, ex.InnerException));
            }
        }

        private void cbStateAddress_EditValueChanged(object sender, EventArgs e)
        {
            if (cbStateAddress.EditValue != null)
                bdgCity.DataSource = city.Fetch("WHERE state_id=@0", cbStateAddress.EditValue);
        }

        private void tfCNPJ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch_Click(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            desk.CloseCurrentTab();
        }

        private void btnOpenNew_Click(object sender, EventArgs e)
        {
            CustomerForm cf = new CustomerForm(null);
            cf.loadFromCnpj(((customer)bdgCustomer.Current), ((address)bdgAddress.Current));
            desk.AddTabAndCloseCurrent(cf, "Novo cliente", true);
        }
    }
}