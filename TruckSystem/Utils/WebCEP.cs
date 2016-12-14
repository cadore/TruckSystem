using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace TruckSystem.Utils
{
    public class WebCEP
    {
        #region Variables
        public string UF { get; set; }
        public string CIDADE { get; set; }
        public string BAIRRO { get; set; }
        public string TIPOLAGRADOURO { get; set; }
        public string LAGRADOURO { get; set; }
        public int RESULTADO { get; set; }
        public string RESULTADO_TXT { get; set; }

        public enum TypeCase
        {
            Normal = 0,
            Lower = 1,
            Upper = 2
        }
        #endregion

        #region Construct
        public WebCEP(string CEP, TypeCase tc = TypeCase.Normal)
        {
            UF = "";
            CIDADE = "";
            BAIRRO = "";
            TIPOLAGRADOURO = "";
            LAGRADOURO = "";
            RESULTADO = 0;
            RESULTADO_TXT = "CEP não encontrado";

            try
            {
                //Cria um DataSet  baseado no retorno do XML  
                DataSet ds = new DataSet();
                ds.ReadXml("http://cep.republicavirtual.com.br/web_cep.php?cep=" + CEP.Replace("-", "").Trim() + "&formato=xml");

                if (ds != null)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        RESULTADO = Convert.ToInt32(ds.Tables[0].Rows[0]["resultado"].ToString());
                        switch (RESULTADO)
                        {
                            case 1:
                                UF = ds.Tables[0].Rows[0]["uf"].ToString().Trim();
                                CIDADE = ds.Tables[0].Rows[0]["cidade"].ToString().Trim();
                                BAIRRO = ds.Tables[0].Rows[0]["bairro"].ToString().Trim();
                                TIPOLAGRADOURO = ds.Tables[0].Rows[0]["tipo_logradouro"].ToString().Trim();
                                LAGRADOURO = ds.Tables[0].Rows[0]["logradouro"].ToString().Trim();
                                RESULTADO_TXT = "CEP completo";
                                break;
                            case 2:
                                UF = ds.Tables[0].Rows[0]["uf"].ToString().Trim();
                                CIDADE = ds.Tables[0].Rows[0]["cidade"].ToString().Trim();
                                BAIRRO = "";
                                TIPOLAGRADOURO = "";
                                LAGRADOURO = "";
                                RESULTADO_TXT = "CEP único";
                                break;
                            default:
                                UF = "";
                                CIDADE = "";
                                BAIRRO = "";
                                TIPOLAGRADOURO = "";
                                LAGRADOURO = "";
                                RESULTADO_TXT = "CEP não encontrado";
                                break;
                        }
                        if (tc == TypeCase.Upper || tc == TypeCase.Lower)
                        {
                            UF = tc == TypeCase.Upper ? UF.ToUpper() : UF.ToLower();
                            CIDADE = tc == TypeCase.Upper ? CIDADE.ToUpper() : CIDADE.ToLower();
                            BAIRRO = tc == TypeCase.Upper ? BAIRRO.ToUpper() : BAIRRO.ToLower();
                            TIPOLAGRADOURO = tc == TypeCase.Upper ? TIPOLAGRADOURO.ToUpper() : TIPOLAGRADOURO.ToLower();
                            LAGRADOURO = tc == TypeCase.Upper ? LAGRADOURO.ToUpper() : LAGRADOURO.ToLower();
                            RESULTADO_TXT = tc == TypeCase.Upper ? RESULTADO_TXT.ToUpper() : RESULTADO_TXT.ToLower();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }

            //--result
            //Exemplo do retorno da  WEB  
            //<?xml version="1.0"  encoding="iso-8859-1"?>  
            //<webservicecep>  
            //<uf>RS</uf>  
            //<cidade>Porto  Alegre</cidade>  
            //<bairro>Passo  D'Areia</bairro>  
            //<tipo_logradouro>Avenida</tipo_logradouro>  
            //<logradouro>Assis Brasil</logradouro>  
            //<resultado>1</resultado>  
            //<resultado_txt>sucesso - cep  completo</resultado_txt>  
            //</webservicecep>  
        }
        #endregion
    }
}