-- Created by Vertabelo (http://vertabelo.com)
-- Last modification date: 2020-01-16 23:00:49.448

-- foreign keys
ALTER TABLE ACH_CUSTOMER_ALERGEN DROP CONSTRAINT ACH_CUSTOMER_ALERGEN_ACH_CUSTOMER;

ALTER TABLE ACH_CUSTOMER_ALERGEN DROP CONSTRAINT ACH_CUSTOMER_ALERGEN_ACH_INGREDIENT;

ALTER TABLE ACH_ORDER DROP CONSTRAINT ACH_ORDER_ACH_CUSTOMER;

ALTER TABLE ACH_ORDER_ADDITIVE DROP CONSTRAINT ACH_ORDER_ADDITIVE_ACH_ADDITIVE;

ALTER TABLE ACH_ORDER_ADDITIVE DROP CONSTRAINT ACH_ORDER_ADDITIVE_ACH_ORDER;

ALTER TABLE ACH_ORDER_PIZZA DROP CONSTRAINT ACH_ORDER_COMPOSITION_ACH_ORDER;

ALTER TABLE ACH_ORDER_PIZZA DROP CONSTRAINT ACH_ORDER_PIZZA_ACH_PIZZA;

ALTER TABLE ACH_PIZZA_COMPOSITION DROP CONSTRAINT ACH_PIZZA_COMPOSITION_ACH_INGREDIENT;

ALTER TABLE ACH_PIZZA_COMPOSITION DROP CONSTRAINT ACH_PIZZA_COMPOSITION_ACH_PIZZA;

-- tables
DROP TABLE ACH_ADDITIVE;

DROP TABLE ACH_CUSTOMER;

DROP TABLE ACH_CUSTOMER_ALERGEN;

DROP TABLE ACH_INGREDIENT;

DROP TABLE ACH_ORDER;

DROP TABLE ACH_ORDER_ADDITIVE;

DROP TABLE ACH_ORDER_PIZZA;

DROP TABLE ACH_PIZZA;

DROP TABLE ACH_PIZZA_COMPOSITION;

-- End of file.

