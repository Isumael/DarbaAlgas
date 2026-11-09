var employees = new List<Employee>
{
    new FullTimeEmployee("Anna", 1200m),
    new HourlyEmployee("Jānis", 8m, 100),
    new SalesEmployee("Marta", 500m, 4000m)
};

foreach (Employee e in employees)
{
    Console.WriteLine($"{e.Name}: {e.CalculateSalary():F2}");
}

var payroll = new PayrollCalculator();

Console.WriteLine($"Kopā: {payroll.TotalSalary(employees):F2}");