using SchoolDatabase.Models.Domain;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDatabase.Models.Dtos
{
    public class FeePaymentsDto
    {
        public int FeePaymentsId { get; set; }
        public double PaidAmount { get; set; }
        public string ClassName { get; set; }
        public DateTime PaidOn { get; set; }

        //reference nav
        public int StudentID { get; set; }//fk with student table
        [ForeignKey("StudentID")]
        public Student Student { get; set; }
    }
}
