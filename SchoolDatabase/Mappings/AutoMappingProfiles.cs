using AutoMapper;
using SchoolDatabase.Models.Domain;
using SchoolDatabase.Models.Dtos;

namespace SchoolDatabase.Mappings
{
    public class AutoMappingProfiles:Profile
    {
        public AutoMappingProfiles() 
        { 
            CreateMap<Student,StudentDto>().ReverseMap();
            CreateMap<AddStudentRequestDto, Student>().ReverseMap();

            //payments dto
            CreateMap<FeePayments,FeePaymentsDto>().ReverseMap();
        }
    }
}
