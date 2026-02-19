CREATE DATABASE AddressBookDB;
GO

USE AddressBookDB;
GO

CREATE TABLE Contacts (
    ContactId INT PRIMARY KEY,
    FirstName NVARCHAR(100),
    LastName NVARCHAR(100),
    Address NVARCHAR(200),
    City NVARCHAR(100),
    State NVARCHAR(100),
    ZipCode NVARCHAR(20),
    Country NVARCHAR(100),
    PhoneNumber NVARCHAR(20),
    Email NVARCHAR(150)
);
