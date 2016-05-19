using DevExpress.XtraEditors.DXErrorProvider;
using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TruckSystem.Utils
{
    public class Validations
    {
        public class ValidatorCPFCNPJ : ValidationRule
        {
            public override bool Validate(Control control, object value)
            {
                string str = value == DBNull.Value ? string.Empty : (string)value;
                if (String.IsNullOrEmpty(str))
                    return false;
                bool res = false;
                if (isCPFCNPJ(str, false))
                    res = true;
                else
                    res = false;

                return res;
            }
        }
        public static bool isCPFCNPJ(string cpfcnpj, bool vazio)
        {
            if (string.IsNullOrEmpty(cpfcnpj))
                return vazio;
            else
            {

                int[] d = new int[14];
                int[] v = new int[2];
                int j, i, soma;
                string Sequencia, SoNumero;

                SoNumero = Regex.Replace(cpfcnpj, "[^0-9]", string.Empty);

                if (SoNumero == "00000000000") return true;

                //verificando se todos os numeros são iguais
                if (new string(SoNumero[0], SoNumero.Length) == SoNumero) return false;

                // se a quantidade de dígitos numérios for igual a 11
                // iremos verificar como CPF
                if (SoNumero.Length == 11)
                {                    
                    for (i = 0; i <= 10; i++) d[i] = Convert.ToInt32(SoNumero.Substring(i, 1));
                    for (i = 0; i <= 1; i++)
                    {
                        soma = 0;
                        for (j = 0; j <= 8 + i; j++) soma += d[j] * (10 + i - j);

                        v[i] = (soma * 10) % 11;
                        if (v[i] == 10) v[i] = 0;
                    }
                    return (v[0] == d[9] & v[1] == d[10]);
                }
                // se a quantidade de dígitos numérios for igual a 14
                // iremos verificar como CNPJ
                else if (SoNumero.Length == 14)
                {
                    Sequencia = "6543298765432";
                    for (i = 0; i <= 13; i++) d[i] = Convert.ToInt32(SoNumero.Substring(i, 1));
                    for (i = 0; i <= 1; i++)
                    {
                        soma = 0;
                        for (j = 0; j <= 11 + i; j++)
                            soma += d[j] * Convert.ToInt32(Sequencia.Substring(j + 1 - i, 1));

                        v[i] = (soma * 10) % 11;
                        if (v[i] == 10) v[i] = 0;
                    }
                    return (v[0] == d[12] & v[1] == d[13]);
                }
                // CPF ou CNPJ inválido se
                // a quantidade de dígitos numérios for diferente de 11 e 14
                else return false;
            }
        }

        [DllImport("DllInscE32.dll")]
        public static extern int ConsisteInscricaoEstadual(string cInsc, string cUF);

        public static bool validIE(string ie, string estado)
        {
            int retorno = ConsisteInscricaoEstadual(ie, estado);

            if (retorno == 0)
                return true;
            else
                return false;
        }

        public class Unique
        {
            public static bool DocumentCustomerIsUnique(customer c)
            {
                try
                {
                    string s = TruckSystemRepo.GetInstance().ExecuteScalar<string>
                        ("SELECT COUNT(id) FROM customers WHERE document=@0", c.document);
                    int count;
                    if (s.Equals(DBNull.Value) || String.IsNullOrEmpty(s))
                        count = 0;
                    else
                        count = Convert.ToInt32(s);

                    if (count == 0)
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex.InnerException);
                }
            }

            public static bool CPFDriverIsUnique(driver c)
            {
                try
                {
                    string s = TruckSystemRepo.GetInstance().ExecuteScalar<string>
                        ("SELECT COUNT(id) FROM drivers WHERE document=@0", c.cpf);
                    int count;
                    if (s.Equals(DBNull.Value) || String.IsNullOrEmpty(s))
                        count = 0;
                    else
                        count = Convert.ToInt32(s);

                    if (count == 0)
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex.InnerException);
                }
            }
            public static bool CNHDriverIsUnique(driver c)
            {
                try
                {
                    string s = TruckSystemRepo.GetInstance().ExecuteScalar<string>
                        ("SELECT COUNT(id) FROM drivers WHERE number_cnh=@0", c.number_cnh);
                    int count;
                    if (s.Equals(DBNull.Value) || String.IsNullOrEmpty(s))
                        count = 0;
                    else
                        count = Convert.ToInt32(s);

                    if (count == 0)
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex.InnerException);
                }
            }

            public static bool BoardTruckIsUnique(truck c)
            {
                try
                {
                    int count;
                    var s = TruckSystemRepo.GetInstance().ExecuteScalar<string>("SELECT COUNT(id) FROM trucks WHERE board=@0", c.board);
                    if (s.Equals(DBNull.Value) || String.IsNullOrEmpty(s))
                        count = 0;
                    else
                        count = Convert.ToInt32(s);
                    if (count == 0)
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex.InnerException);
                }
            }
            public static bool DriverTruckIsUnique(truck c)
            {
                try
                {
                    int count;
                    var s = TruckSystemRepo.GetInstance().ExecuteScalar<string>("SELECT COUNT(id) FROM trucks WHERE driver_id=@0", c.driver_id);
                    if (s.Equals(DBNull.Value) || String.IsNullOrEmpty(s))
                        count = 0;
                    else
                        count = Convert.ToInt32(s);
                    if (count == 0)
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex.InnerException);
                }
            }
            internal static bool NumberNoteFreightUnique(freight fre)
            {
                try
                {
                    int count;
                    var s = TruckSystemRepo.GetInstance().ExecuteScalar<string>
                        ("SELECT COUNT(id) FROM freights WHERE number_note=@0", fre.number_note);
                    if (s.Equals(DBNull.Value) || String.IsNullOrEmpty(s))
                        count = 0;
                    else
                        count = Convert.ToInt32(s);
                    if (count == 0)
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex.InnerException);
                }
            }

            internal static bool NumberCteFreightUnique(freight fre)
            {
                try
                {
                    int count;
                    var s = TruckSystemRepo.GetInstance().ExecuteScalar<string>
                        ("SELECT COUNT(id) FROM freights WHERE number_cte=@0", fre.number_cte);
                    if (s.Equals(DBNull.Value) || String.IsNullOrEmpty(s))
                        count = 0;
                    else
                        count = Convert.ToInt32(s);
                    if (count == 0)
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex.InnerException);
                }
            }
        }
    }
}