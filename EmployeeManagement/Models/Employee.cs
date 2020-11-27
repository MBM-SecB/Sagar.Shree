using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Employee
{
    [Required(ErrorMessage = "First name is required.")]


    public string FirstName { get; set; }
    [Required(ErrorMessage = "Last name is required.")]


    public string Surname { get; set; }

    [Required(ErrorMessage = "Address is required.")]

    public string Address { get; set; }
    [Required(ErrorMessage = "Gender is required.")]

    public char Gender { get; set; }
    [Required(ErrorMessage = "Salary is required.")]


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
            FirstName = "Hari",
            Surname = "hamal",
            Address = "Itahari",
            Salary = 12000,
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