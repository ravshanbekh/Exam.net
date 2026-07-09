using AutoMapper;
using Exam.Domain.Entities;
using Exam.Service.DTOs.Teacher;

namespace Exam.Service.MappingHelper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Teacher, TeacherResultDto>().ReverseMap();
        CreateMap<TeacherCreationDto, Teacher>().ReverseMap();
        CreateMap<TeacherUpdateDto, Teacher>().ReverseMap();
    }
}
