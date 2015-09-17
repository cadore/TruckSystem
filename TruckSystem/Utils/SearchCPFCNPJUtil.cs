using System;
using System.IO;
using System.Text;

namespace TruckSystem.Utils.CPFCNPJ
{
    public class SearchCPFCNPJUtil
    {
        static string directory_searchs = Directory.GetCurrentDirectory() + @"\Utils\Searchs\";
        static string fileDocument = directory_searchs + "document";
        static string fileCPF = directory_searchs + "ConsultaCPF.exe";
        static string fileCNPJ = directory_searchs + "ConsultaCNPJ.exe";

        #region CNPJ
        public string NCNPJ { get; set; }
        public string RAZAOSOCIAL { get; set; }
        public string FANTASIA { get; set; }
        public string TIPO { get; set; }
        public string ABERTURA { get; set; }
        public string TELEFONE { get; set; }
        public string ENDERECO { get; set; }
        public string NUMERO { get; set; }
        public string COMPLEMENTO { get; set; }
        public string BAIRRO { get; set; }
        public string CIDADE { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
        public string SITUACAOCNPJ { get; set; }
        public string CNAE1 { get; set; }
        public string CNAE2 { get; set; }
        public string NATUREZA { get; set; }
        #endregion

        #region CPF
        public string NCPF { get; set; }
        public string NOME { get; set; }
        public string SITUACAOCPF { get; set; }
        public string EMISSAO { get; set; }
        public string CODCONTROLE { get; set; }
        public string DV { get; set; }
        #endregion
        private bool GetCurrentDocument()
        {
            try
            {
                /*
                StreamReader sr = new StreamReader(fileDocument);
                StreamWriter sw = new StreamWriter(fileDocument, false, Encoding.GetEncoding(1252));
                sw.WriteLine(sr.ReadToEnd());
                sw.Close();
                sr.Close();
                */

                // CNPJ
                NCNPJ = INI.ReadValue("CNPJ", "NCNPJ", fileDocument);
                RAZAOSOCIAL = INI.ReadValue("CNPJ", "RAZAOSOCIAL", fileDocument);
                FANTASIA = INI.ReadValue("CNPJ", "FANTASIA", fileDocument);
                TIPO = INI.ReadValue("CNPJ", "TIPO", fileDocument);
                ABERTURA = INI.ReadValue("CNPJ", "ABERTURA", fileDocument);
                TELEFONE = INI.ReadValue("CNPJ", "TELEFONE", fileDocument);
                ENDERECO = INI.ReadValue("CNPJ", "ENDERECO", fileDocument);
                NUMERO = INI.ReadValue("CNPJ", "NUMERO", fileDocument);
                COMPLEMENTO = INI.ReadValue("CNPJ", "COMPLEMENTO", fileDocument);
                BAIRRO = INI.ReadValue("CNPJ", "BAIRRO", fileDocument);
                CIDADE = INI.ReadValue("CNPJ", "CIDADE", fileDocument);
                UF = INI.ReadValue("CNPJ", "UF", fileDocument);
                CEP = INI.ReadValue("CNPJ", "CEP", fileDocument);
                SITUACAOCNPJ = INI.ReadValue("CNPJ", "SITUACAO", fileDocument);
                CNAE1 = INI.ReadValue("CNPJ", "CNAE1", fileDocument);
                CNAE2 = INI.ReadValue("CNPJ", "CNAE2", fileDocument);
                NATUREZA = INI.ReadValue("CNPJ", "NATUREZA", fileDocument);

                // CPF
                NCPF = INI.ReadValue("CPF", "NCPF", fileDocument);
                NOME = INI.ReadValue("CPF", "NOME", fileDocument);
                SITUACAOCPF = INI.ReadValue("CPF", "SITUACAOCPF", fileDocument);
                EMISSAO = INI.ReadValue("CPF", "EMISSAO", fileDocument);
                CODCONTROLE = INI.ReadValue("CPF", "CODCONTROLE", fileDocument);
                DV = INI.ReadValue("CPF", "DV", fileDocument);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public bool Search(Document type, string document)
        {
            document = document.Replace("_", "");
            document = document.Replace(".", "");
            document = document.Replace("/", "");
            document = document.Replace("-", "");
            if (String.IsNullOrWhiteSpace(document))
                return false;
            try
            {
                string file = (type == Document.CNPJ) ? fileCNPJ : fileCPF;
                int exitCod = RunUtil.Run(file, document, true);
                if (exitCod == 2)
                    if (GetCurrentDocument() && (!String.IsNullOrEmpty(NCNPJ) || !String.IsNullOrEmpty(NCPF)))
                        return true;
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }

        }
    }

    public enum Document
    {
        CNPJ,
        CPF
    }
}
