-- ======================================
-- Exercise 1 : Non-Clustered Index
-- ======================================

-- Before Index
SELECT * FROM Products
WHERE ProductName='Laptop';

-- Create Non-Clustered Index
CREATE INDEX idx_ProductName
ON Products(ProductName);

-- After Index
SELECT * FROM Products
WHERE ProductName='Laptop';



-- ======================================
-- Exercise 2 : Index on OrderDate
-- (MySQL Alternative to Clustered Index)
-- ======================================

-- Before Index
SELECT * FROM Orders
WHERE OrderDate='2023-01-15';

-- Create Index
CREATE INDEX idx_OrderDate
ON Orders(OrderDate);

-- After Index
SELECT * FROM Orders
WHERE OrderDate='2023-01-15';



-- ======================================
-- Exercise 3 : Composite Index
-- ======================================

-- Before Index
SELECT *
FROM Orders
WHERE CustomerID=1
AND OrderDate='2023-01-15';

-- Create Composite Index
CREATE INDEX idx_Customer_OrderDate
ON Orders(CustomerID,OrderDate);

-- After Index
SELECT *
FROM Orders
WHERE CustomerID=1
AND OrderDate='2023-01-15';