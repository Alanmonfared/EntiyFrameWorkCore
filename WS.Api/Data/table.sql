
CREATE TABLE Categories (
Id int not null identity primary key,
Category nvarchar(50) not null unique,

)

CREATE TABLE Products (
	Id int not null identity primary key,
	Name nvarchar(150) not null,
	ShortDescription nvarchar(max) not null,
	Price money not null,
	InStock bit not null,
	Img varchar(200) not null,
	CategoryId int not null references Categories(Id)
)

CREATE TABLE ProductDetails (
	Id int not null references Products(Id) primary key,
	LongDescriotion nvarchar(max) not null,


)



CREATE TABLE DeliveryTypes (
	Id int not null identity primary key,
	Name nvarchar(50) not null unique
)

CREATE TABLE Addresses (
	Id int not null identity primary key,
	AddressLine nvarchar(100) not null,
	HouseNr smallint null,
	ZipCode char(5) not null,
	City nvarchar(50) not null
)

CREATE TABLE Customers (
	Id int not null identity primary key,
	FirstName nvarchar(50) not null,
	LastName nvarchar(50) not null,
	Email varchar(100) not null unique
)
GO
