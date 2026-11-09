public abstract class Employee
{
    public string Name { get; }
    
    public Employee(string name)
    {
        Name = name;
    }

    public abstract decimal CalculateSalary();
}


public class FullTimeEmployee : Employee
{
    private decimal _monthlySalary;

    public FullTimeEmployee(string name, decimal monthlySalary) : base(name)
    {
        _monthlySalary = monthlySalary;
    }

    public override decimal CalculateSalary()
    {
        return _monthlySalary;
    }
}


public class HourlyEmployee : Employee
{
    private decimal _hourlySalary;
    private int _hoursWorked;
    public HourlyEmployee(string name, decimal hourlySalary, int hoursWorked) : base(name)
    {
        _hourlySalary = hourlySalary;
        _hoursWorked = hoursWorked;
    }
    public override decimal CalculateSalary() {
        return _hourlySalary * _hoursWorked;
    }
}


public class PayrollCalculator
{
    public decimal TotalSalary(List<Employee>)
        {
            decimal total = 0;
            foreach (var employee in employees)
            {
                total += employee.CalculateSalary();
            }
            return total;
    }
}