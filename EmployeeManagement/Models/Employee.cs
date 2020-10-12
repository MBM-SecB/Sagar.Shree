using System.Collections.Generic;

public class Employee
{
    public string FirstName { get; set; }
    public string Surname { get; set; }

    public string Address { get; set; }
    public char Gender { get; set; } = 'M';
    public double Salary { get; set; }

    public static List<Employee> GetEmployees()
    {
        var employee1 = new Employee
        {
            FirstName = "Sagar",
            Surname = "Shree",
            Address = "Dang The Capital City",
            Salary = 100000,
        };
        var employee2 = new Employee
        {
            FirstName = "Madan",
            Surname = "Devkota",
            Address = "Salyan",
            Salary = 10000,
        };
        var employee3 = new Employee
        {
            FirstName = "Sita",
            Surname = "Bista",
            Address = "Butwal the nabhako capital",
            Salary = 15000,
        };
        var employee4 = new Employee
        {
            FirstName = "Hari ",
            Surname = "Nepal",
            Address = "Kathmandu",
            Salary = 20000,
        };
        var employee5 = new Employee
        {
            FirstName = "Joshi",
            Surname = "Shrestha",
            Address = "Bhaktapur",
            Salary = 16000,
        };

        var employees = new List<Employee> { employee1, employee2, employee3, employee4, employee5 };
        return employees;
    }

}