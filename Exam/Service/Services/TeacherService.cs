using AutoMapper;
using Exam.Data.IRepositories;
using Exam.Data.Repositories;
using Exam.Domain.Entities;
using Exam.Service.DTOs.Student;
using Exam.Service.DTOs.Teacher;
using Exam.Service.ExceptionHandler;
using Exam.Service.Interfaces;
using Exam.Service.MappingHelper;
using Microsoft.EntityFrameworkCore;

namespace Exam.Service.Services;

public class TeacherService : ITeacherService
{
    private IRepository<Teacher> teacherRepository;
    private readonly IMapper _mapper;
    public TeacherService()
    {
        this.teacherRepository = new Repository<Teacher>();
        // 1. Profilni konfiguratsiyaga qo'shamiz
        var config = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>());

        // 2. Konfiguratsiyadan qo'lda Mapper obyektini yaratamiz
        _mapper = config.CreateMapper();
    }

    public async Task<TeacherResultDto> CreateAsync(TeacherCreationDto dto)
    {
        var teacher = await this.teacherRepository.
            RetrieveAll().FirstOrDefaultAsync(t => t.Email == dto.Email);
        if (teacher is not null)
        {
            throw new CustomException(400, "This email is already registered");
        }

        var newTeacher = _mapper.Map<Teacher>(dto);

        var result = await teacherRepository.InsertAsync(newTeacher);
        return _mapper.Map<TeacherResultDto>(result);
    }

    public Task<bool> DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<TeacherResultDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<TeacherResultDto> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<TeacherResultDto> UpdateAsync(TeacherUpdateDto dto)
    {
        throw new NotImplementedException();
    }
}
