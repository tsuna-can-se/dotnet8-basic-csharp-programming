using Ex15_02;

var youngWorkers = Data.Employees
    .Where(employee => employee.Age < 40)
    .OrderBy(employee => employee.Age)
    .OrderBy(employee => employee.DepartmentCode)
    .Select(employee => new Worker(
        employee.LastName + " " + employee.FirstName,
        employee.Age,
        Data.Departments[employee.DepartmentCode]));

foreach (var worker in youngWorkers)
{
    Console.WriteLine(worker);
}
