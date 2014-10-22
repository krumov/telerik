SELECT *, (SELECT COUNT(*)
FROM Employees
INNER JOIN Departments
	ON Employees.DepartmentId = outerD.id
)/2 AS [Count Of Emplyees] 
FROM Departments outerD