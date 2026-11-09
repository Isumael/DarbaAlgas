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
    public override decimal CalculateSalary() 
    {
        return _hourlySalary * _hoursWorked;
    }
}


public class SalesEmployee : Employee
{
    private decimal _baseSalary;
    private decimal _salesAmount;
    public SalesEmployee(string name, decimal baseSalary, decimal salesAmount) : base(name)
    {
        _baseSalary = baseSalary;
        _salesAmount = salesAmount;
    }
    public override decimal CalculateSalary()
    {
        return _baseSalary + (_salesAmount * 0.05m);
    }
}


public class PayrollCalculator
{
    public decimal TotalSalary(List<Employee> employees)
    {
            decimal total = 0;
            foreach (var employee in employees)
            {
                // Paskaidrojums: Abstractā metode atļaut izmantot to pašu metodi dažādām darbinieku klasēm, lai aprēķinātu algu, neatkarīgi no darbinieka veida.
                total += employee.CalculateSalary();
            }
            return total;
    }
}