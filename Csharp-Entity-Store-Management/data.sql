/*
Created		06/04/2021
Modified		17/04/2021
Project		
Model			
Company		
Author		
Version		
Database		MS SQL 2005 
*/

use master
go
create database store_management
go
use store_management
go


Create table [Customer]
(
	[customerID] Integer Identity NOT NULL,
	[name] Nvarchar(100) NULL,
	[address] Nvarchar(100) NULL,
	[phone] Char(12) NULL,
	[createdAt] Datetime NULL,
	[updatedAt] Datetime NULL,
Primary Key ([customerID])
) 
go

Create table [Order]
(
	[orderID] Integer Identity NOT NULL,
	[amount] Bigint NULL,
	[totalAmount] Bigint NULL,
	[createdAt] Datetime NULL,
	[updatedAt] Datetime NULL,
	[customerID] Integer NOT NULL,
	[userID] Integer NOT NULL,
Primary Key ([orderID])
) 
go

Create table [User]
(
	[userID] Integer Identity NOT NULL,
	[username] Varchar(20) NULL,
	[password] Varchar(100) NULL,
	[role] Varchar(10) NULL,
	[fullname] Nvarchar(100) NULL,
	[address] Nvarchar(100) NULL,
	[position] Nvarchar(100) NULL,
	[phone] Char(12) NULL,
	[createdAt] Datetime NULL,
	[updatedAt] Datetime NULL,
Primary Key ([userID])
) 
go

create table [Supplier]
(
	[supplierID] Integer Identity NOT NULL,
	[name] Nvarchar(100) NULL,
	[address] Nvarchar(100) NULL,
	[createdAt] Datetime NULL,
	[updatedAt] Datetime NULL,
Primary Key ([supplierID])
) 
go

Create table [Category]
(
	[categoryID] Integer Identity NOT NULL,
	[name] Nvarchar(100) NULL,
	[createdAt] Datetime NULL,
	[updatedAt] Datetime NULL,
Primary Key ([categoryID])
) 
go

Create table [Product]
(
	[productID] Integer Identity NOT NULL,
	[name] Nvarchar(100) NULL,
	[stockOnHand] Integer Default 0 NULL,
	[price] Bigint Default 0 NULL,
	[thumb] Varchar(100) NULL,
	[createdAt] Datetime NULL,
	[updatedAt] Datetime NULL,
	[categoryID] Integer NOT NULL,
Primary Key ([productID])
) 
go

Create table [OrderDetail]
(
	[orderID] Integer NOT NULL,
	[productID] Integer NOT NULL,
	[price] Bigint NULL,
	[quantity] Integer NULL,
	[discount] Integer NULL,
	[createdAt] Datetime NULL,
	[updatedAt] Datetime NULL,
Primary Key ([orderID],[productID])
) 
go

Create table [StockIn]
(
	[productID] Integer NOT NULL,
	[supplierID] Integer NOT NULL,
	[quantity] Integer NULL,
	[createdAt] Datetime NULL,
	[updatedAt] Datetime NULL,
Primary Key ([productID],[supplierID])
) 
go


Alter table [Order] add  foreign key([customerID]) references [Customer] ([customerID])  on update no action on delete no action 
go
Alter table [OrderDetail] add  foreign key([orderID]) references [Order] ([orderID])  on update no action on delete no action 
go
Alter table [Order] add  foreign key([userID]) references [User] ([userID])  on update no action on delete no action 
go
Alter table [StockIn] add  foreign key([supplierID]) references [Supplier] ([supplierID])  on update no action on delete no action 
go
Alter table [Product] add  foreign key([categoryID]) references [Category] ([categoryID])  on update no action on delete no action 
go
Alter table [OrderDetail] add  foreign key([productID]) references [Product] ([productID])  on update no action on delete no action 
go
Alter table [StockIn] add  foreign key([productID]) references [Product] ([productID])  on update no action on delete no action 
go


Set quoted_identifier on
go


Set quoted_identifier off
go

-- trigger cho bảng User
CREATE TRIGGER trg_insert_user ON [User]
FOR INSERT
AS 
  UPDATE [User] 
	SET createdAt = GETDATE(), updatedAt = GETDATE()
	from [User] inner join inserted i
	on [User].userID = i.userID;
go
create trigger trg_user_update on [User]
for update 
as
	begin
	  update [User]
		set updatedAt = getDate()
		from [User] inner join deleted d
		on [User].userID=d.userID
	end

-- trigger cho bảng Category
go
CREATE TRIGGER trg_insert_category ON [Category]
FOR INSERT
AS 
  UPDATE [Category] 
	SET createdAt = GETDATE(), updatedAt = GETDATE()
	from [Category] inner join inserted i
	on [Category].categoryID = i.categoryID;
go
create trigger trg_category_update on [Category]
for update 
as
	begin
	  update [Category]
		set updatedAt = getDate()
		from [Category] inner join deleted d
		on [Category].categoryID = d.categoryID
	end


-- Trigger cho bang customer
go
CREATE TRIGGER trg_insert_customer ON [Customer]
FOR INSERT
AS 
  UPDATE [Customer] 
	SET createdAt = GETDATE(), updatedAt = GETDATE()
	from [Customer] inner join inserted i
	on [Customer].customerID = i.customerID;
go
create trigger trg_customer_update on [Customer]
for update 
as
	begin
	  update [Customer]
		set updatedAt = getDate()
		from [Customer] inner join deleted d
		on [Customer].customerID = d.customerID
	end

-- trigger cho bang order
go
CREATE TRIGGER trg_insert_order ON [Order]
FOR INSERT
AS 
  UPDATE [Order]
	SET createdAt = GETDATE(), updatedAt = GETDATE()
	from [Order] inner join inserted i
	on [Order].orderID = i.orderID;
go
create trigger trg_order_update on [Order]
for update 
as
	begin
	  update [Order]
		set updatedAt = getDate()
		from [Order] inner join deleted d
		on [Order].orderID = d.orderID
	end

-- trigger cho bang orderdetail
go
CREATE TRIGGER trg_insert_orderdetail ON [OrderDetail]
FOR INSERT
AS 
  UPDATE [OrderDetail]
	SET createdAt = GETDATE(), updatedAt = GETDATE()
	from [OrderDetail] inner join inserted i
	on [OrderDetail].orderID = i.orderID and [OrderDetail].productID = i.productID;
go
create trigger trg_user_orderdetail on [OrderDetail]
for update 
as
	begin
	  update [OrderDetail]
		set updatedAt = getDate()
		from [OrderDetail] inner join deleted d
		on [OrderDetail].orderID = d.orderID and [OrderDetail].productID = d.productID;
	end

--
go
CREATE TRIGGER trg_insert_product ON [Product]
FOR INSERT
AS 
  UPDATE [Product] 
	SET createdAt = GETDATE(), updatedAt = GETDATE()
	from [Product] inner join inserted i
	on [Product].productID = i.productID;
go
create trigger trg_product_update on [Product]
for update 
as
	begin
	  update [Product]
		set updatedAt = getDate()
		from [Product] inner join deleted d
		on [Product].productID = d.productID
	end

--
go
CREATE TRIGGER trg_insert_stockin ON [StockIn]
FOR INSERT
AS 
  UPDATE [StockIn] 
	SET createdAt = GETDATE(), updatedAt = GETDATE()
	from [StockIn] inner join inserted i
	on [StockIn].productID = i.productID and [StockIn].supplierID = i.supplierID;
go
create trigger trg_stockin_update on [StockIn]
for update 
as
	begin
	  update [StockIn]
		set updatedAt = getDate()
		from [StockIn] inner join deleted d
		on [StockIn].productID = d.productID and [StockIn].supplierID = d.supplierID;
	end

--
go
CREATE TRIGGER trg_insert_supplier ON [Supplier]
FOR INSERT
AS 
  UPDATE [Supplier] 
	SET createdAt = GETDATE(), updatedAt = GETDATE()
	from [Supplier] inner join inserted i
	on [Supplier].supplierID = i.supplierID;
go
create trigger trg_supplier_update on [Supplier]
for update 
as
	begin
	  update [Supplier]
		set updatedAt = getDate()
		from [Supplier] inner join deleted d
		on [Supplier].supplierID = d.supplierID
	end
