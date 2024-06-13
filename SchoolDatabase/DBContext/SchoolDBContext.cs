using Microsoft.EntityFrameworkCore;
using SchoolDatabase.Models.Domain;

namespace SchoolDatabase.DBContext
{
    public class SchoolDBContext : DbContext
    {
        public SchoolDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<FeePayments> FeePayments { get; set; }
    }
}
