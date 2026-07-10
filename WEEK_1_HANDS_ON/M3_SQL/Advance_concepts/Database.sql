-- Create Database
CREATE DATABASE OnlineRetailStore;

-- Select Database
USE OnlineRetailStore;

-- Create Products Table
CREATE TABLE Products
(
    ProductID INT AUTO_INCREMENT PRIMARY KEY,
    ProductName VARCHAR(100) NOT NULL,
    Category VARCHAR(50) NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    Brand VARCHAR(50) NOT NULL,
    StockQuantity INT DEFAULT 0,
    CreatedDate TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Insert Sample Data
INSERT INTO Products(ProductName, Category, Price, Brand, StockQuantity)
VALUES
('iPhone 15 Pro','Electronics',1199.99,'Apple',50),
('Samsung Galaxy S24','Electronics',999.99,'Samsung',75),
('MacBook Pro','Electronics',2499.99,'Apple',25),
('Dell XPS 13','Electronics',1299.99,'Dell',30),

('Nike Air Max','Clothing',129.99,'Nike',100),
('Levis 501 Jeans','Clothing',89.99,'Levis',150),
('Adidas Ultraboost','Clothing',180.00,'Adidas',80),
('North Face Jacket','Clothing',249.99,'North Face',45),

('Dyson Vacuum','Home & Garden',749.99,'Dyson',35),
('KitchenAid Mixer','Home & Garden',399.99,'KitchenAid',25),
('Instant Pot','Home & Garden',149.99,'Instant Pot',60),
('Roomba i7','Home & Garden',599.99,'iRobot',15),

('Peloton Bike','Sports',1445.00,'Peloton',10),
('Bowflex Dumbbells','Sports',349.99,'Bowflex',25),
('Yoga Mat','Sports',79.99,'Manduka',150),
('Resistance Bands','Sports',29.99,'Fit Simplify',200);

-- Display Data
SELECT * FROM Products;