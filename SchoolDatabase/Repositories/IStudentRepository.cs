using SchoolDatabase.Models.Domain;

namespace SchoolDatabase.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAllAsync();
        Task<Student> CreateAsync(Student student);
    }
}
