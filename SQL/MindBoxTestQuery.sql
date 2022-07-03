create table dbo.Product
(
	Id int primary key,
	ProductName nvarchar(128) not null
)

insert into dbo.Product(Id, ProductName) values (1, 'Product1')
insert into dbo.Product(Id, ProductName) values (2, 'Product2')
insert into dbo.Product(Id, ProductName) values (3, 'Product3')
insert into dbo.Product(Id, ProductName) values (4, 'Product4')

create table dbo.Category
(
	Id int primary key,
	CategoryName nvarchar(128) not null
)

insert into dbo.Category(Id, CategoryName) values (1, 'Category1')
insert into dbo.Category(Id, CategoryName) values (2, 'Category2')
insert into dbo.Category(Id, CategoryName) values (3, 'Category3')

create table dbo.ProductCategory
(
	ProductId int foreign key references dbo.Product(Id),
	CategoryId int foreign key references dbo.Category(Id),
	primary key(ProductId, CategoryId)
)

insert into dbo.ProductCategory(ProductId, CategoryId) values (1, 1)
insert into dbo.ProductCategory(ProductId, CategoryId) values (1, 2)
insert into dbo.ProductCategory(ProductId, CategoryId) values (2, 3)
insert into dbo.ProductCategory(ProductId, CategoryId) values (3, 1)
insert into dbo.ProductCategory(ProductId, CategoryId) values (3, 2)
insert into dbo.ProductCategory(ProductId, CategoryId) values (3, 3)

select dbo.Product.ProductName, cat.CategoryName
from dbo.Product
left join dbo.ProductCategory as prodCat on prodCat.ProductId = dbo.Product.Id
left join dbo.Category as cat on cat.Id = prodCat.CategoryId
