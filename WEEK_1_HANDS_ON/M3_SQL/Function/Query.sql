use employeemanagement
-- Create Scalar Function

DELIMITER $$

CREATE FUNCTION fn_CalculateAnnualSalary
(
    MonthlySalary DECIMAL(10,2)
)
RETURNS DECIMAL(10,2)
DETERMINISTIC
BEGIN
    RETURN MonthlySalary * 12;
END $$

DELIMITER ;



-- Exercise 7
-- Return Annual Salary for EmployeeID = 1

SELECT
    EmployeeID,
    FirstName,
    LastName,
    Salary AS MonthlySalary,
    fn_CalculateAnnualSalary(Salary) AS AnnualSalary
FROM Employees
WHERE EmployeeID = 1;