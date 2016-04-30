using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TruckSystem.Utils;
using Receipt;
using TruckSystem.UI.Category;
using DevExpress.XtraSplashScreen;
using TruckSystem.UI.SplashScreens;

namespace TruckSystem.UI.AccountsToPay
{
    public partial class AccountsToPayForm : TruckSystem.UI.Utils.UserControlUtil
    {
        public AccountsToPayForm(accounts_to_pay atp)
        {
            InitializeComponent();
            ControlsUtil.SetBackColor(this.Controls);
            if (atp == null)
            {
                atp = new accounts_to_pay() { emission_at = null };
                IsNew = true;
            }
            loadData();
            bdgAccountToPay.DataSource = atp;
            EmissionAt(atp.emission_at);                
        }

        private void loadData()
        {
            bdgCustomer.DataSource = customer.Fetch("ORDER BY corporate_name");
            bdgCategory.DataSource = category.Fetch("WHERE type=@0 ORDER BY name", (int)category.Categorys.Payment);
            bdgTruck.DataSource = truck.Fetch("");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            desk.CloseCurrentTab();
        }

        private void Focus(object sender, EventArgs e)
        {
            TextEdit tf = (TextEdit)sender;
            tf.SelectAll();
            tf.Focus();
        }

        private void tfValueTotal_EditValueChanged(object sender, EventArgs e)
        {
            if (ToDecimal(tfValueTotal.EditValue) > 0)
                tabPayment.PageEnabled = true;
            else
                tabPayment.PageEnabled = false;
        }

        private void CalcValueNote(object sender, EventArgs e)
        {
            decimal v_products = ToDecimal(tfValueProducts.EditValue);
            decimal v_freight = ToDecimal(tfValueFreight.EditValue);
            decimal v_security = ToDecimal(tfValueSegurity.EditValue);
            decimal v_ipi = ToDecimal(tfValueIPI.EditValue);
            decimal v_discount = ToDecimal(tfValueDiscount.EditValue);
            decimal soma = v_products + v_freight + v_security + v_ipi;
            decimal v_total = soma - v_discount;
            tfValueTotal.EditValue = v_total;
            tfValueTotalNote.EditValue = v_total;
        }
        private void EmissionAt(DateTime? t)
        {
            if (t != null)
            {
                tfDateEmission.DateTime = Convert.ToDateTime(t);
                tfTimeEmission.Time = Convert.ToDateTime(t);
            }
        }
        private DateTime EmissionAt()
        {
            DateTime date = tfDateEmission.DateTime;
            DateTime time = tfTimeEmission.Time;
            return new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validator.Validate())
                return;
            decimal value = Convert.ToDecimal(colvalue.SummaryItem.SummaryValue);
            if(value <= 0)
            {
                XtraMessageBox.Show("Informe as parcelas da Nota");
                tabControl.SelectedTabPage = tabPayment;
                return;
            }
            if (value != Convert.ToDecimal(tfValueTotal.EditValue))
            {
                XtraMessageBox.Show("Soma das parcelas nao conferem com o valor tota da Nota");
                tabControl.SelectedTabPage = tabPayment;
                return;
            }
            try
            {
                SplashScreenManager.ShowForm(desk, typeof(PleaseWaitForm), false, false, false);
                using (var scope = accounts_to_pay.repo.GetTransaction())
                {
                    accounts_to_pay acp = (accounts_to_pay)bdgAccountToPay.Current;
                    acp.registred_at = accounts_to_pay.Now();
                    acp.registred_by = Singleton.getUser().id;
                    acp.emission_at = EmissionAt();
                    acp.guid_payment = Guid.NewGuid().ToString();
                    acp.Save();

                    List<payment> lPay = (List<payment>)bdgPayments.DataSource;
                    foreach (payment p in lPay)
                    {
                        p.customer_id = acp.customer_id;
                        p.truck_id = acp.truck_id;
                        p.registred_at = acp.registred_at;
                        p.registred_by = acp.registred_by;
                        p.account_id = acp.id;
                        p.guid = acp.guid_payment;
                        p.category_id = acp.category_id;
                        p.paid = false;
                        p.Save();
                    }
                    scope.Complete();
                    SplashScreenManager.CloseForm(false);
                    if (MessageToSave("Conta a Pagar"))
                        desk.AddTabAndCloseCurrent(new AccountsToPayForm(null), "Nova Conta a Pagar", false);
                }
            }
            catch (Exception ex)
            {
                accounts_to_pay.repo.AbortTransaction();
                SplashScreenManager.CloseForm(false);
                XtraMessageBox.Show(String.Format("Ocorreu um erro:\n\n{0}\n{1}", ex.Message, ex.InnerException));
            }
        }

        private void btnGenerateParcels_Click(object sender, EventArgs e)
        {
            if (!validatorParcels.Validate())
                return;
            if (String.IsNullOrEmpty(tfDescription.EditValue.ToString()))
            {
                XtraMessageBox.Show("Informe a descrição da Nota");
                tabControl.SelectedTabPage = tabGeneral;
                tfDescription.Focus();
                return;
            }
            List<payment> pay = new List<payment>();
            DateTime initialDate = tfDateStart.DateTime;
            int intervalDays = Convert.ToInt32(tfIntervalDays.EditValue);
            foreach (decimal d in Money.Parcel(ToDecimal(tfValueTotal.EditValue), Convert.ToInt32(tfQntParcels.EditValue)))
            {
                pay.Add(new payment() 
                {
                    description = tfDescription.Text, 
                    value = d,
                    expiration_date = initialDate,
                    customer_id = Convert.ToInt64(cbCustomer.EditValue)
                });
                initialDate = initialDate.AddDays(intervalDays);
            }
            bdgPayments.DataSource = pay;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewCategoryForm ncf = new NewCategoryForm(category.Categorys.Payment);
            if (ncf.ShowDialog() == DialogResult.OK)
                loadData();
            else
                XtraMessageBox.Show("Categoria não cadastrada!");
        }

        private void btnRefreshData_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
