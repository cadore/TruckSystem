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
using DevExpress.XtraSplashScreen;
using TruckSystem.UI.SplashScreens;
using TruckSystem.UI.Freights.Fueled;
using TruckSystem.UI.Freights.Outputs;
using TruckSystem.Utils;
using TruckSystem.UI.Utils;
using TruckSystem.UI.Freights.Stays;
using TruckSystem.UI.Deposits;

namespace TruckSystem.UI.Freights
{
    public partial class FreightForm : TruckSystem.UI.Utils.UserControlUtil
    {
        //fueleds
        List<fueled> ListFueleds = null;
        decimal ValueFueled = 0;
        //outputs
        List<output> ListOutputs = null;
        decimal ValueOutputs = 0;
        decimal ValueOthersOutputs = 0;
        //deposits
        List<deposits> ListDeposits = null;
        decimal ValueDeposits = 0;

        List<trailer> Trailers = null;

        public FreightForm(freight f)
        {
            InitializeComponent();
            ControlsUtil.SetBackColor(this.Controls);
            if (f == null)
                IsNew = true;
            if (IsNew)
                f = new freight() { number_note = null, number_cte = null };
            else
            {
                ListFueleds = fueled.Fetch("WHERE freight_id=@0", f.id);
                ListOutputs = output.Fetch("WHERE freight_id=@0", f.id);
                ListDeposits = deposits.Fetch("WHERE freight_id=@0", f.id);
                loadValuesFueledsAndOutputs(f);
                tfNumberNote.Properties.ReadOnly = true;
                cbTruck.Properties.ReadOnly = true;
                btnStay.Visible = true;
            }
            loadData();
            bdgFreight.DataSource = f;
            DateTime now = freight.Now();
            tfStart.Properties.MaxValue = now;
            tfEnd.Properties.MaxValue = now;

            if (!IsNew)
            {
                //cbDriver.EditValue = f.driver_id;
                //tfPercentComission.EditValue = f.taxe_comission;
            }
        }

        private void loadValuesFueledsAndOutputs(freight f)
        {
            ValueFueled = 0;
            ValueOutputs = 0;
            foreach (fueled fu in ListFueleds)
                ValueFueled += fu.total;
            foreach (output o in ListOutputs)
                ValueOutputs += o.value;

            tfFueled.EditValue = ValueFueled;
            tfOutputs.EditValue = ValueOutputs;
            stay st = stay.SingleOrDefault("WHERE freight_id=@0", f.id);
            if (st != null)
            {
                tfStay.EditValue = st.total;
                tfExtraComission.EditValue = st.total_comission;
                if (((freight)bdgFreight.Current) != null)
                    ((freight)bdgFreight.Current).extra_comission = st.total_comission;
                tfExtraComission.Properties.ReadOnly = true;
            }
        }

        private void loadData()
        {
            bdgTrucks.DataSource = truck.Fetch("");
            bdgDrivers.DataSource = driver.Fetch("WHERE inactive=FALSE");
            List<customer> listC = customer.Fetch("WHERE inactive=FALSE");
            bdgCompanySource.DataSource = listC;
            bdgCompanyDestination.DataSource = listC;
            bdgCarrier.DataSource = listC;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            desk.CloseCurrentTab();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validator.Validate())
                return;
            freight fre = (freight)bdgFreight.Current;
            if (IsNew)
            {
                if (!Validations.Unique.NumberNoteFreightUnique(fre))
                {
                    freight nf = freight.SingleOrDefault("SELECT id FROM freights WHERE number_note=@0", fre.number_note);
                    if (nf != null)
                    {
                        XtraMessageBox.Show("Numero da nota já existe, verifique!\nFrete ID: " + nf.id);
                    }                    
                    return;
                }

                if (!Validations.Unique.NumberCteFreightUnique(fre))
                {
                    freight nf = freight.SingleOrDefault("SELECT id FROM freights WHERE number_cte=@0", fre.number_cte);
                    if (nf != null)
                    {
                        XtraMessageBox.Show("Numero do CT-e já existe, verifique!\nFrete ID: " + nf.id);
                    }
                    return;
                }

                string TextMessage = String.Format("Confirma salvar os dados deste frete com as informações abaixo?"
                + "\n  - {0} abastecidas\n  - {1} despesas",
                ListFueleds != null ? ListFueleds.Count : 0, ListOutputs != null ? ListOutputs.Count : 0);
                if (XtraMessageBox.Show(TextMessage, "Cadore Tecnologia", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.Cancel)
                    return;
            }
            try
            {
                using (var scope = freight.repo.GetTransaction())
                {
                    
                    if (IsNew)
                    {
                        fre.registred_at = freight.Now();
                        fre.registred_by = Singleton.getUser().id;
                    }

                    /*trailer tr1 = trailer.SingleOrDefault("WHERE truck_id=@0 AND index=@1", fre.truck_id, 1);
                    trailer tr2 = trailer.SingleOrDefault("WHERE truck_id=@0 AND index=@1", fre.truck_id, 2);
                    trailer tr3 = trailer.SingleOrDefault("WHERE truck_id=@0 AND index=@1", fre.truck_id, 3);
                    
                    fre.trailers = String.Format("{0},{1},{2}",
                        (tr1 != null ? tr1.id.ToString() : "0"),
                        (tr2 != null ? tr2.id.ToString() : "0"), 
                        (tr3 != null ? tr3.id.ToString() : "0"));
                    */
                    fre.Save();

                    foreach (trailer t in Trailers)
                    {
                        set_freight_trailers sft = new set_freight_trailers() 
                        { 
                            freight_id = fre.id,
                            trailer_id = t.id, 
                            index_trailer = t.index 
                        };
                        sft.Save();
                    }

                    if (ListFueleds != null)
                    {
                        foreach (fueled fue in ListFueleds)
                        {
                            fue.registred_at = fueled.Now();
                            fue.registred_by = Singleton.getUser().id;
                            fue.freight_id = fre.id;
                            fue.driver_id = fre.driver_id;
                            fue.truck_id = fre.truck_id;
                            if (fue.IsNew())
                            {
                                fue.Save();
                            }
                        }
                    }

                    if (ListOutputs != null)
                    {
                        foreach (output o in ListOutputs)
                        {
                            o.registred_at = output.Now();
                            o.registred_by = Singleton.getUser().id;
                            o.freight_id = fre.id;
                            o.truck_id = fre.truck_id;
                            if (o.IsNew())
                            {
                                o.Save();
                            }
                        }
                    }

                    if (ListDeposits != null)
                    {
                        Console.WriteLine("Deposit not null");
                        foreach (deposits d in ListDeposits)
                        {
                            Console.WriteLine("single deposit");
                            d.freight_id = fre.id;
                            d.truck_id = fre.truck_id;
                            if (d.IsNew())
                            {
                                Console.WriteLine("deposit saved");
                                d.Save();
                            }
                            else
                            {
                                Console.WriteLine("deposit updated");
                                d.Update();
                            }                                
                        }
                    }
                    scope.Complete();
                }
                tfId.EditValue = fre.id;
                if(MessageToSave("Frete"))
                    desk.AddTabAndCloseCurrent(new FreightForm(null), "Novo Frete", false);
            }
            catch (Exception ex)
            {
                freight.repo.AbortTransaction();
                XtraMessageBox.Show(String.Format("Ocorreu um erro:\n\n{0}\n{1}", ex.Message, ex.InnerException));
            }
        }

        private void cbTruck_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(desk, typeof(PleaseWaitForm), false, false, false);
                if (cbTruck.EditValue != DBNull.Value && Convert.ToInt64(cbTruck.EditValue) > 0)
                {
                    truck t = truck.SingleOrDefault(cbTruck.EditValue);
                    Trailers = trailer.Fetch("WHERE truck_id=@0 ORDER BY index", t.id);

                    setTrailers();

                    if (IsNew)
                    {
                        cbDriver.EditValue = t.driver_id;
                        ((freight)bdgFreight.Current).driver_id = t.driver_id;
                    }
                }
                else
                {
                    lbTrailers.Text = String.Format("Reboques:");
                    cbDriver.EditValue = 0;
                    bdgDrivers.ResetCurrentItem();
                }
                SplashScreenManager.CloseForm(false);
            }
            catch (Exception ex)
            {
                SplashScreenManager.CloseForm(false);
                XtraMessageBox.Show(String.Format("Ocorreu um erro:\n\n{0}\n{1}", ex.Message, ex.InnerException));
            }
        }

        void setTrailers()
        {
            string lbT = "Reboques: ";
            int count = 0;
            foreach (trailer tr in Trailers)
            {
                lbT += String.Format((count == 0 ? "" : @"/") + "{0}", tr.board);
                count++;
            }
            count = 0;
            lbTrailers.Text = lbT;
        }
        void calcValues(object sender, EventArgs e)
        {
            decimal weight = toDecimal(tfWeight.EditValue);
            decimal value_ton = toDecimal(tfValueTon.EditValue);
            decimal gross = toDecimal(weight * value_ton);
            tfGross.EditValue = gross;
            
            decimal taxe_comission_gross = toDecimal(tfPercentComissionGross.EditValue);
            decimal taxe_comission_liquid = toDecimal(tfPercentComissionLiquid.EditValue);
            decimal discount_comission = toDecimal(tfDiscountComission.EditValue);
            decimal extra_comission = toDecimal(tfExtraComission.EditValue);

            decimal fueled = toDecimal(tfFueled.EditValue);
            decimal outputs = toDecimal(tfOutputs.EditValue);
            decimal othersOutputs = toDecimal(tfOthersOutputs.EditValue);
            decimal stay = toDecimal(tfStay.EditValue);
            decimal subtotal_freight = (gross + stay) - (fueled + outputs + othersOutputs);
            decimal subtotal_comission_liquid = gross - (fueled + outputs);
            decimal value_comission_gross = toDecimal(((gross * taxe_comission_gross) / 100));
            decimal value_comission_liquid = toDecimal(((subtotal_comission_liquid * taxe_comission_liquid) / 100));
            decimal liquid_freight = toDecimal((gross + stay) - (value_comission_gross + value_comission_liquid + fueled 
                + outputs + othersOutputs));

            lbBaseComissionGross.Text = String.Format("Valor Base: {0:c2}", gross);
            lbBaseComissionLiquid.Text = String.Format("Valor Base: {0:c2}", subtotal_comission_liquid);
            tfPartialComissionGross.EditValue = value_comission_gross;
            tfPartialComissionLiquid.EditValue = value_comission_liquid;
            tfValueComission.EditValue = (value_comission_gross + value_comission_liquid + extra_comission) - discount_comission;

            tfSubTotalFreight.EditValue = subtotal_freight;
            tfLiquidFreight.EditValue = liquid_freight;
        }

        decimal toDecimal(object v)
        {
            if (v == null || v.Equals(DBNull.Value) || String.IsNullOrEmpty(v.ToString()))
                v = "0";
            decimal output;
            Decimal.TryParse(v.ToString(), out output);
            return output;
        }

        private void cbDriver_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(desk, typeof(PleaseWaitForm), false, false, false);
                if (cbDriver.EditValue != DBNull.Value && Convert.ToInt64(cbDriver.EditValue) > 0)
                {
                    if (IsNew)
                    {
                        driver d = driver.SingleOrDefault(cbDriver.EditValue);
                        tfPercentComissionGross.EditValue = d.comission;
                    }
                }
                else
                {
                    tfPercentComissionGross.EditValue = 0;
                }
                SplashScreenManager.CloseForm(false);
            }
            catch (Exception ex)
            {
                SplashScreenManager.CloseForm(false);
                XtraMessageBox.Show(String.Format("Ocorreu um erro:\n\n{0}\n{1}", ex.Message, ex.InnerException));
            }            
        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnFueled_Click(object sender, EventArgs e)
        {
            if (!validator.Validate())
                return;
            ViewFueledsForm ff = new ViewFueledsForm(ListFueleds, (freight)bdgFreight.Current);
            if (ff.ShowDialog() == DialogResult.OK)
            {
                if (ListFueleds == null)
                {
                    ListFueleds = new List<fueled>();
                    ListFueleds.Clear();
                }
                    
                foreach(fueled f in ((List<fueled>)ff.bdgFueleds.DataSource))
                    if(!ListFueleds.Contains(f))
                        ListFueleds.Add(f);
                
                ValueFueled = 0;
                foreach (fueled f in ListFueleds)
                {
                    ValueFueled += f.total;
                }
                tfFueled.EditValue = ValueFueled;
                calcValues(sender, e);
            }
        }

        private void btnOutputs_Click(object sender, EventArgs e)
        {
            if (!validator.Validate())
                return;
            ViewOutputsForm vof = new ViewOutputsForm(ListOutputs, (freight)bdgFreight.Current);
            if (vof.ShowDialog() == DialogResult.OK)
            {
                if (ListOutputs == null)
                {
                    ListOutputs = new List<output>();
                    ListOutputs.Clear();
                }

                foreach (output o in ((List<output>)vof.bdgOutputs.DataSource))
                    if (!ListOutputs.Contains(o))
                        ListOutputs.Add(o);

                ValueOutputs = 0;
                ValueOthersOutputs = 0;
                foreach (output o in ListOutputs)
                {
                    if(o.others_outputs)
                        ValueOthersOutputs += o.value;
                    else
                        ValueOutputs += o.value;
                }
                tfOutputs.EditValue = ValueOutputs;
                tfOthersOutputs.EditValue = ValueOthersOutputs;
                calcValues(sender, e);
            }
        }

        private void tfStart_EditValueChanged(object sender, EventArgs e)
        {
            tfEnd.Properties.MinValue = tfStart.DateTime;
        }

        private void tfGross_KeyDown(object sender, KeyEventArgs e)
        {
            if (toDecimal(tfWeight.EditValue) > 0)
            {
                InputMessageForm imf = new InputMessageForm("Informe o Valor Bruto 'R$'", TruckSystem.UI.Utils.InputMessageForm.FormatValue.Decimal);
                if (imf.ShowDialog() == DialogResult.OK)
                {
                    if (toDecimal(imf.Value) > 0)
                    {
                        decimal gross = toDecimal(imf.Value);
                        decimal weight = toDecimal(tfWeight.EditValue);
                        decimal ton = toDecimal(gross / weight);
                        tfValueTon.EditValue = ton;
                        ((freight)bdgFreight.Current).value_ton = ton;
                    }
                }
            }
        }

        private void btnStay_Click(object sender, EventArgs e)
        {
            StayForm sf = new StayForm((freight)bdgFreight.Current);
            if (sf.ShowDialog() == DialogResult.OK)
            {
                stay s = (stay)sf.bdgStay.Current;
                if (s.id > 0)
                {
                    tfExtraComission.EditValue = s.total_comission;
                    ((freight)bdgFreight.Current).extra_comission = s.total_comission;
                    tfStay.EditValue = s.total;
                    tfExtraComission.Properties.ReadOnly = true;
                    calcValues(sender, e);
                }                
            }
        }

        private void tfGross_Enter(object sender, EventArgs e)
        {
            /*
            decimal b = ToDecimal(tfGross.EditValue);
            if (b > 0)
                tfPercentComission.Focus();
             */
        }

        private void btnDeposits_Click(object sender, EventArgs e)
        {
            if (!validator.Validate())
                return;
            ViewDepositsForm vdf = new ViewDepositsForm(ListDeposits, (freight)bdgFreight.Current);
            if (vdf.ShowDialog() == DialogResult.OK)
            {
                if (ListDeposits == null)
                {
                    ListDeposits = new List<deposits>();
                    ListDeposits.Clear();
                }              
                foreach (deposits d in ((List<deposits>)vdf.bdgDeposits.DataSource))
                    if(!ListDeposits.Contains(d))
                        ListDeposits.Add(d);

                ValueDeposits = 0;
                foreach (deposits o in ListDeposits)
                {
                    ValueDeposits += o.value;
                }
                tfDeposits.EditValue = ValueDeposits;
                calcValues(sender, e);
            }
        }

        private void lbTrailers_Click(object sender, EventArgs e)
        {
            if (cbTruck.EditValue != DBNull.Value && Convert.ToInt64(cbTruck.EditValue) > 0)
            {
                SelectTrailersFreight stf = new SelectTrailersFreight();
                if (stf.ShowDialog() == DialogResult.OK)
                {
                    Trailers.Clear();
                    Trailers = stf.listTrailers;
                    setTrailers();
                }
            }            
        }

        private void lbTrailers_MouseEnter(object sender, EventArgs e)
        {
            lbTrailers.ForeColor = Color.Blue;
        }

        private void lbTrailers_MouseLeave(object sender, EventArgs e)
        {
            lbTrailers.ForeColor = Color.Black;
        }

        private void FreightForm_KeyDown(object sender, KeyEventArgs e)
        {
            XtraMessageBox.Show("ok");
        }
    }
}
