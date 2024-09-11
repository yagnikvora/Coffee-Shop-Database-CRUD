using Microsoft.AspNetCore.Mvc;

namespace DataTables.Controllers.student
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
