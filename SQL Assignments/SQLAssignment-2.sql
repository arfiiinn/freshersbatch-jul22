/*SQL Assignment 2*/

/*Display the details from Customer Table who is from country Germany.*/

SELECT * FROM Customer
WHERE Country = 'Germany'

/*Display the fullname of employee.*/

CREATE TABLE EMPLOYEE(
	id int NOT NULL PRIMARY KEY,
	FirstName nvarchar(40) NOT NULL,
	LastName nvarchar(40) NOT NULL,
	Email nvarchar(50) UNIQUE NOT NULL,
	Phone nvarchar(20),
	City nvarchar(40),
	ManagerName nvarchar(50)
)

INSERT INTO EMPLOYEE VALUES (1,'Arfin','Zain','arfin@gmail.com',1231231234,'Mumbai','Shilpa')
INSERT INTO EMPLOYEE VALUES (2,'Aariz','Sayyed','aariz@gmail.com',1234123456,'Navi Mumbai','Arfin')
INSERT INTO EMPLOYEE VALUES (3,'Aman','Rawal','aman@gmail.com',1231231233,'Thane',NULL)


SELECT FirstName, LastName FROM EMPLOYEE

/*Display all customer who have fax number. */ 

ALTER TABLE Customer
ADD Fax nvarchar(10) 

SELECT FirstName, LastName FROM Customer 
WHERE Fax IS NOT NULL

/* Display the customer details whose name holds second letter as U. */

SELECT * FROM CUSTOMER 
WHERE FirstName LIKE '_U%'

/*Select order details where unit price is greater than 10 and less than 20.*/

SELECT o.id, o.OrderNumber, o.OrderDate, i.UnitPrice
FROM OrderItem i
INNER JOIN Orders o
ON o.id = i.OrderId
WHERE UnitPrice BETWEEN 10 AND 20

/*Display order details which contains shipping date and arrange the order by date.*/

ALTER TABLE Orders
ADD ShippingDate DATE, 
    ShipName nvarchar(80)

SELECT * FROM Orders
WHERE ShippingDate IS NOT NULL 
ORDER BY ShippingDate ASC

/*Print the orders shipped by shipname 'La come d'abondance' between 2 dates.*/

SELECT * FROM Orders
WHERE ShipName ='La come d''abondance' AND ShippingDate BETWEEN '2022-07-11' AND '2022-07-31'
 
/*Print the products supplied by Exotic Liquids.*/

AlTER TABLE Product
ADD SuppliedBy nvarchar(50)

SELECT ProductName FROM Product
WHERE SuppliedBy = 'Exotic Liquids'

/*Print the average quantity ordered for every product.*/

SELECT ProductName, AVG(Quantity) AS [Average Quanity]
FROM Product
JOIN OrderItem
ON OrderItem.ProductId = Product.id
GROUP BY ProductName

SELECT ProductId, AVG(Quantity) AS [Average Quanity]
FROM OrderItem 
GROUP BY ProductId

/* Print all the shopping company name and the ship names if they are operational. */

CREATE TABLE ShipmentDetails (
	id int PRIMARY KEY,
	ShipName nvarchar(50),
	ShippingCompany nvarchar(80),
	isOperational bit
)

INSERT INTO ShipmentDetails VALUES (1,'BlueDart','BlueDart',1)
INSERT INTO ShipmentDetails VALUES (2,'DTDC','DTDC',0)
INSERT INTO ShipmentDetails VALUES (3,'La come d''abondance','La come d''abondance',1)

SELECT * FROM ShipmentDetails

SELECT ShippingCompany, ShipName FROM ShipmentDetails
WHERE isOperational = 1


/* Print all employees with Manager Name. */

SELECT FirstName, LastName, Email, Phone, City FROM EMPLOYEE
WHERE ManagerName IS NOT NULL

/*Print the bill for a given order id.bill should contain Productname, Categoryname, price after discount.*/

SELECT OrderItem.[OrderId], Product.[ProductName], Product.[Category], OrderItem.[UnitPrice] AS [Price Before Discount],OrderItem.[DiscountPrice] 
FROM OrderItem
INNER JOIN Orders 
ON Orders.id= OrderItem.OrderId
INNER JOIN Product 
ON Product.[id]=OrderItem.[ProductId]
WHERE OrderItem.[OrderId]= 001


/*Print the total price of orders which have the products supplied by 'Exotic Liquids' if the price is > 50 and also print it by shipping company's name.*/

 SELECT Product.[SuppliedBy], Product.[UnitPrice] AS [Total Price] ,ShipmentDetails.[ShippingCompany] AS [Shipping Company Name] FROM Product
INNER JOIN ShipmentDetails 
ON ShipmentDetails.[id]= Product.[ShipNameId]
WHERE Product.SuppliedBy = 'Exotic Liquids' AND Product.[UnitPrice]>50

