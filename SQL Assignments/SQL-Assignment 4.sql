/*SQL Assignment 4*/

/*1.Print the Total price of orders which have the products supplied by 'Exotic Liquids' if the price is > 50 and also print it by Shipping company's Name*/

SELECT Product.[SuppliedBy], Product.[UnitPrice] AS [Total Price] ,ShipmentDetails.[ShippingCompany] AS [Shipping Company Name] FROM Product
INNER JOIN ShipmentDetails 
ON ShipmentDetails.[id]= Product.[ShipNameId]
WHERE Product.SuppliedBy = 'Exotic Liquids' AND Product.[UnitPrice]>50

/*2.Display the employee details whose joined at first*/

SELECT TOP 1 * FROM EMPLOYEE
ORDER BY DOJ ASC 

/*3.Display the employee details whose joined at recently*/

SELECT TOP 1 * FROM EMPLOYEE
ORDER BY DOJ DESC 

/*4.Write a query to get most expense and least expensive Product list (name and unit price).*/

SELECT ProductName, UnitPrice 
FROM Product 
ORDER BY UnitPrice DESC

/*5.Display the list of products that are out of stock*/

SELECT ProductName FROM Product
WHERE isAvailable = 0

/*6.Display the list of products whose unitinstock is less than unitonorder*/

SELECT p.[ProductName], p.[UnitsinStock] AS [Units in Stock],o.[Quantity] AS [Units on Order]
FROM Product p
INNER JOIN OrderItem o
ON p.[id] = o.[ProductId]
WHERE p.UnitsinStock < o.Quantity

/*7.Display list of categories and suppliers who supply products within those categories*/

SELECT Category, SuppliedBy 
FROM Product

/*8.Display complete list of customers, the OrderID and date of any orders they have made*/

SELECT CONCAT(c.FirstName,' ',c.LastName) AS [Full Name], c.Phone, c.City, c.Country, o.OrderNumber, o.OrderDate
FROM Customer c
INNER JOIN Orders o 
ON c.id = o.CustomerId
WHERE c.id = o.CustomerId

/*9.Write  query that determines the customer who has placed the maximum number of orders*/

SELECT CustomerId, COUNT(CustomerId) AS [ Maximum Orders Placed ]
FROM Orders
GROUP BY CustomerId
HAVING COUNT(Customerid) > 1

/*10.Display the customerid whose name has substring ‘RA’*/

SELECT * FROM Customer WHERE SUBSTRING(FirstName,1,2)='RA'

/*11.Display the first word of all the company name*/

SELECT SUBSTRING(ShippingCompany,1,(CHARINDEX(' ', ShippingCompany + ' ')-1)) AS [First Word of Company Name]
FROM ShipmentDetails