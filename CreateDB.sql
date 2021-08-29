--�������� ��
CREATE DATABASE DBSHOP
ON
PRIMARY
(
NAME = SHOP_PRIMARY,
 FILENAME = 'E:\MSQL\DATA2\SHOP_PRIMARY.mdf',
 SIZE = 5MB,
 MAXSIZE = 10MB,
 FILEGROWTH = 20%
 )
 LOG ON
 (
 NAME = SHOP_LOG,
 FILENAME = 'E:\MSQL\DATA2\SHOP_LOG.ldf',
 SIZE = 2MB,
 MAXSIZE = 5MB,
 FILEGROWTH = 1MB
 );
 create type PriceMoney From decimal(10,2);
 --�������� ������
 CREATE TABLE Category
 (
 IdCategory  INT IDENTITY(1,1) PRIMARY KEY,
 Name NVARCHAR(50) NOT NULL
 );
 --������� ���������
 CREATE TABLE Product
 (
 IdProduct  INT IDENTITY(1,1) PRIMARY KEY,
 TypeProduct NVARCHAR(50) NOT NULL,
 Color NVARCHAR(50) NOT NULL,
 Material NVARCHAR(50) NOT NULL,
 Price PriceMoney NOT NULL check(Price>0),
 CategoriId INT NOT NULL FOREIGN KEY  REFERENCES Category(IdCategory) ON DELETE CASCADE 
 );
 --������� ��������� �����������
 CREATE TABLE Customer
(
IdCustomer INT IDENTITY(1,1) PRIMARY KEY,
FirstNameCustomer NVARCHAR(50) NOT NULL,
MidleNameCustomer NVARCHAR(50) NOT NULL,
LastNameCustomer NVARCHAR(50) NOT NULL,
DeliveryAddress NVARCHAR(50) NOT NULL
);
--������� ���������
CREATE TABLE Driver 
(
IdDriver INT IDENTITY(1,1) PRIMARY KEY,
FirstNameDriver NVARCHAR(50) NOT NULL,
MidleNameDriver NVARCHAR(50) NOT NULL,
LastNameDriver NVARCHAR(50) NOT NULL,
StatusDriver NVARCHAR(50) NOT NULL,
);
--������� �������
CREATE TABLE OrderInShop
(
IdOrder INT IDENTITY(1,1) PRIMARY KEY,
StatusOrder NVARCHAR(50) NOT NULL,
CustomerId INT NOT NULL FOREIGN KEY  REFERENCES Customer(IdCustomer),
ProductId INT NOT NULL FOREIGN KEY  REFERENCES Product(IdProduct),
DriverId INT  FOREIGN KEY  REFERENCES Driver(IdDriver)
);
--������� ������ � ����������
CREATE TABLE WorkerInKompany
(
IdWorker INT IDENTITY(1,1) PRIMARY KEY,
FirstNameWorker NVARCHAR(50) NOT NULL,
MidleNameWorker NVARCHAR(50) NOT NULL,
LastNameWorker NVARCHAR(50) NOT NULL,
TypeWorker  VARCHAR(50) NOT NULL,
CategoryId INT FOREIGN KEY  REFERENCES Category(IdCategory) On DELETE CASCADE,
Price PriceMoney NOT NULL check(Price>0),
CONSTRAINT CHK_Worker CHECK ((CategoryId!=NULL AND Typeworker='������������')Or Typeworker!='������������')
);
--������� ��� ����������� ������� � ����������
CREATE TABLE AdminWorker
(
IdAdmin INT IDENTITY(1,1) PRIMARY KEY,
LoginWorker NVARCHAR(50) NOT NULL,
ParolWorker NVARCHAR(50) NOT NULL,
Dostup NVARCHAR(50) NOT NULL,
WorkerId INT FOREIGN KEY  REFERENCES WorkerInKompany(IdWorker)ON DELETE  CASCADE ON UPDATE CASCADE,
unique(LoginWorker)
);
--�������� ��������
CREATE Nonclustered INDEX index_CATEGORYProduct ON product(categoriId);
CREATE Nonclustered INDEX  index_SratusDriver ON Driver(StatusDriver);
CREATE Nonclustered INDEX index_FIOWorker on  WorkerInKompany(FirstNameWorker,MidleNameWorker, LastNameWorker)

--�������� ��������
--��������� ���������� ��������
CREATE PROCEDURE AddDriver(@FirstName Nvarchar(50),@MiddleName Nvarchar(50),@LastName Nvarchar(50))
AS
INSERT INTO Driver(FirstNameDriver,MidleNameDriver,LastNameDriver,StatusDriver) 
VALUES(@FirstName,@MiddleName,@LastName,'��������');


--��������� �������� ��������
CREATE PROCEDURE DeleteDriver(@Id INT)
AS
Delete from  Driver 
where Driver.IdDriver=@Id;

--��������� ���������� ���������� 
CREATE PROCEDURE AddCustomer(@FirstName Nvarchar(50),@MiddleName Nvarchar(50),@LastName Nvarchar(50),@Address Nvarchar(50))
AS
INSERT INTO Customer(FirstNameCustomer,MidleNameCustomer,LastNameCustomer,DeliveryAddress) 
VALUES(@FirstName,@MiddleName,@LastName,@Address);

--��������� ���������� ��������
CREATE PROCEDURE AddProduct
(@TypeProduct NVARCHAR(50),@Color NVARCHAR(50),@Material NVARCHAR(50),@Price PriceMoney,@Categori NVARCHAR(50))
AS
begin
DECLARE @CategoriId INT
Select @CategoriId=  IdCategory from Category where Name = @Categori
If(@CategoriId=NULL)return - 1
INSERT INTO Product(TypeProduct,Color,Material,Price,CategoriId)
VALUES(@TypeProduct,@Color,@Material,@Price,@CategoriId)
end;

--��������� �������� ��������
CREATE PROCEDURE DeleteProduct(@id INT )
AS
begin
DELETE FROM Product 
WHERE product.IdProduct=@id
end;

--��������� ����������� ���������
CREATE PROCEDURE AddCategory(@Name Nvarchar(50))
AS
INSERT INTO Category(Name) 
VALUES(@Name);

--��������� �������� ���������
CREATE PROCEDURE DeleteCategory(@Name Nvarchar(50))
AS
DELETE From Category WHERE Category.Name=@Name;
--��������� ���������� ��������
CREATE PROCEDURE AddWorkerInProduction
(@FirstName Nvarchar(50),@MiddleName Nvarchar(50),@LastName Nvarchar(50),@Category Nvarchar(50),@Price PriceMoney)
AS
BEGIN
DECLARE  @CategoriId INT
Select @CategoriId=  IdCategory from Category where Name = @Category
INSERT INTO WorkerInKompany(FirstNameWorker,MidleNameWorker,LastNameWorker,TypeWorker,CategoryId,Price)
VALUES(@FirstName,@MiddleName,@LastName,'������������',@CategoriId,@Price)
END;


-- ��������� �������� ��������
CREATE PROCEDURE DeleteWorkerInProduction(@ID int)
AS
BEGIN
DELETE FROM WorkerInKompany WHERE IdWorker=@ID;
END;
--��������� ���������� ������ � ���������
CREATE PROCEDURE AddWorkerOrAdmin --
(@FirstName Nvarchar(50),@MiddleName Nvarchar(50),@LastName Nvarchar(50),
@Price PriceMoney,@TypeWorker Nvarchar(50),@Login Nvarchar(50), @Parol Nvarchar(50))
AS
BEGIN
INSERT INTO WorkerInKompany(FirstNameWorker,MidleNameWorker,LastNameWorker,TypeWorker,Price)
VALUES(@FirstName,@MiddleName,@LastName,@TypeWorker,@Price)
DECLARE @IdWorker INT
SET  @IdWorker= SCOPE_IDENTITY()
INSERT INTO AdminWorker(LoginWorker,ParolWorker,WorkerId,Dostup)
VALUES(@Login,@Parol,@IdWorker,@TypeWorker)
END;

--���������� ������
CREATE PROCEDURE AddOrder
(@FirstName Nvarchar(50),@MiddleName Nvarchar(50),@LastName Nvarchar(50),@Address Nvarchar(50),@IDProduct INT)
AS
BEGIN
EXEC AddCustomer @FirstName,@MiddleName,@LastName,@Address
DECLARE @IdCustomer INT
SELECT @IdCustomer = Customer.IdCustomer From Customer
Where FirstNameCustomer=@FirstName AND
MidleNameCustomer =@MiddleName AND
LastNameCustomer = @LastName
INSERT INTO  OrderInShop(CustomerId,ProductId,StatusOrder)
VALUES(@IdCustomer,@IDProduct,'�� ���������')
DECLARE @IdOrder INT
SET  @IdOrder= SCOPE_IDENTITY()
RETURN @IdOrder
END;
--��������� ��� ��������� ������� ������ �� ������ �� ������ ���������
CREATE PROCEDURE OrderAreManufactured(@Id INT)
AS
IF ((Select top(1) OrderInShop.StatusOrder From OrderInShop where IdOrder = @Id)!='�� ���������')
return -1
UPDATE  OrderInShop
Set StatusOrder = '����� � ��������'
Where IdOrder = @Id;

--��������� ��� ��������� ������� ������ �� ������ �� ������ � ����
CREATE Procedure OrderDevileryBegin(@IdOrder INT,@IdDriver INT)
AS
BEGIN
IF ((Select top(1) Driver.StatusDriver From Driver where IdDriver = @IdDriver)!='�����'
AND(Select top(1) OrderInShop.StatusOrder From OrderInShop where IdOrder = @IdOrder)!='����� � ��������')
return -1
UPDATE  OrderInShop
Set StatusOrder = '� ����',
DriverId = @IdDriver
Where IdOrder = @IdOrder
UPDATE  Driver
Set StatusDriver ='�����'
Where IdDriver = @IdDriver
END;
--��������� ��� ������� ������� ������ �� ���������
CREATE Procedure OrderDevileryEnd(@IdOrder INT)
AS
BEGIN
IF ((Select top(1) OrderInShop.StatusOrder From OrderInShop where IdOrder = @IdOrder)!='� ����')
return -1
UPDATE  Driver
Set StatusDriver ='��������'
Where IdDriver = (Select OrderInShop.DriverId From OrderInShop
Where IdOrder=@IdOrder)
Update OrderInShop
Set StatusOrder = '���������'
Where IdOrder=@IdOrder
END;
--��������� ��� ��������� �������� ���������
CREATE PROCEDURE NewPriseWorker(@Id INT,@newPrice PriceMoney)
AS
BEGIN
UPDATE WorkerInKompany
Set Price = @newPrice
Where IdWorker = @Id
END;
--��������� ��� ��������� ���� ��������
CREATE PROCEDURE NewPriceProduct(@Id INT,@newPrice PriceMoney)
AS
BEGIN
UPDATE Product
Set Price = @newPrice
Where IdProduct = @Id
END;

--������� ������������ ������ �� ������ � ������
CREATE FUNCTION GetDostup(@Login NVARCHAR(50),@Parol NVARCHAR(50))
RETURNS NVARCHAR(50)
AS
BEGIN
DECLARE @DOSTUP NVARCHAR(50)
Select top(1) @DOSTUP = Dostup From AdminWorker 
where LoginWorker= @Login AND ParolWorker =@Parol;
RETURN @DOSTUP
END;
-- ��������� ������� ������������ ��������� ��������
CREATE FUNCTION IncomeCompany()
RETURNS INT
AS
BEGIN
DECLARE @sum INT;
SELECT @sum = SUM(Product.Price) FROM OrderInShop 
INNER JOIN Product ON OrderInShop.ProductId = Product.IdProduct
Group BY Product.IdProduct
RETURN @sum
END;
--������� ������������ ���������� ��������� ���������
CREATE FUNCTION NumberOfItemSold(@IdProduct INT)
RETURNS INT
AS
BEGIN
DECLARE @count INT;
SELECT @count = count(OrderInShop.IdOrder)  
FROM OrderInShop
WHERE OrderInShop.ProductId=@IdProduct
RETURN @count
END;
--��������� �������
CREATE FUNCTION NumberOfItemsSold()
RETURNS TABLE
AS
RETURN(
SELECT  Product.IdProduct AS'����� ��������', Product.TypeProduct AS '��� ������',
Product.Material AS '��������',Product.Color AS '����', Product.Price AS '����',
dbo.NumberOfItemSold(Product.IdProduct) AS'���������� ���������'
FROM product
);
--������� ������������ ������ �� ������ ������
CREATE FUNCTION OrderCustomerStautus(@IdOrder INT)
RETURNS Varchar(50)
 AS
BEGIN 
DECLARE @Name NVarchar(50);
Select top(1) @Name = OrderInShop.StatusOrder From OrderInShop
Where IdOrder=@IdOrder;
RETURN @Name
END;


--������������� ���������
CREATE VIEW ListProducts
AS 
Select Product.IdProduct AS '��� ��������',dbo.StringFormat(Category.Name) AS'��������� ��������', dbo.StringFormat(Product.TypeProduct) AS '��� ��������',
dbo.StringFormat(Product.Material) AS'��������',dbo.StringFormat(Product.Color) As'����', Product.Price As'����'
FROM Product
INNER JOIN Category ON Product.CategoriId= Category.IdCategory;
--������������� ���������
CREATE VIEW ListDriver
As
Select IdDriver As'��� ��������',dbo.StringFormat(FirstNameDriver) As'��� ��������',dbo.StringFormat(MidleNameDriver) AS '�������� ��������',
dbo.StringFormat(LastNameDriver) AS'������� ��������',dbo.StringFormat(StatusDriver) As ������ From Driver;
--������������� ��������� ��������� 
CREATE VIEW ListDriverOpen 
AS
Select IdDriver As'��� ��������',dbo.StringFormat(FirstNameDriver) As'��� ��������',dbo.StringFormat(MidleNameDriver) AS '�������� ��������',
dbo.StringFormat(LastNameDriver) AS'������� ��������' From Driver
where StatusDriver ='��������';
--������������� ���������
CREATE VIEW ListCategory
AS
Select IdCategory As'��� ������',dbo.StringFormat(category.Name) As'�������� ������' From Category;

--������������� ����������
CREATE VIEW LISTWORKER 
AS
SELECT WorkerInKompany.IdWorker AS'��� ����������', dbo.StringFormat(WorkerInKompany.FirstNameWorker) As'���',
dbo.StringFormat(WorkerInKompany.MidleNameWorker) As'��������',dbo.StringFormat(WorkerInKompany.LastNameWorker) As'�������',
dbo.StringFormat(WorkerInKompany.TypeWorker) As'��������� ���������',WorkerInKompany.Price As'��������',
AdminWorker.LoginWorker As'�����',AdminWorker.ParolWorker As'������',dbo.StringFormat(Category.Name) As'�����'
FROM WorkerInKompany
LEFT JOIN AdminWorker ON WorkerInKompany.IdWorker= AdminWorker.WorkerId
LEFT JOIN Category ON WorkerInKompany.CategoryId=Category.IdCategory;
--������������� �������
CREATE VIEW LISTORDER
AS
SELECT OrderInShop.IdOrder AS'��� ������',OrderInShop.ProductId As '��� ������',
dbo.StringFormat(Customer.FirstNameCustomer) As'��� ���������',dbo.StringFormat(Customer.MidleNameCustomer) As '�������� ���������',
dbo.StringFormat(Customer.LastNameCustomer) As'������� ���������',Customer.DeliveryAddress As'����� ��������',
Driver.IdDriver As'��� ��������',dbo.StringFormat(Driver.FirstNameDriver) As'��� ��������',dbo.StringFormat(Driver.MidleNameDriver) AS '�������� ��������',
dbo.StringFormat(Driver.LastNameDriver) AS'������� ��������',dbo.StringFormat(OrderInShop.StatusOrder) As '������ ������'
FROM OrderInShop
LEFT JOIN Driver ON OrderInShop.DriverId= Driver.IdDriver
LEFT JOIN Customer ON OrderInShop.CustomerId=Customer.IdCustomer;


--������ ����������� ���� ���� ����� ������� �� ������ �� ���������
CREATE TRIGGER trigger1 On Customer
Instead of insert
AS
Declare @FirstName NVARCHAR(50)
Declare @MiddleName NVARCHAR(50)
Declare @LastName  NVARCHAR(50)
Declare @DevilaryAddres NVARCHAR(50)
Select @FirstName = FirstNameCustomer,@MiddleName=MidleNameCustomer,
@LastName=LastNameCustomer,@DevilaryAddres=DeliveryAddress
From inserted
if not exists( SELECT *From Customer
Where FirstNameCustomer=@FirstName AND
MidleNameCustomer =@MiddleName AND
LastNameCustomer = @LastName)
Insert Customer Select FirstNameCustomer,MidleNameCustomer,LastNameCustomer,DeliveryAddress From inserted;



--CLR Functia
EXEC sp_configure 'clr enabled',1;
RECONFIGURE
alter database DBSHOP set trustworthy on;
go
create assembly CLRFunction1
from 'E:\univer\��\��\tr\CLRFunction1\CLRFunction1\bin\Debug\CLRFunction1.dll'
with permission_set = unsafe;
go

CREATE FUNCTION StringFormat(@str nvarchar(50))
Returns nvarchar(50)
AS
EXTERNAL NAME CLRFunction1.[CLRFunction1.Class1].StringFormat;




EXEC AddCategory '������ ������';
EXEC AddDriver '��������','����','�����������'
EXEC AddProduct '�����','�����','����',30000.00,'������ ������';
EXEC AddOrder'������','����','��������','��.���������� �.10 ��.32',1
EXEC AddWorkerInProduction'��������','����','�����������','������ ������',40000.00;
EXEC AddWorkerOrAdmin  '�������','����','�����������',60000.00,'�������������','AEE','1111';
EXEC AddWorkerOrAdmin  '������','��������','�������',50000.00,'���������� ������ ������ � ��������','ABB','1111';


Select * from ListProducts;
Select * FROM ListDriver;
Select * FROM ListCategory;
Select * FROM LISTWORKER;
Select * FROM LISTORDER;
EXEC OrderAreManufactured 1;
EXEC OrderDevileryBegin 1, 1;



