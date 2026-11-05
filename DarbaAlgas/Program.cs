public abstract class Employee

{

    public string Name { get; }


    // TODO: konstruktors, kas saņem vārdu

    // TODO: abstrakta metode CalculateSalary()

}


public class FullTimeEmployee : Employee

{

    private decimal _monthlySalary;


    // TODO: konstruktors (name, monthlySalary), izsauc base(name)

    // TODO: CalculateSalary()

}


public class HourlyEmployee : Employee

{

    // TODO: lauki, konstruktors, CalculateSalary()

}


public class PayrollCalculator

{

    public decimal TotalSalary(List<Employee> employees)

    {

        // TODO: cikls pa sarakstu, saskaiti algas

    }

}