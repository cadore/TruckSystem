CREATE TABLE IF NOT EXISTS public.banks(
	id bigserial NOT NULL,
	code character varying(255),
	cnpj character varying(255),
	name character varying(255),
	site character varying(255),
	CONSTRAINT "PK_banks_id" PRIMARY KEY (id)
);

ALTER TABLE public.customers
  ADD COLUMN email character varying;

CREATE TABLE public.business
(
  id bigint NOT NULL DEFAULT nextval('business_id_seq'::regclass),
  corporate_name character varying,
  fantasy_name character varying,
  document character varying,
  address_id bigint,
  registred_at date,
  registred_by bigint,
  inactive boolean,
  ie_rg character varying,
  phone_fixed character varying,
  phone_mobile character varying,
  type integer,
  email character varying,
  manager character varying,
  document_manager character varying,
  contact_manager character varying,
  CONSTRAINT "PK_business_id" PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE public.business
  OWNER TO postgres;


ALTER TABLE public.customers
  ADD COLUMN manager character varying;
ALTER TABLE public.customers
  ADD COLUMN document_manager character varying;
ALTER TABLE public.customers
  ADD COLUMN contact_manager character varying;
ALTER TABLE public.customers
  ADD COLUMN observations text;

  
  

------------------------------------------------------------------------------------------------------------------------------------------------------//

INSERT INTO banks(id, code, cnpj, name, site) VALUES (1, '654', '92.874.270', 'Banco A.J.Renner S.A.', 'www.bancorenner.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (2, '246', '28.195.667/0001-06', 'Banco ABC Brasil S.A.', 'www.abcbrasil.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (3, '75', '03.532.415/0001-02', 'Banco ABN AMRO S.A.', 'www.bancocr2.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (4, '', '', 'Banco Alfa de Investimentos SA', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (5, '25', '03.323.840/0001-83', 'Banco Alfa S.A.', 'www.bancoalfa.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (6, '641', '33.870.163/0001-84', 'Banco Alvorada S.A.', 'Não possui site');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (7, '213', '54.403.563/0001-50', 'Banco Arbi S.A.', 'www.arbi.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (8, '19', '9.391.857', 'Banco Azteca do Brasil S.A.', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (9, '', '', 'Banco Bandeirantes de Investimentos SA', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (10, '24', '10.866.788/0001-77', 'Banco BANDEPE S.A.', 'www.bandepe.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (11, '29', '33.885.724/0001-19', 'Banco Banerj S.A.', 'www.banerj.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (12, '0', '60.419.645/0001-95', 'Banco Bankpar S.A.', 'www.aexp.com');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (13, '740', '61.146.577/0001-09', 'Banco Barclays S.A.', 'www.barclays.com');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (14, '107', '15.114.366/0001-69', 'Banco BBM S.A.', 'www.bbmbank.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (15, '31', '01.540.541/0001-75', 'Banco Beg S.A.', 'www.itau.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (16, '', '33.147.315/0001-15', 'Banco BERJ S.A.', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (17, '96', '00.997.185', 'Banco BM&FBOVESPA de Serviços de Liquidação e Custódia S.A', 'www.bmf.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (18, '394', '07.207.996/0001-50', 'Banco BMC S.A.', 'www.bmc.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (19, '318', '61.186.680/0001-74', 'Banco BMG S.A.', 'www.bancobmg.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (20, '752', '01.522.368/0001-82', 'Banco BNP Paribas Brasil S.A.', 'www.bnpparibas.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (21, '248', '33.485.541/0001-06', 'Banco Boavista Interatlântico S.A.', 'não possui site');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (22, '218', '71.027.866/0001-34', 'Banco Bonsucesso S.A.', 'www.bancobonsucesso.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (23, '', '', 'Banco BPI Investimentos SA', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (24, '65', '48.795.256/0001-69', 'Banco Bracce S.A.', 'www.bancobracce.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (25, '36', '06.271.464/0001-19', 'Banco Bradesco BBI S.A.', 'Não possui site');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (26, '204', '59.438.325/0001-01', 'Banco Bradesco Cartões S.A.', 'www.iamex.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (27, '237', '60.746.948/0001-12', 'Banco Bradesco S.A.', 'www.bradesco.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (28, '225', '33.923.111/0001-29', 'Banco Brascan S.A.', 'www.bancobrascan.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (29, '', '27.937.333/0001-06', 'Banco BRJ S.A.', 'www.brjbank.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (30, '208', '30.306.294/0001-45', 'Banco BTG Pactual S.A.', 'www.pactual.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (31, '44', '32.254.138/0001-03', 'Banco BVA S.A.', 'www.bancobva.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (32, '263', '33.349.358/0001-83', 'Banco Cacique S.A.', 'www.bancocacique.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (33, '473', '33.466.988', 'Banco Caixa Geral - Brasil S.A.', 'www.bcgbrasil.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (34, '412', '15.173.776/0001-80', 'Banco Capital S.A.', 'www.bancocapital.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (35, '40', '03.609.817/0001-50', 'Banco Cargill S.A.', 'www.bancocargill.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (36, '', '02.658.435/0001-53', 'Banco Caterpillar S.A.', 'www.catfinancial.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (37, '266', '33.132.044/0001-24', 'Banco Cédula S.A.', 'www.bancocedula.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (38, '739', '00.558.456/0001-71', 'Banco Cetelem S.A.', 'www.cetelem.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (39, '233', '62.421.979/0001-29', 'Banco Cifra S.A.', 'www.bancocifra.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (40, '745', '33.479.023/0001-80', 'Banco Citibank S.A.', 'www.citibank.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (41, '', '34.098.442', 'Banco Citicard S.A.', 'www.credicardbanco.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (42, '241', '31.597.552/0001-52', 'Banco Clássico S.A.', 'Não possui site');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (43, '', '02.992.446/0001-75', 'Banco CNH Industrial Capital S.A.', 'www.bancocnh.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (44, '215', '61.230.165/0001-44', 'Banco Comercial e de Investimento Sudameris S.A.', 'www.sudameris.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (45, '', '43.818.780', 'Banco Commercial Investment Trus do Brasil S.A.', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (46, '95', '11.703.662/0001-44', 'Banco Confidence de Câmbio S.A.', 'www.bancoconfidence.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (47, '756', '02.038.232/0001-64', 'Banco Cooperativo do Brasil S.A. - BANCOOB', 'www.bancoob.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (48, '748', '01.181.521/0001-55', 'Banco Cooperativo Sicredi S.A.', 'www.sicredi.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (49, '721', '69.141.539/0001-67', 'Banco Credibel S.A.', 'www.credibel.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (50, '222', '75.647.891/0001-71', 'Banco Credit Agricole Brasil S.A.', 'www.calyon.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (51, '505', '32.062.580/0001-38', 'Banco Credit Suisse (Brasil) S.A.', 'www.csfb.com');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (52, '229', '62.136.254/0001-99', 'Banco Cruzeiro do Sul S.A.', 'www.bcsul.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (53, '', '8.357.240', 'Banco CSF S.A.', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (54, '3', '04.902.979/0001-44', 'Banco da Amazônia S.A.', 'www.bancoamazonia.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (55, '', '10.690.848', 'Banco da China Brasil S.A.', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (56, '', '02.831.756/0001-08', 'Banco Daimlerchrysler S.A.', 'www.bancodaimlerchrysler.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (57, '707', '62.232.889/0001-90', 'Banco Daycoval S.A.', 'www.daycoval.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (58, '', '', 'BANCO DE INVEST TENDENCIA S.A.', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (59, '', '', 'BANCO DE INVESTIMENTOS CREDIT SUISSE BRASIL S A - CREDIT SUISSE', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (60, '300', '33.042.151/0001-61', 'Banco de La Nacion Argentina', 'www.bna.com.ar');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (61, '495', '44.189.447/0001-26', 'Banco de La Provincia de Buenos Aires', 'www.bapro.com.ar');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (62, '494', '51.938.876/0001-14', 'Banco de La Republica Oriental del Uruguay', 'Não possui site');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (63, '', '05.040.481/0001-82', 'Banco de Lage Landen Brasil S.A.', 'www.delagelanden.com');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (64, '456', '60.498.557/0001-26', 'Banco de Tokyo-Mitsubishi UFJ Brasil S.A.', 'www.btm.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (65, '214', '61.199.881/0001-06', 'Banco Dibens S.A.', 'www.bancodibens.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (66, '1', '00.000.000/0001-91', 'Banco do Brasil S.A.', 'www.bb.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (67, '47', '13.009.717/0001-46', 'Banco do Estado de Sergipe S.A.', 'www.banese.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (68, '37', '04.913.711/0001-08', 'Banco do Estado do Pará S.A.', 'www.banparanet.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (69, '39', '06.833.131/0001-36', 'Banco do Estado do Piauí S.A. - BEP', 'www.bep.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (70, '41', '92.702.067/0001-96', 'Banco do Estado do Rio Grande do Sul S.A.', 'www.banrisul.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (71, '4', '07.237.373/0001-20', 'Banco do Nordeste do Brasil S.A.', 'www.banconordeste.gov.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (72, '265', '33.644.196/0001-06', 'Banco Fator S.A.', 'www.bancofator.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (73, '', '61.190.658/0001-06', 'Banco Fiat S.A.', 'www.bancofiat.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (74, '224', '58.616.418/0001-08', 'Banco Fibra S.A.', 'www.bancofibra.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (75, '626', '61.348.538/0001-86', 'Banco Ficsa S.A.', 'www.ficsa.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (76, '', '62.237.425', 'Banco Fidis S.A.', 'www.bancofidis.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (77, '', '', 'Banco Finasa de Investimentos SA', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (78, '', '90.731.688/0001-72', 'Banco Ford S.A.', 'www.bancoford.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (79, '', '', 'Banco Geração Futuro de Investimentos', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (80, '', '10.664.513/0001-50', 'Banco Gerador S.A.', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (81, '734', '00.183.938/0001-94', 'Banco Gerdau S.A.', 'www.bancogerdau.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (82, '', '59.274.605', 'Banco GMAC S.A.', 'www.bancogmac.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (83, '612', '31.880.826/0001-16', 'Banco Guanabara S.A.', 'www.bancoguanabara.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (84, '', '03.634.220/0001-65', 'Banco Honda S.A.', 'www.bancohonda.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (85, '63', '04.184.779/0001-01', 'Banco Ibi S.A. Banco Múltiplo', 'www.ibi.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (86, '', '34.270.520', 'Banco IBM S.A.', 'www.ibm.com/br/financing/');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (87, '604', '31.895.683/0001-16', 'Banco Industrial do Brasil S.A.', 'www.bancoindustrial.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (88, '320', '07.450.604/0001-89', 'Banco Industrial e Comercial S.A.', 'www.bicbanco.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (89, '653', '61.024.352', 'Banco Indusval S.A.', 'www.bip.b.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (90, '630', '58.497.702/0001-02', 'Banco Intercap S.A.', 'www.intercap.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (91, '77', '00.416.968', 'Banco Intermedium S.A.', 'www.intermedium.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (92, '249', '61.182.408/0001-16', 'Banco Investcred Unibanco S.A.', 'Não possui site');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (93, '', '', 'Banco Investimentos BMC SA', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (94, '184', '17.298.092/0001-30', 'Banco Itaú BBA S.A.', 'www.itaubba.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (95, '479', '60.394.079/0001-04', 'Banco ItaúBank S.A', 'www.itaubank.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (96, '', '17.192.451', 'Banco Itaucard S.A.', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (97, '', '59.461.152/0001-34', 'Banco Itaucred Financiamentos S.A.', 'www.itaucred.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (98, '', '49.925.225/0001-48', 'Banco ITAULEASING S.A.', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (99, '376', '33.172.537/0001-98', 'Banco J. P. Morgan S.A.', 'www.jpmorgan.com');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (100, '74', '03.017.677/0001-20', 'Banco J. Safra S.A.', 'www.jsafra.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (101, '217', '91.884.981/0001-32', 'Banco John Deere S.A.', 'www.johndeere.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (102, '76', '7.656.500', 'Banco KDB S.A.', 'www.bancokdb.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (103, '757', '02.318.507/0001-13', 'Banco KEB do Brasil S.A.', 'www.bancokeb.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (104, '600', '59.118.133/0001-00', 'Banco Luso Brasileiro S.A.', 'www.lusobrasileiro.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (105, '243', '33.923.798', 'Banco Máxima S.A.', 'www.bancomaxima.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (106, '', '80.271.455/0001-80', 'Banco Maxinvest S.A.', 'www.bancomaxinvest.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (107, '', '', 'BANCO MERCANTIL DE INVESTIMENTOS SA', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (108, '389', '17.184.037/0001-10', 'Banco Mercantil do Brasil S.A.', 'www.mercantil.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (109, '', '60.814.191', 'Banco Mercedes-Benz S.A.', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (110, '370', '61.088.183/0001-33', 'Banco Mizuho do Brasil S.A.', 'www.mizuhobank.com/brazil/pt/');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (111, '746', '30.723.886/0001-62', 'Banco Modal S.A.', 'www.bancomodal.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (112, '', '7.441.209', 'Banco Moneo S.A.', 'www.bancomoneo.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (113, '738', '43.717.511/0001-31', 'Banco Morada S.A.', 'www.bancomorada.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (114, '', '', 'Banco Morada SA', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (115, '66', '2.801.938', 'Banco Morgan Stanley S.A.', 'www.morganstanley.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (116, '45', '33.857.830/0001-99', 'Banco Opportunity S.A.', 'www.opportunity.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (117, '79', '09.516.419/0001-75', 'Banco Original do Agronegócio S.A.', 'www.bancooriginal.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (118, '212', '92.894.922/0001-08', 'Banco Original S.A.', 'www.bancooriginal.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (119, '', '', 'Banco Ourinvest', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (120, '', '78.632.767/0001-20', 'Banco Ourinvest S.A.', 'www.ourinvest.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (121, '623', '59.285.411/0001-13', 'Banco PAN S.A.', 'www.bancopan.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (122, '611', '61.820.817/0001-09', 'Banco Paulista S.A.', 'www.bancopaulista.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (123, '613', '60.850.229/0001-47', 'Banco Pecúnia S.A.', 'www.bancopecunia.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (124, '', '11.758.741/0001-52', 'Banco Petra S.A.', 'www.personaltrader.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (125, '', '40.429.946/0001-92', 'Banco Porto Real de Investimentos S.A.', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (126, '724', '62.153.721', 'Banco Porto Seguro S.A.', 'Não possui site');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (127, '735', '00.253.448/0001-17', 'Banco Pottencial S.A.', 'www.pottencial.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (128, '638', '33.876.475/0001-03', 'Banco Prosper S.A.', 'www.bancoprosper.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (129, '', '03.502.961/0001-92', 'Banco PSA Finance Brasil S.A.', 'Não possui site');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (130, '747', '01.023.570/0001-60', 'Banco Rabobank International Brasil S.A.', 'www.rabobank.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (131, '', '11.476.673/0001-39', 'Banco Randon S.A.', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (132, '356', '33.066.408/0001-15', 'Banco Real S.A.', 'www.bancoreal.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (133, '633', '68.900.810/0001-38', 'Banco Rendimento S.A.', 'www.rendimento.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (134, '741', '00.517.645/0001-04', 'Banco Ribeirão Preto S.A.', 'www.brp.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (135, '', '33.603.457/0001-40', 'Banco Rodobens S.A.', 'www.rodobens.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (136, '', '', 'Banco Rural de Investimentos SA', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (137, '72', '33.074.683/0001-80', 'Banco Rural Mais S.A.', 'www.rural.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (138, '453', '33.124.959/0001-98', 'Banco Rural S.A.', 'www.rural.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (139, '422', '58.160.789/0001-28', 'Banco Safra S.A.', 'www.safra.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (140, '33', '90.400.888/0001-42', 'Banco Santander (Brasil) S.A.', 'www.santander.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (141, '743', '00.795.423/0001-45', 'Banco Semear S.A.', 'www.bancosemear.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (142, '749', '10.995.587/0001-70', 'Banco Simples S.A.', 'www.bancosimples.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (143, '366', '61.533.584/0001-55', 'Banco Société Générale Brasil S.A.', 'www.sgbrasil.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (144, '637', '60.889.128/0001-80', 'Banco Sofisa S.A.', 'www.sofisa.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (145, '12', '04.866.275/0001-63', 'Banco Standard de Investimentos S.A.', 'www.standardbank.com');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (146, '', '', 'Banco Sudameris Investimento SA', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (147, '464', '60.518.222/0001-22', 'Banco Sumitomo Mitsui Brasileiro S.A.', 'não possue site');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (148, '', '7.679.404', 'Banco Topázio S.A.', 'www.bancotopazio.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (149, '', '03.215.790/0001-10', 'Banco Toyota do Brasil S.A.', 'www.bancotoyota.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (150, '634', '17.351.180/0001-59', 'Banco Triângulo S.A.', 'www.tribanco.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (151, '18', '57.839.805/0001-40', 'Banco Tricury S.A.', 'www.tricury.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (152, '', '59.109.165/0001-49', 'Banco Volkswagen S.A.', 'www.bancovw.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (153, '', '58.017.179/0001-70', 'Banco Volvo (Brasil) S.A.', 'Não possui site');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (154, '655', '59.588.111/0001-03', 'Banco Votorantim S.A.', 'www.bancovotorantim.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (155, '610', '78.626.983/0001-63', 'Banco VR S.A.', 'www.vr.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (156, '119', '13.720.915', 'Banco Western Union do Brasil S.A.', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (157, '', '15.357.060/0001-33', 'Banco Woori Bank do Brasil S.A.', 'www.wooribank.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (158, '', '10.371.492', 'Banco Yamaha Motor S.A.', 'www.yamaha-motor.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (159, '21', '28.127.603/0001-78', 'BANESTES S.A. Banco do Estado do Espírito Santo', 'www.banestes.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (160, '', '', 'Banif Brasil BI SA', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (161, '719', '33.884.941/0001-94', 'Banif-Banco Internacional do Funchal (Brasil)S.A.', 'www.banif.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (162, '755', '62.073.200/0001-21', 'Bank of America Merrill Lynch Banco Múltiplo S.A.', 'www.ml.com');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (163, '744', '33.140.666/0001-02', 'BankBoston N.A.', 'www.bankboston.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (164, '', '', 'BB BANCO DE INVESTIMENTO S A - BB', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (165, '73', '6.043.056', 'BB Banco Popular do Brasil S.A.', 'www.bancopopulardobrasil.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (166, '', '10.264.663/0001-77', 'BBN Banco Brasileiro de Negócios S.A.', 'www.concordiabanco.com');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (167, '250', '50.585.090/0001-06', 'BCV - Banco de Crédito e Varejo S.A.', 'www.bancobcv.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (168, '78', '34.111.187', 'BES Investimento do Brasil S.A.-Banco de Investimento', 'www.besinvestimento.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (169, '', '04.452.473/0001-80', 'BMW Financeira', 'www.bmwfs.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (170, '', '42.272.526/0001-70', 'BNY Mellon Banco S.A.', 'www.bnymellon.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (171, '69', '61.033.106', 'BPN Brasil Banco Múltiplo S.A.', 'www.bpnbrasil.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (172, '', '', 'BR PARTNERS BANCO DE INVESTIMENTO S A', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (173, '125', '45.246.410', 'Brasil Plural S.A. - Banco Múltiplo', 'www.brasilplural.com');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (174, '70', '00.000.208/0001-00', 'BRB - Banco de Brasília S.A.', 'www.brb.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (175, '', '33.136.888/0001-43', 'BRB - Crédito, Financiamento e Investimento S.A.', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (176, '', '12.865.507/0001-97', 'Brickell S.A. Crédito, financiamento e Investimento', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (177, '', '01.149.953/0001-89', 'BV Financeira S.A. - CFI', 'www.bvfinanceira.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (178, '104', '00.360.305/0001-04', 'Caixa Econômica Federal', 'www.caixa.gov.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (179, '', '05.790.149/0001-35', 'Central das Coop. de Economia e Crédito Mutuo do Est. do ES', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (180, '477', '33.042.953/0001-00', 'Citibank S.A.', 'www.citibank.com/brasil');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (181, '', '61.784.278/0001-91', 'Companhia de Crédito, Financ. e Investimento RCI Brasil', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (182, '136', '00.315.557/0001-11', 'CONFEDERACAO NACIONAL DAS COOPERATIVAS CENTRAIS UNICREDS', 'http://www.unicred.com.br/');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (183, '', '04.632.856/0001-30', 'Cooperativa Central de Crédito Noroeste Brasileiro Ltda.', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (184, '', '05.463.212/0001-29', 'Cooperativa Central de Crédito Urbano-CECRED', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (185, '', '03.046.391/0001-73', 'Cooperativa Central de Economia e Credito Mutuo das Unicreds', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (186, '', '73.085.573/0001-39', 'Cooperativa Central de Economia e Crédito Mutuo das Unicreds', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (187, '', '62.109.566/0001-03', 'Cooperativa de Crédito Rural da Região de Mogiana', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (188, '', '00.543.968', 'Cooperativa Unicred Central Santa Catarina', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (189, '', '78.157.146/0001-32', 'CREDIALIANÇA COOPERATIVA DE CRÉDITO RURAL', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (190, '487', '62.331.228/0001-11', 'Deutsche Bank S.A. - Banco Alemão', 'www.deutsche-bank.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (191, '', '00.411.939/0001-49', 'Finamax S/A C. F. I.', 'www.finamax.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (192, '64', '04.332.281/0001-30', 'Goldman Sachs do Brasil Banco Múltiplo S.A.', 'www.goldmansachs.com');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (193, '62', '03.012.230/0001-69', 'Hipercard Banco Múltiplo S.A.', 'www.hipercard.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (194, '399', '01.701.201/0001-89', 'HSBC Bank Brasil S.A. - Banco Múltiplo', 'www.hsbc.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (195, '168', '33.254.319', 'HSBC Finance (Brasil) S.A. - Banco Múltiplo', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (196, '', '', 'ICBC DO BRASIL BANCO MULTIPLO S A - ICBC DO BRASIL', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (197, '492', '49.336.860/0001-90', 'ING Bank N.V.', 'www.ing.com');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (198, '652', '60.872.504/0001-23', 'Itaú Unibanco Holding S.A.', 'www.itau.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (199, '341', '60.701.190/0001-04', 'Itaú Unibanco S.A.', 'www.itau.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (200, '', '', 'J. Malucelli', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (201, '488', '46.518.205/0001-64', 'JPMorgan Chase Bank', 'www.jpmorganchase.com');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (202, '14', '9.274.232', 'Natixis Brasil S.A. Banco Múltiplo', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (203, '753', '74.828.799/0001-45', 'NBC Bank Brasil S.A. - Banco Múltiplo', 'www.nbcbank.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (204, '', '01.432.688/0001-41', 'OBOE Crédito Financiamento e Investimento S.A.', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (205, '', '92.228.410/0001-02', 'Omni SA Crédito Financiamento Investimento', 'www.omni.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (206, '254', '14.388.334/0001-99', 'Paraná Banco S.A.', 'www.paranabanco.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (207, '', '05.503.849/0001-00', 'Santana S.A. Crédito, Financiamento e Investimento', 'www.santanafinanceira.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (208, '', '11.417.016/0001-10', 'Scania Banco S.A.', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (209, '751', '29.030.467/0001-66', 'Scotiabank Brasil S.A. Banco Múltiplo', 'www.br.scotiabank.com');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (210, '', '11.932.017/0001-01', 'Standard Chartered Bank (Brasil) S/A–Bco Invest.', 'www.standardchartered.com');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (211, '', '92.764.489/0001-96', 'Sul Financeira S/A - Crédito, Financiamentos e Investimentos', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (212, '', '', 'UAM - Assessoria e Gestão', '');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (213, '', '18.520.834/0001-93', 'UBS Brasil Banco de Investimento S.A.', 'WWW.UBS.COM');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (214, '409', '33.700.394/0001-40', 'UNIBANCO - União de Bancos Brasileiros S.A.', 'www.unibanco.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (215, '230', '61.071.387/0001-61', 'Unicard Banco Múltiplo S.A.', 'www.unicard.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (216, '', '01.634.601/0001-19', 'Unicred Central do Rio Grande do Sul', 'www.unicred-rs.com.br');
INSERT INTO banks(id, code, cnpj, name, site) VALUES (217, '84', '02.398.976/0001-90', 'Unicred Norte do Paraná', '');

ALTER TABLE public.bank_accounts DROP COLUMN name_bank;
  
ALTER TABLE public.bank_accounts RENAME number_bank  TO bank_id;

ALTER TABLE public.bank_accounts
  ADD COLUMN type integer;
COMMENT ON COLUMN public.bank_accounts.type IS '0 - corrente
1 - poupança';


