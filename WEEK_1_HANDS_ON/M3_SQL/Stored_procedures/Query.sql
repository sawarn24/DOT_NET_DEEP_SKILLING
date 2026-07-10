-- ==========================================
-- Exercise 1 : Create Stored Procedure
-- ==========================================

DELIMITER $$

CREATE PROCEDURE sp_GetEmployeesByDepartment
(
    IN DeptID INT
)
BEGIN
    SELECT *
    FROM Employees
    WHERE DepartmentID = DeptID;
END $$

DELIMITER ;



-- ==========================================
-- Exercise 4 : Execute Stored Procedure
-- ==========================================

CALL sp_GetEmployeesByDepartment(1);



-- ==========================================
-- Exercise 5 : Return Total Employees
-- ==========================================

DELIMITER $$

CREATE PROCEDURE sp_TotalEmployees
(
    IN DeptID INT
)
BEGIN
    SELECT COUNT(*) AS TotalEmployees
    FROM Employees
    WHERE DepartmentID = DeptID;
END $$

DELIMITER ;



-- Execute Procedure

CALL sp_TotalEmployees(1);