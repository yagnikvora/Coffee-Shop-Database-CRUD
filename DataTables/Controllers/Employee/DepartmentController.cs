using DataTables.Models.Employee;
using Microsoft.AspNetCore.Mvc;

namespace DataTables.Controllers.Employee
{
    public class DepartmentController : Controller
    {
        public static List<DepartmenModel> Departments = new List<DepartmenModel>
            {
                new DepartmenModel{ DeptID = 1, DepartmentName = "IT" },
                new DepartmenModel{ DeptID = 2, DepartmentName = "Design" },
                new DepartmenModel{ DeptID = 3, DepartmentName = "Finance" },
                new DepartmenModel{ DeptID = 4, DepartmentName = "HR" },
                new DepartmenModel{ DeptID = 5, DepartmentName = "Support" },
            };
        public IActionResult DepartmentTable()
        {
            
            return View(Departments);
        }
        public IActionResult AddDepartment()
        {
            return View();
        }
    }
}
