using SchoolDatabase.Models.Domain;
using System.ComponentModel.DataAnnotations;

namespace SchoolDatabase.Models.Dtos
{
    public class StudentDto
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string AdmisionClass { get; set; }
        public string CurrentClass { get; set; }
        public string DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        
        public ICollection<FeePayments> FeePayments { get; set; }
        //public FeePayments FeePayments { get; set; }
    }
}
