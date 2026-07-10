-- Display All Products
USE OnlineRetailStore;

SELECT * FROM Products;

-- ROW_NUMBER()
SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    ROW_NUMBER() OVER(ORDER BY Price DESC) AS RowNumber
FROM Products;

-- RANK()
SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    RANK() OVER(ORDER BY Price DESC) AS ProductRank
FROM Products;

-- DENSE_RANK()
SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    DENSE_RANK() OVER(ORDER BY Price DESC) AS DenseRank
FROM Products;

-- ROW_NUMBER() with PARTITION BY
SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    ROW_NUMBER() OVER(PARTITION BY Category ORDER BY Price DESC) AS RowNumber
FROM Products;

-- RANK() with PARTITION BY
SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    RANK() OVER(PARTITION BY Category ORDER BY Price DESC) AS ProductRank
FROM Products;

-- DENSE_RANK() with PARTITION BY
SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    DENSE_RANK() OVER(PARTITION BY Category ORDER BY Price DESC) AS DenseRank
FROM Products;