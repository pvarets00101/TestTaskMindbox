CREATE TABLE Products (
	Id INT PRIMARY KEY,
	Name NVARCHAR(20)
);

INSERT INTO Products
VALUES
	(1, 'Flower'),
	(2, 'Candy'),
	(3, 'House');

CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	Name NVARCHAR(20)
);

INSERT INTO Categories
VALUES
	(1, 'Food'),
	(2, 'Plant'),
	(3, 'Gift');

CREATE TABLE ProductCategories (
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductCategories
VALUES
	(1, 2),
	(1, 3),
	(2, 1),
	(2, 3);

SELECT P.Name, C.Name
FROM Products P
LEFT JOIN ProductCategories PC
	ON P.Id = PC.ProductId
LEFT JOIN Categories C
	ON PC.CategoryId = C.Id;
