using System.ComponentModel.DataAnnotations;

namespace SchoolDatabase.Models.Dtos
{
    public class AddStudentRequestDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string FatherName { get; set; }
        [Required]
        public string AdmisionClass { get; set; }
        [Required]
        public string CurrentClass { get; set; }
        public string? DOB { get; set; }
        public DateTime? DOJ { get; set; }
        public string? Contact { get; set; }
        public string? Address { get; set; }
    }
}
