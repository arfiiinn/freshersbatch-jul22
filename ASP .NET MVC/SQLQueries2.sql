CREATE DATABASE PKRTravels

CREATE TABLE BusInfo (BusID int PRIMARY KEY IDENTITY(,1),
					  BoardingPoint varchar(3),
					  TravelDate Date, 
					  Amount decimal(5,2),
					  Rating int)

SELECT * FROM BusInfo

TRUNCATE TABLE BusInfo

INSERT INTO BusInfo VALUES ('BGL','2017-06-18',400.65,2)
INSERT INTO BusInfo VALUES ('HYD','2017-10-05',600.00,3)
INSERT INTO BusInfo VALUES ('CHN','2016-07-25',445.95,3)
INSERT INTO BusInfo VALUES ('PUN','2017-12-10',543.00,4)
INSERT INTO BusInfo VALUES ('MUM','2017-01-28',500.50,4)
INSERT INTO BusInfo VALUES ('PUN','2016-03-27',333.55,3)
INSERT INTO BusInfo VALUES ('MUM','2016-11-06',510.00,4)

CREATE PROCEDURE AddBusDetails
@BoardingPoint varchar(3), @TravelDate Date, @Amount decimal(5,2), @Rating int
AS
BEGIN
	INSERT INTO BusInfo VALUES (@BoardingPoint,@TravelDate,@Amount,@Rating)
END
