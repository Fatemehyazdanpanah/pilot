

namespace pilot
{

    public interface IEmployee
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        long NationalCode { get; set; }
        decimal BaseSalary { get; set; }
        int Level { get; set; }
        decimal EmployeeRatio { get; set; }
        decimal ExtraTimePerHours { get; set; }
        decimal TotalHoursInMonth { get; set; }
        decimal CalculateSalary();
        bool ValidateNationalCode();
        bool ValidateBaseSalary();
    }
    public abstract class Employee : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long NationalCode { get; set; }
        public decimal BaseSalary { get; set; }
        public int Level { get; set; }
        public decimal EmployeeRatio { get; set; }
        public decimal ExtraTimePerHours { get; set; }
        public decimal TotalHoursInMonth { get; set; }

        public decimal CalculateSalary()
        {
            return BaseSalary * Level * EmployeeRatio * TotalHoursInMonth
                + BaseSalary * ExtraTimePerHours * Level * EmployeeRatio * 1.2m;
        }

        public bool ValidateNationalCode()
        {
            return NationalCode >= 1000000000 && NationalCode <= 9999999999;
        }

        public bool ValidateBaseSalary()
        {
            return BaseSalary >= 1000000 && BaseSalary <= 10000000;
        }
    }
    public class SimpleEmployee : Employee
    {
        public SimpleEmployee(string firstName, string lastName, long nationalCode, decimal baseSalary, int level, decimal employeeRatio)
        {
            FirstName = "fatemeh";
            LastName = "yazdani";
            NationalCode = 11111111111;
            BaseSalary = 500000;
            Level = 1;
            EmployeeRatio = 1;
            ExtraTimePerHours = 40m;  
            TotalHoursInMonth = 20m; 
        }
    }

    public class SeniorEmployee : Employee
    {
        public SeniorEmployee(string firstName, string lastName, long nationalCode, decimal baseSalary, int level, decimal employeeRatio)
        {
            FirstName = "zahra";
            LastName = "mohammadi";
            NationalCode = 2222222222;
            BaseSalary = 4000000;
            Level = 2;
            EmployeeRatio = 2;
            ExtraTimePerHours = 50m;  
            TotalHoursInMonth = 60m;  
        }
    }

    public class Manager : Employee
    {
        public Manager(string firstName, string lastName, long nationalCode, decimal baseSalary, int level, decimal employeeRatio)
        {
            FirstName = "maryam";
            LastName = "mahmoodi";
            NationalCode = 22222223333;
            BaseSalary = 4500000;
            Level = 2;
            EmployeeRatio = 2;
            ExtraTimePerHours = 30m;  
            TotalHoursInMonth = 120m;   
        }
    }
    public class SectionManager : Employee
    {
        public SectionManager(string firstName, string lastName, long nationalCode, decimal baseSalary, int level, decimal employeeRatio)
        {
            FirstName = firstName;
            LastName = lastName;
            NationalCode = nationalCode;
            BaseSalary = baseSalary;
            Level = level;
            EmployeeRatio = employeeRatio;
            ExtraTimePerHours = 70m;  
            TotalHoursInMonth = 160m; 
        }
    }

    public class DepartmentManager : Employee
    {
        public DepartmentManager(string firstName, string lastName, long nationalCode, decimal baseSalary, int level, decimal employeeRatio)
        {
            FirstName = firstName;
            LastName = lastName;
            NationalCode = nationalCode;
            BaseSalary = baseSalary;
            Level = level;
            EmployeeRatio = employeeRatio;
            ExtraTimePerHours = 80; 
            TotalHoursInMonth = 160m; 
        }
    }

    public class Assistant : Employee
    {
        public Assistant(string firstName, string lastName, long nationalCode, decimal baseSalary, int level, decimal employeeRatio)
        {
            FirstName = firstName;
            LastName = lastName;
            NationalCode = nationalCode;
            BaseSalary = baseSalary;
            Level = level;
            EmployeeRatio = employeeRatio;
            ExtraTimePerHours = 90m; 
            TotalHoursInMonth = 160m; 
        }
    }

    public class CEO : Employee
    {
        public CEO(string firstName, string lastName, long nationalCode, decimal baseSalary, int level, decimal employeeRatio)
        {
            FirstName = firstName;
            LastName = lastName;
            NationalCode = nationalCode;
            BaseSalary = baseSalary;
            Level = level;
            EmployeeRatio = employeeRatio;
            ExtraTimePerHours = 100m;  
            TotalHoursInMonth = 160m; 
        }
    }

    public class EmployeeFactory
    {
        public static Employee CreateEmployee(string type, string firstName, string lastName, long nationalCode, decimal baseSalary, int level, decimal employeeRatio)
        {
            switch (type.ToLower())
            {
                case "simple":
                    return new SimpleEmployee(firstName, lastName, nationalCode, baseSalary, level, employeeRatio);
                case "senior":
                    return new SeniorEmployee(firstName, lastName, nationalCode, baseSalary, level, employeeRatio);
                case "manager":
                    return new Manager(firstName, lastName, nationalCode, baseSalary, level, employeeRatio);
                case "sectionmanager":
                    return new SectionManager(firstName, lastName, nationalCode, baseSalary, level, employeeRatio);
                case "departmentmanager":
                    return new DepartmentManager(firstName, lastName, nationalCode, baseSalary, level, employeeRatio);
                case "assistant":
                    return new Assistant(firstName, lastName, nationalCode, baseSalary, level, employeeRatio);
                case "ceo":
                    return new CEO(firstName, lastName, nationalCode, baseSalary, level, employeeRatio);
                default:
                    throw new ArgumentException(" not valid.");
            }
        }
    }

}
