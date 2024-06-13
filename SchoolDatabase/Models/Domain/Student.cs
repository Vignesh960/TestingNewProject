using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDatabase.Models.Domain
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string AdmisionClass { get; set; }
        public string CurrentClass { get; set; }
        public string DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }

        //navigation and reference

        //public int FeePaymentsId { get; set; }
        public ICollection<FeePayments> FeePayments { get; set; }
    }
}
