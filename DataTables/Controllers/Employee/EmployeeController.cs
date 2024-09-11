using DataTables.Models.Employee;
using Microsoft.AspNetCore.Mvc;

namespace DataTables.Controllers.Employee
{
    public class EmployeeController : Controller
    {
        public static List<EmployeeModel> employees = new List<EmployeeModel>
        {
            new EmployeeModel{EID = 1 , FirstName = "John", LastName = "Doe" , Email =  "john.doe@example.com",PhoneNumber = "1234567890", HireDate = "2023-01-15",JobTitle = "Developer",Salary = 60000.00,DepID = 1},
            new EmployeeModel{EID = 2, FirstName = "Jane", LastName =  "Smith", Email =  "jane.smith@example.com", PhoneNumber = "1234567891",HireDate =  "2022-05-10",JobTitle = "Designer", Salary =55000.00,DepID = 2 },
            new EmployeeModel{EID = 3,FirstName = "Emily", LastName =  "Johnson",Email = "emily.johnson@example.com",PhoneNumber =  "1234567892",HireDate =  "2021-07-20", JobTitle ="Manager",Salary = 75000.00,DepID = 1 },
            new EmployeeModel{EID = 4,FirstName = "Michael", LastName =  "Williams",Email = "michael.williams@example.com",PhoneNumber =  "1234567893",HireDate =  "2020-03-25", JobTitle ="Analyst",Salary = 50000.00,DepID = 3 }
        };
        public IActionResult EmployeeTable()
        {
            return View(employees);
        }
        public IActionResult AddEmployee()
        {
            return View();
        }
    }
}
