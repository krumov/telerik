Select e.FirstName +' ' + e.LastName as [Full Name],
	p.Name as [Project Name],
	d.Name as [Department Name],
	ep.StartDate,
	ep.EndDate,
(SELECT COUNT(*)
	FROM Report r
	WHERE r.EmployeeId = e.id
	AND r.TimeOfReport BETWEEN ep.startDate AND ep.endDate) as [Reports Count]
FROM Employees e
	INNER JOIN ProjectsEmployees ep
		ON e.Id = ep.EmployeeId
	INNER JOIN Projects p
		ON p.Id = ep.ProjectId
	INNER JOIN Departments d
		ON d.Id = e.DepartmentId
ORDER BY e.Id,d.Id