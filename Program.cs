using pilot;

public class Program
{
    public static void Main()
    {
        
        Employee employee = EmployeeFactory.CreateEmployee("departmentmanager", "ali", "ahmadi", 1234567890, 6000000m, 3, 1.5m);

        
        if (employee.ValidateNationalCode() && employee.ValidateBaseSalary())
        {
            Console.WriteLine($"name: {employee.FirstName} {employee.LastName}");
            Console.WriteLine($"nationalcode {employee.NationalCode}");
            Console.WriteLine($"salary {employee.CalculateSalary()}");
        }
        else
        {
            Console.WriteLine("not valid.");
        }
    }
}
