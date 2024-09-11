using DataTables.Models;
using DataTables.Models.Employee;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DataTables.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult EmployeeTable()
        {
            var Employees = new List<EmployeeModel>
            {
                new EmployeeModel{EID = 1 , FirstName = "John", LastName = "Doe" , Email =  "john.doe@example.com",PhoneNumber = "1234567890", HireDate = "2023-01-15",JobTitle = "Developer",Salary = 60000.00,DepID = 1},
                new EmployeeModel{EID = 2, FirstName = "Jane", LastName =  "Smith", Email =  "jane.smith@example.com", PhoneNumber = "1234567891",HireDate =  "2022-05-10",JobTitle = "Designer", Salary =55000.00,DepID = 2 },
                new EmployeeModel{EID = 3,FirstName = "Emily", LastName =  "Johnson",Email = "emily.johnson@example.com",PhoneNumber =  "1234567892",HireDate =  "2021-07-20", JobTitle ="Manager",Salary = 75000.00,DepID = 1 },
                new EmployeeModel{EID = 4,FirstName = "Michael", LastName =  "Williams",Email = "michael.williams@example.com",PhoneNumber =  "1234567893",HireDate =  "2020-03-25", JobTitle ="Analyst",Salary = 50000.00,DepID = 3 }
            };
            ViewBag.Employees = Employees;
            //("David", "Brown", "david.brown@example.com", "1234567894", "2023-06-05", "Developer", 62000.00, 2),
            //("Daniel", "Jones", "daniel.jones@example.com", "1234567895", "2019-11-30", "Consultant", 68000.00, 4),
            //("Matthew", "Garcia", "matthew.garcia@example.com", "1234567896", "2021-01-10", "Support", 45000.00, 5),
            //("Christopher", "Martinez", "christopher.martinez@example.com", "1234567897", "2018-08-22", "Technician", 48000.00, 3),
            //("Joshua", "Rodriguez", "joshua.rodriguez@example.com", "1234567898", "2022-02-28", "Engineer", 70000.00, 1),
            //("Andrew", "Martinez", "andrew.martinez@example.com", "1234567899", "2020-10-15", "Administrator", 53000.00, 4);
            return View("~/Views/Home/Tables/EmployeeTable.cshtml");
        }
        public IActionResult AddEmployee()
        {
            return View("~/Views/Home/Forms/AddEmployee.cshtml");
        }
        public IActionResult DepartmentTable()
        {
            var Departments = new List<DepartmenModel>
            {
                new DepartmenModel{ DeptID = 1, DepartmentName = "IT" },
                new DepartmenModel{ DeptID = 2, DepartmentName = "Design" },
                new DepartmenModel{ DeptID = 3, DepartmentName = "Finance" },
                new DepartmenModel{ DeptID = 4, DepartmentName = "HR" },
                new DepartmenModel{ DeptID = 5, DepartmentName = "Support" },
            };
            ViewBag.Departments = Departments;
            return View("~/Views/Home/Tables/DepartmentTable.cshtml");
        }
        public IActionResult AddDepartment()
        {
            return View("~/Views/Home/Forms/AddDepartment.cshtml");
        }
        public IActionResult ProjectTable()
        {
            var Projects = new List<ProjectModel>
            {
                new ProjectModel{PID = 1, ProjectName = "Project A", StartDate = "2023-01-01", EndDate = "2023-06-30", Budget = 150000.00},
                new ProjectModel{PID = 2,ProjectName = "Project B",StartDate = "2022-03-15",EndDate = "2022-12-31",Budget = 200000.00 },
                new ProjectModel{PID = 3,ProjectName = "Project C",StartDate = "2022-03-15",EndDate = "2022-12-31",Budget = 200000.00},
                new ProjectModel{PID = 4,ProjectName = "Project D",StartDate = "2022-03-15",EndDate = "2022-12-31",Budget = 200000.00},
                new ProjectModel{PID = 5, ProjectName = "Project E",StartDate = "2020-10-01",EndDate = "2021-03-31",Budget = 180000.00},
                new ProjectModel{PID = 6, ProjectName = "Project F",StartDate = "2021-05-15",EndDate = "2021-11-15", Budget = 150000.0 },
                new ProjectModel{PID = 7, ProjectName = "Project G", StartDate =  "2022-01-01",EndDate = "2022-06-30",Budget = 220000.00},
                new ProjectModel{PID = 8, ProjectName = "Project H", StartDate = "2022-01-01", EndDate =  "2022-06-30",Budget = 220000.00},
                new ProjectModel{PID = 9, ProjectName = "Project I", StartDate ="2021-03-01",EndDate = "2021-09-30",Budget = 160000.00},
                new ProjectModel{PID = 10, ProjectName = "Project J", StartDate = "2022-07-01", EndDate = "2022-12-31", Budget = 110000.00},
            };
            ViewBag.Projects = Projects;
            return View("~/Views/Home/Tables/ProjectTable.cshtml");
        }
        public IActionResult AddProject()
        {
            return View("~/Views/Home/Forms/AddProject.cshtml");
        }
        public IActionResult EmployeeProjectTable()
        {
            var EmployeeProjects = new List<EmployeeProjectModel>
            {
                new EmployeeProjectModel{EPID= 1, EID = 1, PID = 1},
                new EmployeeProjectModel{EPID= 2, EID = 2, PID = 2},
                new EmployeeProjectModel{EPID= 3, EID = 3, PID = 3},
                new EmployeeProjectModel{EPID= 4, EID = 4, PID = 4},
            };
            ViewBag.EmployeeProjects = EmployeeProjects;
            return View("~/Views/Home/Tables/EmployeeProjectTable.cshtml");
        }
        public IActionResult AddEmployeeProject()
        {
            return View("~/Views/Home/Forms/AddEmployeeProject.cshtml");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
