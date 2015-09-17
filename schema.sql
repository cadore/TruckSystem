--
-- PostgreSQL database dump
--

-- Dumped from database version 9.3.4
-- Dumped by pg_dump version 9.4.4
-- Started on 2015-09-04 17:32:24

SET statement_timeout = 0;
SET lock_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SET check_function_bodies = false;
SET client_min_messages = warning;

--
-- TOC entry 200 (class 3079 OID 11755)
-- Name: plpgsql; Type: EXTENSION; Schema: -; Owner: 
--

CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;


--
-- TOC entry 2085 (class 0 OID 0)
-- Dependencies: 200
-- Name: EXTENSION plpgsql; Type: COMMENT; Schema: -; Owner: 
--

COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';


SET search_path = public, pg_catalog;

SET default_tablespace = '';

SET default_with_oids = false;

--
-- TOC entry 170 (class 1259 OID 42404)
-- Name: address; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE address (
    id bigint NOT NULL,
    name character varying,
    district character varying,
    city_id bigint,
    state_id bigint,
    number character varying,
    complement character varying,
    cep character varying
);


ALTER TABLE address OWNER TO postgres;

--
-- TOC entry 171 (class 1259 OID 42410)
-- Name: address_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE address_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE address_id_seq OWNER TO postgres;

--
-- TOC entry 2086 (class 0 OID 0)
-- Dependencies: 171
-- Name: address_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE address_id_seq OWNED BY address.id;


--
-- TOC entry 172 (class 1259 OID 42412)
-- Name: bank_accounts; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE bank_accounts (
    id bigint NOT NULL,
    number_bank bigint,
    name_bank character varying,
    agency character varying,
    account character varying,
    holder character varying,
    document character varying,
    registred_at timestamp without time zone,
    registred_by bigint
);


ALTER TABLE bank_accounts OWNER TO postgres;

--
-- TOC entry 173 (class 1259 OID 42418)
-- Name: bank_accounts_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE bank_accounts_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE bank_accounts_id_seq OWNER TO postgres;

--
-- TOC entry 2087 (class 0 OID 0)
-- Dependencies: 173
-- Name: bank_accounts_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE bank_accounts_id_seq OWNED BY bank_accounts.id;


--
-- TOC entry 174 (class 1259 OID 42420)
-- Name: city; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE city (
    id integer NOT NULL,
    name character varying,
    cod_ibge integer,
    state_id integer,
    population integer,
    demographic numeric,
    gentilic character varying(250),
    area numeric,
    zip_code character varying
);


ALTER TABLE city OWNER TO postgres;

--
-- TOC entry 175 (class 1259 OID 42426)
-- Name: city_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE city_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE city_id_seq OWNER TO postgres;

--
-- TOC entry 2088 (class 0 OID 0)
-- Dependencies: 175
-- Name: city_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE city_id_seq OWNED BY city.id;


--
-- TOC entry 176 (class 1259 OID 42428)
-- Name: customers; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE customers (
    id bigint NOT NULL,
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
    type integer
);


ALTER TABLE customers OWNER TO postgres;

--
-- TOC entry 177 (class 1259 OID 42434)
-- Name: customers_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE customers_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE customers_id_seq OWNER TO postgres;

--
-- TOC entry 2089 (class 0 OID 0)
-- Dependencies: 177
-- Name: customers_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE customers_id_seq OWNED BY customers.id;


--
-- TOC entry 178 (class 1259 OID 42436)
-- Name: drivers; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE drivers (
    id bigint NOT NULL,
    full_name character varying,
    cpf character varying,
    address bigint,
    birthday date,
    number_cnh character varying,
    category_cnh character varying,
    genre integer,
    phone_fixed character varying,
    phone_mobile character varying,
    inactive boolean,
    registred_at timestamp without time zone,
    registred_by bigint,
    comission numeric(19,2),
    admitted_at date,
    dismissed_at date,
    expiration_cnh date,
    document character varying
);


ALTER TABLE drivers OWNER TO postgres;

--
-- TOC entry 179 (class 1259 OID 42442)
-- Name: drivers_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE drivers_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE drivers_id_seq OWNER TO postgres;

--
-- TOC entry 2090 (class 0 OID 0)
-- Dependencies: 179
-- Name: drivers_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE drivers_id_seq OWNED BY drivers.id;


--
-- TOC entry 180 (class 1259 OID 42444)
-- Name: freights; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE freights (
    id bigint NOT NULL,
    registred_at timestamp without time zone,
    registred_by bigint,
    inactive boolean,
    truck_id bigint,
    driver_id bigint,
    number_note integer,
    number_cte integer,
    company_source bigint,
    company_destination bigint,
    product character varying,
    start date,
    "end" date,
    weight numeric(19,3),
    value_ton numeric(19,2),
    value_comission numeric(19,2),
    discounts_comission numeric(19,2),
    extra_comission numeric(19,2),
    observations character varying(4096),
    carrier bigint,
    taxe_comission numeric(19,2)
);


ALTER TABLE freights OWNER TO postgres;

--
-- TOC entry 181 (class 1259 OID 42450)
-- Name: freights_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE freights_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE freights_id_seq OWNER TO postgres;

--
-- TOC entry 2091 (class 0 OID 0)
-- Dependencies: 181
-- Name: freights_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE freights_id_seq OWNED BY freights.id;


--
-- TOC entry 182 (class 1259 OID 42452)
-- Name: fueleds; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE fueleds (
    id bigint NOT NULL,
    freight_id bigint,
    truck_id bigint,
    driver_id bigint,
    date date,
    km character varying,
    gas_station_id bigint,
    liters numeric(19,2),
    value_liters numeric(19,3),
    discount numeric(19,2),
    registred_at timestamp without time zone,
    registred_by bigint,
    total numeric(19,2)
);


ALTER TABLE fueleds OWNER TO postgres;

--
-- TOC entry 183 (class 1259 OID 42458)
-- Name: fueleds_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE fueleds_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE fueleds_id_seq OWNER TO postgres;

--
-- TOC entry 2092 (class 0 OID 0)
-- Dependencies: 183
-- Name: fueleds_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE fueleds_id_seq OWNED BY fueleds.id;


--
-- TOC entry 184 (class 1259 OID 42468)
-- Name: logins; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE logins (
    id bigint NOT NULL,
    user_id bigint,
    host character varying,
    date timestamp without time zone,
    local_ip character varying,
    external_ip character varying
);


ALTER TABLE logins OWNER TO postgres;

--
-- TOC entry 185 (class 1259 OID 42474)
-- Name: logins_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE logins_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE logins_id_seq OWNER TO postgres;

--
-- TOC entry 2093 (class 0 OID 0)
-- Dependencies: 185
-- Name: logins_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE logins_id_seq OWNED BY logins.id;


--
-- TOC entry 186 (class 1259 OID 42476)
-- Name: outputs; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE outputs (
    id bigint NOT NULL,
    description character varying,
    observation text,
    customer_id bigint,
    truck_id bigint,
    freight_id bigint,
    registred_at timestamp without time zone,
    registred_by bigint,
    date date,
    value numeric(19,2)
);


ALTER TABLE outputs OWNER TO postgres;

--
-- TOC entry 187 (class 1259 OID 42482)
-- Name: outputs_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE outputs_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE outputs_id_seq OWNER TO postgres;

--
-- TOC entry 2094 (class 0 OID 0)
-- Dependencies: 187
-- Name: outputs_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE outputs_id_seq OWNED BY outputs.id;


--
-- TOC entry 188 (class 1259 OID 42484)
-- Name: payments; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE payments (
    id bigint NOT NULL,
    description character varying,
    expiration_date date,
    paid_date date,
    value numeric(19,2),
    value_paid numeric(19,2),
    observation text,
    customer_id bigint,
    truck_id bigint,
    freight_id bigint,
    reason_expiration character varying(2048),
    paid boolean DEFAULT false,
    is_payment boolean,
    registred_at timestamp without time zone,
    registred_by bigint,
    guid character varying(4096)
);


ALTER TABLE payments OWNER TO postgres;

--
-- TOC entry 189 (class 1259 OID 42491)
-- Name: payments_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE payments_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE payments_id_seq OWNER TO postgres;

--
-- TOC entry 2095 (class 0 OID 0)
-- Dependencies: 189
-- Name: payments_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE payments_id_seq OWNED BY payments.id;


--
-- TOC entry 190 (class 1259 OID 42493)
-- Name: states; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE states (
    id integer NOT NULL,
    name character varying,
    symbol character varying
);


ALTER TABLE states OWNER TO postgres;

--
-- TOC entry 191 (class 1259 OID 42499)
-- Name: states_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE states_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE states_id_seq OWNER TO postgres;

--
-- TOC entry 2096 (class 0 OID 0)
-- Dependencies: 191
-- Name: states_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE states_id_seq OWNED BY states.id;


--
-- TOC entry 192 (class 1259 OID 42501)
-- Name: stays; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE stays (
    id bigint NOT NULL,
    freight_id bigint,
    truck_id bigint,
    driver_id bigint,
    registred_by bigint,
    registred_at timestamp without time zone,
    start timestamp without time zone,
    "end" timestamp without time zone,
    value_hor numeric(19,2),
    total numeric(19,2),
    taxe_comission numeric(19,2),
    total_comission numeric(19,2)
);


ALTER TABLE stays OWNER TO postgres;

--
-- TOC entry 193 (class 1259 OID 42504)
-- Name: stays_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE stays_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE stays_id_seq OWNER TO postgres;

--
-- TOC entry 2097 (class 0 OID 0)
-- Dependencies: 193
-- Name: stays_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE stays_id_seq OWNED BY stays.id;


--
-- TOC entry 194 (class 1259 OID 42506)
-- Name: trailers; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE trailers (
    id bigint NOT NULL,
    board character varying,
    renavam character varying,
    chassi character varying,
    mark character varying,
    model character varying,
    year_fabrication integer,
    year_model integer,
    registred_by bigint,
    registred_at timestamp without time zone,
    truck_id bigint,
    index bigint,
    antt integer,
    color character varying
);


ALTER TABLE trailers OWNER TO postgres;

--
-- TOC entry 195 (class 1259 OID 42512)
-- Name: trailers_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE trailers_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE trailers_id_seq OWNER TO postgres;

--
-- TOC entry 2098 (class 0 OID 0)
-- Dependencies: 195
-- Name: trailers_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE trailers_id_seq OWNED BY trailers.id;


--
-- TOC entry 196 (class 1259 OID 42514)
-- Name: trucks; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE trucks (
    id bigint NOT NULL,
    board character varying,
    renavam character varying,
    chassi character varying,
    mark character varying,
    model character varying,
    year_fabrication integer,
    year_model integer,
    registred_by bigint,
    registred_at timestamp without time zone,
    color character varying,
    driver_id bigint,
    antt integer
);


ALTER TABLE trucks OWNER TO postgres;

--
-- TOC entry 197 (class 1259 OID 42520)
-- Name: trucks_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE trucks_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE trucks_id_seq OWNER TO postgres;

--
-- TOC entry 2099 (class 0 OID 0)
-- Dependencies: 197
-- Name: trucks_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE trucks_id_seq OWNED BY trucks.id;


--
-- TOC entry 198 (class 1259 OID 42522)
-- Name: users; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE users (
    id bigint NOT NULL,
    full_name character varying,
    password character varying(4096),
    cpf character varying,
    inactive boolean,
    admin boolean,
    money boolean
);


ALTER TABLE users OWNER TO postgres;

--
-- TOC entry 199 (class 1259 OID 42528)
-- Name: users_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE users_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE users_id_seq OWNER TO postgres;

--
-- TOC entry 2100 (class 0 OID 0)
-- Dependencies: 199
-- Name: users_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE users_id_seq OWNED BY users.id;


--
-- TOC entry 1925 (class 2604 OID 42530)
-- Name: id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY address ALTER COLUMN id SET DEFAULT nextval('address_id_seq'::regclass);


--
-- TOC entry 1926 (class 2604 OID 42531)
-- Name: id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY bank_accounts ALTER COLUMN id SET DEFAULT nextval('bank_accounts_id_seq'::regclass);


--
-- TOC entry 1927 (class 2604 OID 42532)
-- Name: id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY city ALTER COLUMN id SET DEFAULT nextval('city_id_seq'::regclass);


--
-- TOC entry 1928 (class 2604 OID 42533)
-- Name: id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY customers ALTER COLUMN id SET DEFAULT nextval('customers_id_seq'::regclass);


--
-- TOC entry 1929 (class 2604 OID 42534)
-- Name: id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY drivers ALTER COLUMN id SET DEFAULT nextval('drivers_id_seq'::regclass);


--
-- TOC entry 1930 (class 2604 OID 42535)
-- Name: id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY freights ALTER COLUMN id SET DEFAULT nextval('freights_id_seq'::regclass);


--
-- TOC entry 1931 (class 2604 OID 42536)
-- Name: id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY fueleds ALTER COLUMN id SET DEFAULT nextval('fueleds_id_seq'::regclass);


--
-- TOC entry 1932 (class 2604 OID 42538)
-- Name: id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY logins ALTER COLUMN id SET DEFAULT nextval('logins_id_seq'::regclass);


--
-- TOC entry 1933 (class 2604 OID 42539)
-- Name: id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY outputs ALTER COLUMN id SET DEFAULT nextval('outputs_id_seq'::regclass);


--
-- TOC entry 1935 (class 2604 OID 42540)
-- Name: id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY payments ALTER COLUMN id SET DEFAULT nextval('payments_id_seq'::regclass);


--
-- TOC entry 1936 (class 2604 OID 42541)
-- Name: id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY states ALTER COLUMN id SET DEFAULT nextval('states_id_seq'::regclass);


--
-- TOC entry 1937 (class 2604 OID 42542)
-- Name: id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY stays ALTER COLUMN id SET DEFAULT nextval('stays_id_seq'::regclass);


--
-- TOC entry 1938 (class 2604 OID 42543)
-- Name: id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY trailers ALTER COLUMN id SET DEFAULT nextval('trailers_id_seq'::regclass);


--
-- TOC entry 1939 (class 2604 OID 42544)
-- Name: id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY trucks ALTER COLUMN id SET DEFAULT nextval('trucks_id_seq'::regclass);


--
-- TOC entry 1940 (class 2604 OID 42545)
-- Name: id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY users ALTER COLUMN id SET DEFAULT nextval('users_id_seq'::regclass);


--
-- TOC entry 1942 (class 2606 OID 42547)
-- Name: PK_address_id; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY address
    ADD CONSTRAINT "PK_address_id" PRIMARY KEY (id);


--
-- TOC entry 1944 (class 2606 OID 42549)
-- Name: PK_bank_accounts_id; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY bank_accounts
    ADD CONSTRAINT "PK_bank_accounts_id" PRIMARY KEY (id);


--
-- TOC entry 1948 (class 2606 OID 42551)
-- Name: PK_customers_id; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY customers
    ADD CONSTRAINT "PK_customers_id" PRIMARY KEY (id);


--
-- TOC entry 1950 (class 2606 OID 42553)
-- Name: PK_drivers_id; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY drivers
    ADD CONSTRAINT "PK_drivers_id" PRIMARY KEY (id);


--
-- TOC entry 1952 (class 2606 OID 42555)
-- Name: PK_freights_id; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY freights
    ADD CONSTRAINT "PK_freights_id" PRIMARY KEY (id);


--
-- TOC entry 1954 (class 2606 OID 42557)
-- Name: PK_fueleds_id; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY fueleds
    ADD CONSTRAINT "PK_fueleds_id" PRIMARY KEY (id);


--
-- TOC entry 1956 (class 2606 OID 42561)
-- Name: PK_logins_id; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY logins
    ADD CONSTRAINT "PK_logins_id" PRIMARY KEY (id);


--
-- TOC entry 1958 (class 2606 OID 42563)
-- Name: PK_outputs_id; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY outputs
    ADD CONSTRAINT "PK_outputs_id" PRIMARY KEY (id);


--
-- TOC entry 1960 (class 2606 OID 42565)
-- Name: PK_payments_id; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY payments
    ADD CONSTRAINT "PK_payments_id" PRIMARY KEY (id);


--
-- TOC entry 1964 (class 2606 OID 42567)
-- Name: PK_stays_id; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY stays
    ADD CONSTRAINT "PK_stays_id" PRIMARY KEY (id);


--
-- TOC entry 1966 (class 2606 OID 42569)
-- Name: PK_trailers_id; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY trailers
    ADD CONSTRAINT "PK_trailers_id" PRIMARY KEY (id);


--
-- TOC entry 1968 (class 2606 OID 42571)
-- Name: PK_trucks_id; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY trucks
    ADD CONSTRAINT "PK_trucks_id" PRIMARY KEY (id);


--
-- TOC entry 1970 (class 2606 OID 42573)
-- Name: PK_users_id; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY users
    ADD CONSTRAINT "PK_users_id" PRIMARY KEY (id);


--
-- TOC entry 1946 (class 2606 OID 42575)
-- Name: pk_city_id; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY city
    ADD CONSTRAINT pk_city_id PRIMARY KEY (id);


--
-- TOC entry 1962 (class 2606 OID 42577)
-- Name: pk_state_id; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY states
    ADD CONSTRAINT pk_state_id PRIMARY KEY (id);


--
-- TOC entry 2084 (class 0 OID 0)
-- Dependencies: 6
-- Name: public; Type: ACL; Schema: -; Owner: postgres
--

REVOKE ALL ON SCHEMA public FROM PUBLIC;
REVOKE ALL ON SCHEMA public FROM postgres;
GRANT ALL ON SCHEMA public TO postgres;
GRANT ALL ON SCHEMA public TO PUBLIC;


-- Completed on 2015-09-04 17:32:25

--
-- PostgreSQL database dump complete
--

