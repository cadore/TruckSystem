CREATE TABLE accounts_to_pay
(
  id bigserial NOT NULL,
  chave character varying,
  "number" character varying,
  serie integer,
  customer_id bigint,
  emission_at timestamp without time zone,
  value_products numeric(19,2),
  value_freight numeric(19,2),
  value_security numeric(19,2),
  value_discount numeric(19,2),
  value_ipi numeric(19,2),
  CONSTRAINT "PK_accounts_to_pay_id" PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);

ALTER TABLE accounts_to_pay
  OWNER TO postgres;
  
ALTER TABLE accounts_to_pay
  ADD COLUMN description character varying;

ALTER TABLE accounts_to_pay
  ADD COLUMN observations text;
  
 ALTER TABLE payments
  ADD COLUMN account_id bigint;
  
ALTER TABLE accounts_to_pay
  ADD COLUMN guid_payment character varying;
  
ALTER TABLE accounts_to_pay
  ADD COLUMN truck_id bigint;

CREATE TABLE categorys
(
   id bigserial NOT NULL, 
   type integer, 
   name character varying, 
   CONSTRAINT "PK_categorys_id" PRIMARY KEY (id)
) 
WITH (
  OIDS = FALSE
);
ALTER TABLE payments
  ADD COLUMN category_id integer;
  
ALTER TABLE accounts_to_pay
  ADD COLUMN category_id integer;

  //Ja aplicadas dia 26/10/2015
  
