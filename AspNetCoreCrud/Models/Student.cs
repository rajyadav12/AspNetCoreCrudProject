using System.ComponentModel.DataAnnotations;

namespace AspNetCoreCrud.Models
{
    public class Student
    {
        [Key]
        [Display(Name="student Id")]
        public int studentId { get; set; }

        [Required]
        [Display(Name = "student Id")]
        public string Name { get; set; }
        public string Email { get; set; }
        public string course { get; set; }

        [Display(Name = "student Id")]
        public DateTime EnrollmentDate { get; set; }
    }
}
