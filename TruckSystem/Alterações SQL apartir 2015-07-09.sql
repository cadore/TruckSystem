ALTER TABLE fueleds ALTER COLUMN value_liters TYPE numeric(19,3);
ALTER TABLE stays RENAME value  TO value_hor;
ALTER TABLE stays ADD COLUMN total numeric(19,2);
ALTER TABLE stays ADD COLUMN taxe_comission numeric(19,2);
ALTER TABLE stays ADD COLUMN total_comission numeric(19,2);
ALTER TABLE payments ADD COLUMN guid character varying(4096);
DROP TABLE gas_stations;