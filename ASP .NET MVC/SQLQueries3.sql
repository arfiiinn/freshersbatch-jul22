CREATE DATABASE CustomerDataModel

CREATE TABLE Customer(
	CustomerID int PRIMARY KEY IDENTITY(1,1),
	CustomerName varchar(100),
	City varchar(100),
	Age	int,
	Phone int,
	Pincode int
)

INSERT INTO Customer VALUES ('Arfin Sayyed','Mumbai',21,1234567890,401107)

SELECT * FROM Customer

CREATE PROCEDURE AddCustomer 
	@CustomerName varchar,
	@City varchar(100),
	@Age	int,
	@Phone int,
	@Pincode int
AS
BEGIN
	INSERT INTO Customer VALUES (@CustomerName,@City,@Age,@Phone,@Pincode)
END

CREATE PROCEDURE ModifyCustomer
	@CustomerID int,
	@CustomerName varchar(100),
	@City varchar(100),
	@Age	int,
	@Phone int,
	@Pincode int
AS
BEGIN
	UPDATE Customer
	SET
		CustomerName = @CustomerID,
		City = @City,
		Age = @Age,
		Phone = @Phone,
		Pincode = @Pincode
	WHERE CustomerID = @CustomerID
END

CREATE PROCEDURE DeleteCustomer
@CustomerID int
AS
BEGIN
	DELETE FROM Customer
	WHERE CustomerID = @CustomerID
END

CREATE PROCEDURE SearchCustomer
@CustomerID int, @CustomerName varchar(100)
AS 
BEGIN
	SELECT * FROM Customer
	WHERE CustomerID = @CustomerID OR CustomerName like '%' + @CustomerName + '%'
END

EXECUTE SearchCustomer 1, NULL
EXECUTE SearchCustomer NULL, 'Arfin'
EXECUTE SearchCustomer 1,'Arfin'
EXECUTE SearchCustomer NULL,NULL