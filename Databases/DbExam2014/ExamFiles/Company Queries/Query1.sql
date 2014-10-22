SELECT FirstName + ' ' + LastName AS [Full Name], YearSalary
FROM Employees
WHERE YearSalary <= 150000 AND YearSalary >= 100000
ORDER BY YearSalary