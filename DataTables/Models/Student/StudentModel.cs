using System.ComponentModel.DataAnnotations;

namespace DataTables.Models.Student
{
    public class StudentModel
    {
        [Required(ErrorMessage = "Student ID is required.")]
        public int StudentID { get; set; }

        [Required(ErrorMessage = "Student name is required.")]
        [StringLength(40, ErrorMessage = "Student name can't be longer than 40 characters.")]
        public string StudentName { get; set; }

        [Required(ErrorMessage = "Enrollment number is required.")]
        [StringLength(11, ErrorMessage = "Enrollment number can't be longer than 11 characters.")]
        public string EnrollmentNo { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password must be between 8 and 100 characters.")]
        public string Password { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Roll number must be a positive integer.")]
        public int RollNo { get; set; }

        [Range(1, 8, ErrorMessage = "Current semester must be between 1 and 8.")]
        public int CurrentSemester { get; set; }

        [Required(ErrorMessage = "Institute email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string EmailInstitute { get; set; }

        [EmailAddress(ErrorMessage = "Invalid personal email address.")]
        [Required(ErrorMessage = "Personal email is required.")]

        public string EmailPersonal { get; set; }

        [Required(ErrorMessage = "Contact No is required.")]
        [Phone(ErrorMessage = "Invalid contact number.")]
        public string ContactNo { get; set; }

        [Required(ErrorMessage = "Cast ID is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Cast ID must be a positive integer.")]
        public int CastID { get; set; }

        [Required(ErrorMessage = "City ID is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "City ID must be a positive integer.")]
        public int CityID { get; set; }

        [StringLength(500, ErrorMessage = "Remarks can't be longer than 500 characters.")]
        public string Remarks { get; set; }
    }
}
