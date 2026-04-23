CREATE TABLE users
(
	id INT PRIMARY KEY IDENTITY(1, 1),
	username VARCHAR(MAX) NULL,
	password VARCHAR(MAX) NULL,
	profile_image VARCHAR(MAX) NULL,
	role VARCHAR(MAX) NULL,
	status VARCHAR(MAX) NULL,
	date_reg DATE NULL
)
GO

SELECT * FROM users
GO

INSERT INTO users (username, password, profile_image, role, status, date_reg) VALUES ('admin', 'admin123', '', 'Admin', 'Active', '2024-10-20')
GO 

CREATE TABLE products
(
	id INT PRIMARY KEY IDENTITY(1,1),
	prod_id VARCHAR(MAX) NULL,
	prod_name VARCHAR(MAX) NULL,
	prod_type VARCHAR(MAX) NULL,
	prod_stock INT NULL,
	prod_price FLOAT NULL,
	prod_status VARCHAR(MAX) NULL,
	prod_image VARCHAR(MAX) NULL,
	date_insert DATETIME NULL,
	date_update DATE NULL,
	date_delete DATE NULL
)
GO


SELECT * FROM products
GO

CREATE TABLE orders
(
	id INT PRIMARY KEY IDENTITY(1,1),
	customer_id INT NULL,
	prod_id VARCHAR(MAX) NULL,
	prod_name VARCHAR(MAX) NULL,
	prod_type VARCHAR(MAX) NULL,
	prod_price FLOAT NULL,
	order_date DATE NULL,
	delete_order DATE NULL
)
GO

SELECT * FROM orders
GO

CREATE TABLE orders
(
	id INT PRIMARY KEY IDENTITY(1,1),
	customer_id INT NULL,
	prod_id VARCHAR(MAX) NULL,
	prod_type VARCHAR(MAX) NULL,
	prod_price FLOAT NULL,
	order_date DATE NULL,
	delete_order DATE NULL
)
GO

ALTER TABLE orders
ADD qty INT NULL

CREATE TABLE customers 
(
	id INT PRIMARY KEY IDENTITY(1,1),
	customer_id INT NULL,
	total_price FLOAT NULL,
	date DATE NULL
)
GO

SELECT * FROM customers

ALTER TABLE customers
ADD amount FLOAT NULL,
change FLOAT NULL
GO

ALTER TABLE customers
ADD users VARCHAR(MAX) NULL


DELETE FROM users
WHERE role = 'Cashier';

SELECT * FROM users

SELECT status FROM users WHERE username = 'test1' AND password = '123'