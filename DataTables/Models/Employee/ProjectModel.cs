using System.ComponentModel.DataAnnotations;

namespace DataTables.Models.Employee
{
    public class ProjectModel
    {
        public int PID { get; set; }
        [Required(ErrorMessage = "Project Name should not be Empty")]

        public string ProjectName { get; set; }
        [Required(ErrorMessage = "Start Date should not be Empty")]
        
        public string StartDate { get; set; }
        [Required(ErrorMessage = "End Date should not be Empty")]
        public string EndDate { get; set; }
        [Required(ErrorMessage = "Budget should not be Empty")]
        
        public double Budget { get; set; }
    }
}
