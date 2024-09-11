using DataTables.Models.Employee;
using Microsoft.AspNetCore.Mvc;

namespace DataTables.Controllers.Employee
{
    public class EmployeeProjectController : Controller
    {
        public static List<EmployeeProjectModel> EmployeeProjects = new List<EmployeeProjectModel>
            {
                new EmployeeProjectModel{EPID= 1, EID = 1, PID = 1},
                new EmployeeProjectModel{EPID= 2, EID = 2, PID = 2},
                new EmployeeProjectModel{EPID= 3, EID = 3, PID = 3},
                new EmployeeProjectModel{EPID= 4, EID = 4, PID = 4},
            };
        public IActionResult EmployeeProjectTable()
        {
            return View(EmployeeProjects);
        }
        public IActionResult AddEmployeeProject()
        {
            return View();
        }
    }
}
