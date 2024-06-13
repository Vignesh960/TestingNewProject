using System.ComponentModel.DataAnnotations;

namespace SchoolDatabase.Models.Domain
{
    public class Feestructure
    {
        public int Id { get; set; }
        [Required]
        public string ClassName { get; set; }
        [Required]
        public double Actualfee { get; set; }
    }
}
