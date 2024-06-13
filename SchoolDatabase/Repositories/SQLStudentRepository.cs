using Microsoft.EntityFrameworkCore;
using SchoolDatabase.DBContext;
using SchoolDatabase.Models.Domain;

namespace SchoolDatabase.Repositories
{
    public class SQLStudentRepository : IStudentRepository
    {
        private readonly SchoolDBContext schoolDBContext;

        public SQLStudentRepository(SchoolDBContext schoolDBContext)
        {
            this.schoolDBContext = schoolDBContext;
        }
        public async Task<Student> CreateAsync(Student student)
        {
            await schoolDBContext.Students.AddAsync(student);
            await schoolDBContext.SaveChangesAsync();
            return student;
        }

        public async Task<List<Student>> GetAllAsync()
        {
            var students = await schoolDBContext.Students.Include("FeePayments").ToListAsync();
            return students;
        }
    }
}
