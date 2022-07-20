/* SQL Assignment 1*/

/* Creating Database */
CREATE DATABASE Assignment

/*Creating Tables with Primary and Foreign Keys*/

CREATE TABLE Customer (
	id int NOT NULL PRIMARY KEY ,
	FirstName nvarchar(40),
	LastName nvarchar(40),
	City nvarchar(40),
	Country nvarchar(50),
	Phone nvarchar(20),
)

CREATE TABLE Orders (
	id int NOT NULL PRIMARY KEY ,
	OrderDate datetime,
	OrderNumber nvarchar(10),
	CustomerId int FOREIGN KEY REFERENCES Customer(id) ON DELETE CASCADE,
	TotalAmount decimal(12,2),
)

CREATE TABLE Product(
	id int NOT NULL PRIMARY KEY,
	ProductName nvarchar(50),
	UnitPrice decimal (12,2),
	Package nvarchar(30),
	isDiscontinued bit
)

CREATE TABLE OrderItem (
	id int NOT NULL PRIMARY KEY,
	OrderId int FOREIGN KEY REFERENCES Orders(id) ON DELETE CASCADE,
	ProductId int FOREIGN KEY REFERENCES Product(id) ON DELETE CASCADE,
	UnitPrice decimal (12,2),
	Quantity int
)

/*SELECT Statements for each table*/

SELECT * FROM Customer
SELECT * FROM Orders
SELECT * FROM Product
SELECT * FROM OrderItem

/*Adding Records*/

INSERT INTO Customer VALUES (1, 'Arfin', 'Sayyed', 'Mumbai', 'India',1231231231)
INSERT INTO Customer VALUES (2, 'Maziya', 'Shaikh', 'Melbourne', 'Australia',4564564564)
INSERT INTO Customer VALUES (3, 'Tasneem', 'Goawala', 'Sydney', 'Australia',7897897897)
INSERT INTO Customer VALUES (4, 'Aariz', 'Sayyed', 'Berlin', 'Germany',3213213213)

SELECT * FROM Customer

INSERT INTO Orders VALUES (1,'2022-07-07 07:06:45',001 , 1,5000)
INSERT INTO Orders VALUES (2,'2022-07-08 08:30:02',002 , 2,300)
INSERT INTO Orders VALUES (3,'2022-07-08 10:07:00',003 , 2,200)
INSERT INTO Orders VALUES (4,'2022-07-09 11:06:45',004 , 3,5500)

SELECT * FROM Orders

INSERT INTO Product VALUES (1,'Wine', 400,'Box', 0)
INSERT INTO Product VALUES (2,'Sparkling Water', 40,'Plastic', 0)
INSERT INTO Product VALUES (3,'Mineral Water', 20,'Plastic', 1)
INSERT INTO Product VALUES (4,'Chocolate',10,'Box', 1)

SELECT * FROM Product

INSERT INTO OrderItem VALUES (1,1,1,400,1)
INSERT INTO OrderItem VALUES (2,2,2,40,2)
INSERT INTO OrderItem VALUES (3,3,3,20,2)
INSERT INTO OrderItem VALUES (4,4,4,10,1)

SELECT * FROM OrderItem

/*In Customer Table, FirstName should not accept null values.*/

ALTER TABLE Customer ALTER COLUMN [FirstName] nvarchar(40) NOT NULL

INSERT INTO Customer VALUES (5,'Aman', 'Rawal', 'California', 'United States',3213213213)

/*In Orders Table, Order Date should not accept null value.*/

ALTER TABLE Orders ALTER COLUMN [OrderDate] datetime NOT NULL
2022-07-15 02:06:04
INSERT INTO Orders VALUES (5,,005, 4,50)

/*Display all Customer Details*/

SELECT * FROM Customer

/*Write a query to display country whose name starts with A or I*/

SELECT Country FROM Customer
WHERE Country LIKE 'A%' OR Country LIKE 'I%'

/*Write a query to display Name of Customer whose third character is i */

SELECT FirstName From Customer
WHERE FirstName LIKE '__i%'

