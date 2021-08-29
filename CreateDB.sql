--Создание БД
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
 --Создание таблиц
 CREATE TABLE Category
 (
 IdCategory  INT IDENTITY(1,1) PRIMARY KEY,
 Name NVARCHAR(50) NOT NULL
 );
 --Таблица продуктов
 CREATE TABLE Product
 (
 IdProduct  INT IDENTITY(1,1) PRIMARY KEY,
 TypeProduct NVARCHAR(50) NOT NULL,
 Color NVARCHAR(50) NOT NULL,
 Material NVARCHAR(50) NOT NULL,
 Price PriceMoney NOT NULL check(Price>0),
 CategoriId INT NOT NULL FOREIGN KEY  REFERENCES Category(IdCategory) ON DELETE CASCADE 
 );
 --Таблица продуктов покупателей
 CREATE TABLE Customer
(
IdCustomer INT IDENTITY(1,1) PRIMARY KEY,
FirstNameCustomer NVARCHAR(50) NOT NULL,
MidleNameCustomer NVARCHAR(50) NOT NULL,
LastNameCustomer NVARCHAR(50) NOT NULL,
DeliveryAddress NVARCHAR(50) NOT NULL
);
--Таблица водителей
CREATE TABLE Driver 
(
IdDriver INT IDENTITY(1,1) PRIMARY KEY,
FirstNameDriver NVARCHAR(50) NOT NULL,
MidleNameDriver NVARCHAR(50) NOT NULL,
LastNameDriver NVARCHAR(50) NOT NULL,
StatusDriver NVARCHAR(50) NOT NULL,
);
--Таблица заказов
CREATE TABLE OrderInShop
(
IdOrder INT IDENTITY(1,1) PRIMARY KEY,
StatusOrder NVARCHAR(50) NOT NULL,
CustomerId INT NOT NULL FOREIGN KEY  REFERENCES Customer(IdCustomer),
ProductId INT NOT NULL FOREIGN KEY  REFERENCES Product(IdProduct),
DriverId INT  FOREIGN KEY  REFERENCES Driver(IdDriver)
);
--Таблица данных о работниках
CREATE TABLE WorkerInKompany
(
IdWorker INT IDENTITY(1,1) PRIMARY KEY,
FirstNameWorker NVARCHAR(50) NOT NULL,
MidleNameWorker NVARCHAR(50) NOT NULL,
LastNameWorker NVARCHAR(50) NOT NULL,
TypeWorker  VARCHAR(50) NOT NULL,
CategoryId INT FOREIGN KEY  REFERENCES Category(IdCategory) On DELETE CASCADE,
Price PriceMoney NOT NULL check(Price>0),
CONSTRAINT CHK_Worker CHECK ((CategoryId!=NULL AND Typeworker='Производство')Or Typeworker!='Производство')
);
--Таблица для организации доступа в приложении
CREATE TABLE AdminWorker
(
IdAdmin INT IDENTITY(1,1) PRIMARY KEY,
LoginWorker NVARCHAR(50) NOT NULL,
ParolWorker NVARCHAR(50) NOT NULL,
Dostup NVARCHAR(50) NOT NULL,
WorkerId INT FOREIGN KEY  REFERENCES WorkerInKompany(IdWorker)ON DELETE  CASCADE ON UPDATE CASCADE,
unique(LoginWorker)
);
--Создание Индексов
CREATE Nonclustered INDEX index_CATEGORYProduct ON product(categoriId);
CREATE Nonclustered INDEX  index_SratusDriver ON Driver(StatusDriver);
CREATE Nonclustered INDEX index_FIOWorker on  WorkerInKompany(FirstNameWorker,MidleNameWorker, LastNameWorker)

--Создание процедур
--Процедура добовления водителя
CREATE PROCEDURE AddDriver(@FirstName Nvarchar(50),@MiddleName Nvarchar(50),@LastName Nvarchar(50))
AS
INSERT INTO Driver(FirstNameDriver,MidleNameDriver,LastNameDriver,StatusDriver) 
VALUES(@FirstName,@MiddleName,@LastName,'Свободен');


--Процедура удаления водителя
CREATE PROCEDURE DeleteDriver(@Id INT)
AS
Delete from  Driver 
where Driver.IdDriver=@Id;

--Процедура добовления покупателя 
CREATE PROCEDURE AddCustomer(@FirstName Nvarchar(50),@MiddleName Nvarchar(50),@LastName Nvarchar(50),@Address Nvarchar(50))
AS
INSERT INTO Customer(FirstNameCustomer,MidleNameCustomer,LastNameCustomer,DeliveryAddress) 
VALUES(@FirstName,@MiddleName,@LastName,@Address);

--Процедура добовления продукта
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

--Процедура удаления продукта
CREATE PROCEDURE DeleteProduct(@id INT )
AS
begin
DELETE FROM Product 
WHERE product.IdProduct=@id
end;

--Процедура удобовления категории
CREATE PROCEDURE AddCategory(@Name Nvarchar(50))
AS
INSERT INTO Category(Name) 
VALUES(@Name);

--Процедура удаления категории
CREATE PROCEDURE DeleteCategory(@Name Nvarchar(50))
AS
DELETE From Category WHERE Category.Name=@Name;
--Процедура добовления продукта
CREATE PROCEDURE AddWorkerInProduction
(@FirstName Nvarchar(50),@MiddleName Nvarchar(50),@LastName Nvarchar(50),@Category Nvarchar(50),@Price PriceMoney)
AS
BEGIN
DECLARE  @CategoriId INT
Select @CategoriId=  IdCategory from Category where Name = @Category
INSERT INTO WorkerInKompany(FirstNameWorker,MidleNameWorker,LastNameWorker,TypeWorker,CategoryId,Price)
VALUES(@FirstName,@MiddleName,@LastName,'Производство',@CategoriId,@Price)
END;


-- Процедура удаления продукта
CREATE PROCEDURE DeleteWorkerInProduction(@ID int)
AS
BEGIN
DELETE FROM WorkerInKompany WHERE IdWorker=@ID;
END;
--Процедура добавления данных о работнике
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

--Добавление заказа
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
VALUES(@IdCustomer,@IDProduct,'На изготовке')
DECLARE @IdOrder INT
SET  @IdOrder= SCOPE_IDENTITY()
RETURN @IdOrder
END;
--Процедура для изменения статуса товара по номеру на статус изготовка
CREATE PROCEDURE OrderAreManufactured(@Id INT)
AS
IF ((Select top(1) OrderInShop.StatusOrder From OrderInShop where IdOrder = @Id)!='На изготовке')
return -1
UPDATE  OrderInShop
Set StatusOrder = 'Готов к доставке'
Where IdOrder = @Id;

--Процедура для изменения статуса товара по номеру на статус в пути
CREATE Procedure OrderDevileryBegin(@IdOrder INT,@IdDriver INT)
AS
BEGIN
IF ((Select top(1) Driver.StatusDriver From Driver where IdDriver = @IdDriver)!='Занят'
AND(Select top(1) OrderInShop.StatusOrder From OrderInShop where IdOrder = @IdOrder)!='Готов к доставке')
return -1
UPDATE  OrderInShop
Set StatusOrder = 'В Пути',
DriverId = @IdDriver
Where IdOrder = @IdOrder
UPDATE  Driver
Set StatusDriver ='Занят'
Where IdDriver = @IdDriver
END;
--Процедура для измения статуса товара на доставлен
CREATE Procedure OrderDevileryEnd(@IdOrder INT)
AS
BEGIN
IF ((Select top(1) OrderInShop.StatusOrder From OrderInShop where IdOrder = @IdOrder)!='В Пути')
return -1
UPDATE  Driver
Set StatusDriver ='Свободен'
Where IdDriver = (Select OrderInShop.DriverId From OrderInShop
Where IdOrder=@IdOrder)
Update OrderInShop
Set StatusOrder = 'Доставлен'
Where IdOrder=@IdOrder
END;
--Процедура для изменения зарплаты работника
CREATE PROCEDURE NewPriseWorker(@Id INT,@newPrice PriceMoney)
AS
BEGIN
UPDATE WorkerInKompany
Set Price = @newPrice
Where IdWorker = @Id
END;
--Процедура для изменения цены продукта
CREATE PROCEDURE NewPriceProduct(@Id INT,@newPrice PriceMoney)
AS
BEGIN
UPDATE Product
Set Price = @newPrice
Where IdProduct = @Id
END;

--Функция возвращающая доступ по логину и поролю
CREATE FUNCTION GetDostup(@Login NVARCHAR(50),@Parol NVARCHAR(50))
RETURNS NVARCHAR(50)
AS
BEGIN
DECLARE @DOSTUP NVARCHAR(50)
Select top(1) @DOSTUP = Dostup From AdminWorker 
where LoginWorker= @Login AND ParolWorker =@Parol;
RETURN @DOSTUP
END;
-- Скалярная функция возвращающая заработок компании
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
--функция возвращающая Количество проданных продуктов
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
--Табличная Функция
CREATE FUNCTION NumberOfItemsSold()
RETURNS TABLE
AS
RETURN(
SELECT  Product.IdProduct AS'НОМЕР ПРОДУКТА', Product.TypeProduct AS 'ТИП МЕБЕЛИ',
Product.Material AS 'МАТЕРИАЛ',Product.Color AS 'ЦВЕТ', Product.Price AS 'ЦЕНА',
dbo.NumberOfItemSold(Product.IdProduct) AS'КОЛИЧЕСТВО ПРОДАННЫХ'
FROM product
);
--Функция Возвращающая Статус по номеру заказа
CREATE FUNCTION OrderCustomerStautus(@IdOrder INT)
RETURNS Varchar(50)
 AS
BEGIN 
DECLARE @Name NVarchar(50);
Select top(1) @Name = OrderInShop.StatusOrder From OrderInShop
Where IdOrder=@IdOrder;
RETURN @Name
END;


--Представление продуктов
CREATE VIEW ListProducts
AS 
Select Product.IdProduct AS 'Код продукта',dbo.StringFormat(Category.Name) AS'Категория продукта', dbo.StringFormat(Product.TypeProduct) AS 'Тип Продукта',
dbo.StringFormat(Product.Material) AS'Материал',dbo.StringFormat(Product.Color) As'Цвет', Product.Price As'Цена'
FROM Product
INNER JOIN Category ON Product.CategoriId= Category.IdCategory;
--Представление водителей
CREATE VIEW ListDriver
As
Select IdDriver As'Код водителя',dbo.StringFormat(FirstNameDriver) As'Имя водителя',dbo.StringFormat(MidleNameDriver) AS 'Отчество водителя',
dbo.StringFormat(LastNameDriver) AS'Фамилия водителя',dbo.StringFormat(StatusDriver) As Статус From Driver;
--Представление Свободных водителей 
CREATE VIEW ListDriverOpen 
AS
Select IdDriver As'Код водителя',dbo.StringFormat(FirstNameDriver) As'Имя водителя',dbo.StringFormat(MidleNameDriver) AS 'Отчество водителя',
dbo.StringFormat(LastNameDriver) AS'Фамилия водителя' From Driver
where StatusDriver ='Свободен';
--Представление категорий
CREATE VIEW ListCategory
AS
Select IdCategory As'Код отдела',dbo.StringFormat(category.Name) As'Название отдела' From Category;

--Представление работников
CREATE VIEW LISTWORKER 
AS
SELECT WorkerInKompany.IdWorker AS'код сотрудника', dbo.StringFormat(WorkerInKompany.FirstNameWorker) As'Имя',
dbo.StringFormat(WorkerInKompany.MidleNameWorker) As'Отчество',dbo.StringFormat(WorkerInKompany.LastNameWorker) As'Фамилия',
dbo.StringFormat(WorkerInKompany.TypeWorker) As'должность сотрудник',WorkerInKompany.Price As'Зарплата',
AdminWorker.LoginWorker As'Логин',AdminWorker.ParolWorker As'Пароль',dbo.StringFormat(Category.Name) As'Отдел'
FROM WorkerInKompany
LEFT JOIN AdminWorker ON WorkerInKompany.IdWorker= AdminWorker.WorkerId
LEFT JOIN Category ON WorkerInKompany.CategoryId=Category.IdCategory;
--Представление заказов
CREATE VIEW LISTORDER
AS
SELECT OrderInShop.IdOrder AS'Код заказа',OrderInShop.ProductId As 'Код товара',
dbo.StringFormat(Customer.FirstNameCustomer) As'Имя заказчика',dbo.StringFormat(Customer.MidleNameCustomer) As 'Отчество заказчика',
dbo.StringFormat(Customer.LastNameCustomer) As'Фамилия заказчика',Customer.DeliveryAddress As'Адрес доставки',
Driver.IdDriver As'код водителя',dbo.StringFormat(Driver.FirstNameDriver) As'Имя водителя',dbo.StringFormat(Driver.MidleNameDriver) AS 'Отчество водителя',
dbo.StringFormat(Driver.LastNameDriver) AS'Фамилия водителя',dbo.StringFormat(OrderInShop.StatusOrder) As 'Статус заказа'
FROM OrderInShop
LEFT JOIN Driver ON OrderInShop.DriverId= Driver.IdDriver
LEFT JOIN Customer ON OrderInShop.CustomerId=Customer.IdCustomer;


--Тригер проверяющий если есть такой заказик то нового не добовлять
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
from 'E:\univer\дз\бд\tr\CLRFunction1\CLRFunction1\bin\Debug\CLRFunction1.dll'
with permission_set = unsafe;
go

CREATE FUNCTION StringFormat(@str nvarchar(50))
Returns nvarchar(50)
AS
EXTERNAL NAME CLRFunction1.[CLRFunction1.Class1].StringFormat;




EXEC AddCategory 'Мягкая Мебель';
EXEC AddDriver 'Михайлов','Юрий','Анатольевич'
EXEC AddProduct 'Диван','Белый','кожа',30000.00,'Мягкая мебель';
EXEC AddOrder'Иванов','Иван','Иванович','ул.Московская д.10 кв.32',1
EXEC AddWorkerInProduction'Михайлов','Юрий','Анатольевич','Мягкая мебель',40000.00;
EXEC AddWorkerOrAdmin  'Семенов','ЮРий','Анатольевич',60000.00,'Администратор','AEE','1111';
EXEC AddWorkerOrAdmin  'Гронин','Анотолий','Юрьевич',50000.00,'Специалист отдела приема и отправки','ABB','1111';


Select * from ListProducts;
Select * FROM ListDriver;
Select * FROM ListCategory;
Select * FROM LISTWORKER;
Select * FROM LISTORDER;
EXEC OrderAreManufactured 1;
EXEC OrderDevileryBegin 1, 1;



