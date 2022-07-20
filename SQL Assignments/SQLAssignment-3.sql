--SQL Assignment 3

--Write a query to display the orders placed by customer with phone number 030-0074321

SELECT Customer.[FirstName], Customer.[LastName], Orders.[OrderDate], Orders.[TotalAmount]
FROM Customer
INNER JOIN Orders
ON Customer.[id] = Orders.[CustomerId]
WHERE Phone = '030-0074321'

SELECT * FROM Customer
SELECT * FROM Orders
SELECT * FROM OrderItem
SELECT * FROM Product

--Fetching all the products which are available under Category ‘Seafood’.

Select ProductName, UnitPrice, Package,SuppliedBy, Category FROM Product
WHERE Category = 'Seafood'

--Display the orders placed by customers not in London.

SELECT Customer.[FirstName], Customer.[LastName], Customer.[City], Customer.[Country], Orders.[OrderNumber],Orders.[OrderDate], Orders.[TotalAmount]
FROM Customer
INNER JOIN Orders
ON Customer.[id] = Orders.[CustomerId]
WHERE City <> 'London'

--Select all the order which are placed for the product Chai.

SELECT  Product.[ProductName], Product.[Category], Orders.[OrderNumber], Orders.[OrderDate], OrderItem.[UnitPrice], OrderItem.[DiscountPrice]
FROM Product
INNER JOIN OrderItem ON Product.[id] = OrderItem.[ProductId]
INNER JOIN Orders ON Orders.[id] = OrderItem.[OrderId]
WHERE Product.[ProductName] = 'Chai'

--Write a query to display the name , department name and rating  of any given employee. 

SELECT CONCAT(e.FirstName,' ', e.LastName) AS Name, Department, Rating
FROM EMPLOYEE e 
WHERE id = 1

