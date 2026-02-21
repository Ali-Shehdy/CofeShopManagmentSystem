Select * From users;

INSERT INTO users (username, password, profile_image, role, status, date_reg)
VALUES ('Alishehdy', 'Melina127652', NULL, 'Admin', 'active', '2025-12-12');

CREATE TABLE products
(
id INT PRIMARY KEY IDENTITY(1,1),
prod_id VARCHAR(MAX) NULL,
prod_name VARCHAR(MAX) NULL,
prod_type VARCHAR(MAX)NULL,
prod_stock INT NULL,
prod_price FLOAT NULL,
prod_status VARCHAR (MAX) NULL,
prod_image VARCHAR(MAX) NULL,
date_incert DATE NULL,
date_update DATE NULL,
date_delete DATE NULL
)
