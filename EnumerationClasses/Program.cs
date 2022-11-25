using EnumerationClasses.Enum;
using EnumerationClasses.Models;

Console.WriteLine("Hello, World!");

var employees = new List<Employee>
{
    new Employee(1, "Hugo", EmployeeType.Manager),
    new Employee(2, "Lucas", EmployeeType.Servant),
    new Employee(3, "Kaio", EmployeeType.AssistantToTheRegionalManager),
};

foreach(Employee employee in employees)
    Console.WriteLine($"Bônus: {employee.Type.BonusSize}");

Console.ReadLine();