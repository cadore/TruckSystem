ALTER TABLE public.drivers
  ADD COLUMN register_cnh character varying;
  
ALTER TABLE public.drivers
  ADD COLUMN mother_name character varying;

CREATE TABLE public.deposits
(
  id bigint NOT NULL DEFAULT nextval('deposits_id_seq'::regclass),
  account_id bigint,
  date date,
  customer_id bigint,
  value numeric(19,2),
  description character varying,
  type integer, -- (0 dinheiro, 1 cheque)
  truck_id bigint,
  freight_id bigint,
  CONSTRAINT "PK_deposits_id" PRIMARY KEY (id)
);
COMMENT ON COLUMN public.deposits.type IS '(0 - dinheiro, 1 - cheque)';

ALTER TABLE public.payments
  DROP COLUMN paid_date;
ALTER TABLE public.payments
  DROP COLUMN value_paid;
ALTER TABLE public.payments
  DROP COLUMN reason_expiration;
ALTER TABLE public.payments
  DROP COLUMN is_payment;


