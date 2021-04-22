use store_management
go

-- Supplier
insert into Supplier(name, address)
values(N'Nhà cung cấp Phú Xuân', N'Hà Nội'),
(N'Nhà cung cấp Quang Huy', N'Đà Nẵng'),
(N'Nhà cung cấp Quân Thúy', N'Cần Thơ'),
(N'Nhà cung cấp Kiều Phương', N'TP.HCM'),
(N'Nhà cung cấp Huy Nam', N'Nghệ An'),
(N'Nhà cung cấp Phong Vân', N'Hà Tĩnh'),
(N'Nhà cung cấp Kiên Bình', N'Hà Nam')

-- Category
insert into Category(name)
values(N'Sữa'), (N'Trái cây'), (N'Thức ăn'), (N'Đồ uống'), 
(N'Bánh kẹo'), (N'Bia'), (N'Thuốc lá')

-- Customer
insert into Customer(name, address, phone)
values(N'Nguyễn Văn An', N'Hà Nội', '1234567890'),
(N'Trần Văn Bình', N'Hà Nam', '0129876543'),
(N'Lê Thị Mai', N'Đà Nẵng', '4512367098'),
(N'Phạm Thị Nhi', N'Cần Thơ', '1234567890'),
(N'Vũ Quang Huy', N'Hà Nội', '5671238904'),
(N'Phạm Long Quân', N'Thanh Hóa', '1254367890'),
(N'Lê Như Ngọc', N'Đà Nẵng', '3451267890')
-- User
insert into [User](username, password, role, fullname, address, position, phone)
values('hoangit3', '12345', 'admin', N'Lường Bá Hoàng', N'Hà Nội', N'Quản lý', '1234567890'),
('khanhit3', '54321', 'admin', N'Hoàng Duy Khánh', N'Hà Nội', N'Quản lý', '1234567890'),
('diepit3', '12345', 'admin', N'Lường Bá Hoàng', N'Hà Nội', N'Quản lý', '1234567890'),
('doanit3', '34567', 'user', N'Khúc Văn Đoàn', N'Hà Nội', N'Thu ngân', '1234567890'),
('hait3', '12345', 'user', N'Đỗ Vinh Hà', N'Hà Nội', N'Bán hàng', '1234567890'),
('linhit3', '12345', 'user', N'Nguyễn Anh Linh', N'Hà Nội', N'Bán hàng', '1234567890'),
('namit3', '67890', 'user', N'Đỗ Trọng Nam', N'Hà Nội', N'Bán hàng', '3456789012')
go

select * from Supplier;
select * from Category;
select * from [User];
select * from Customer;