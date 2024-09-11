using DataTables.Models.Coffee;
using DataTables.Models.Employee;
using Microsoft.AspNetCore.Mvc;

namespace DataTables.Controllers.Employee
{
    public class ProjectController : Controller
    {
        public static List<ProjectModel> Projects = new List<ProjectModel>
            {
                new ProjectModel{PID = 1, ProjectName = "Project A", StartDate = "2023-01-01", EndDate = "2023-06-30", Budget = 150000.00},
                new ProjectModel{PID = 2,ProjectName = "Project B",StartDate = "2022-03-15",EndDate = "2022-12-31",Budget = 200000.00 },
                new ProjectModel{PID = 3,ProjectName = "Project C",StartDate = "2022-03-15",EndDate = "2022-12-31",Budget = 200000.00},
                new ProjectModel{PID = 4,ProjectName = "Project D",StartDate = "2022-03-15",EndDate = "2022-12-31",Budget = 200000.00},
                new ProjectModel{PID = 5, ProjectName = "Project E",StartDate = "2020-10-01",EndDate = "2021-03-31",Budget = 180000.00},
                new ProjectModel{PID = 6, ProjectName = "Project F",StartDate = "2021-05-15",EndDate = "2021-11-15", Budget = 150000.0 },
                //new ProjectModel{PID = 7, ProjectName = "Project G", StartDate =  "2022-01-01",EndDate = "2022-06-30",Budget = 220000.00},
                //new ProjectModel{PID = 8, ProjectName = "Project H", StartDate = "2022-01-01", EndDate =  "2022-06-30",Budget = 220000.00},
                //new ProjectModel{PID = 9, ProjectName = "Project I", StartDate ="2021-03-01",EndDate = "2021-09-30",Budget = 160000.00},
                //new ProjectModel{PID = 10, ProjectName = "Project J", StartDate = "2022-07-01", EndDate = "2022-12-31", Budget = 110000.00},
            };
        public IActionResult ProjectTable()
        {
            return View(Projects);
        }
        
        public IActionResult AddProject(ProjectModel projectData)
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProjectData(ProjectModel projectData)
        {
            projectData.PID = Projects.Count + 1;
            Projects.Add(projectData);
            return RedirectToAction("ProjectTable");
        }
    }
}
