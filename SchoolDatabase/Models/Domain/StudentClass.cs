using System.ComponentModel.DataAnnotations;

namespace SchoolDatabase.Models.Domain
{
    public class StudentClass
    {
        [Key]
        public string ClassName { get; set; }
        public double TotalFee { get; set; }

    }
}
