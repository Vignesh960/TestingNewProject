using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolDatabase.DBContext;
using SchoolDatabase.Models.Domain;
using SchoolDatabase.Models.Dtos;
using SchoolDatabase.Repositories;

namespace SchoolDatabase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly SchoolDBContext schoolDBContext;
        private readonly IStudentRepository studentRepository;
        private readonly IMapper mapper;

        public StudentsController(SchoolDBContext schoolDBContext, IStudentRepository studentRepository,IMapper mapper)
        {
            this.schoolDBContext = schoolDBContext;
            this.studentRepository = studentRepository;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var students = await studentRepository.GetAllAsync();
            //mapp to Dto
            mapper.Map<List<StudentDto>>(students);
            return Ok(mapper.Map<List<StudentDto>>(students));
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddStudentRequestDto addStudentRequestDto)
        {
            var studentDomainModel= mapper.Map<Student>(addStudentRequestDto);
            //create in db
            await studentRepository.CreateAsync(studentDomainModel);
            //map back to dto
            mapper.Map<StudentDto>(studentDomainModel);
            return Ok(mapper.Map<StudentDto>(studentDomainModel));
        }
    }
}
