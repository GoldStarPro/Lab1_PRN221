
USE [master]
GO

CREATE DATABASE MyStock
GO

-- DROP DATABASE MyStock

USE MyStock
GO

CREATE TABLE Car (
	CarID INT NOT NULL PRIMARY KEY,	
	CarName NVARCHAR(50) NOT NULL,
	Manufacturer NVARCHAR(50) NOT NULL,
	Price MONEY NOT NULL,
	ReleasedYear INT NOT NULL
)

INSERT INTO Car(CarID,CarName,Manufacturer,Price,ReleasedYear)
VALUES
(1,'Accord','Honda Motor Company',24970.000,2021),
(2,'BMW 8 Series','BMW',85000.000,2021),
(3,'Clarity','Honda Motor Company',33400.000,2021),
(4,'Audi A6','Audi',14000.000,2021),
(5,'Everest Titanium 2.0L AT 4WD','Ford',60000.000,2021),
(6,'Ranger Wildtrak 2.0L AT 4X4','Ford',40000.000,2021),
(7,'Lexus IS','Lexus',100000.000,2021),
(8,'Lexus IS 300h','Lexus',220000.000,2021)

