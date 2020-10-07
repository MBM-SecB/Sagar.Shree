using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public ActionResult Index()
    {
        List<Employee> employees = new List<Employee>();
        var employee1 = new Employee
        {
            FirstName = "Sagar",
            Surname = "Shree",
            Address = "Dang The Capital City",
            Salary = 1,
        };
        return View();
    }
}

public class Employee
{
    public string FirstName { get; set; }
    public string Surname { get; set; }

    public string Address { get; set; }
    public char Gender { get; set; } = 'M';
    public double Salary { get; set; }


}