using AutoMapper;
using Exam.Data.IRepositories;
using Exam.Data.Repositories;
using Exam.Domain.Entities;
using Exam.Service.DTOs.Group;
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
    private IRepository<Group> groupRepository;
    private readonly IMapper _mapper;
    public TeacherService()
    {
        this.teacherRepository = new Repository<Teacher>();
        this.groupRepository = new Repository<Group>();
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

    public async Task<bool> DeleteAsync(Guid id)
    {
        var teacher = await teacherRepository.SelectByIdAsync(id);

        if (teacher is null)
        {
            throw new CustomException(404, "Teacher not found");
        }

        return await teacherRepository.RemoveAsync(id);

    }

    public async Task<IEnumerable<TeacherResultDto>> GetAllAsync()
    {
        var teachers = await this.teacherRepository.
            RetrieveAll().Include(t=>t.Groups)
            .ToListAsync();
        var result = _mapper.Map<IEnumerable<TeacherResultDto>>(teachers);

        foreach ( var teacher in result)
        {
            var groups= _mapper.Map<IEnumerable<GroupResultDto>>(teacher.Groups);
            teacher.Groups = groups;
        }

        return result;

    }

    public async Task<TeacherResultDto> GetByIdAsync(Guid id)
    {
        var teacher = await this.teacherRepository.SelectByIdAsync(id);
        if (teacher is null)
        {
            throw new CustomException(404, "Teacher not found");
        }

        var result= _mapper.Map<TeacherResultDto>(teacher);

        var groups =await this.groupRepository.RetrieveAll().Where(g => g.TeacherId == teacher.Id).ToListAsync();
        result.Groups = _mapper.Map<IEnumerable<GroupResultDto>>(groups);

        return result;
    }

    public async Task<TeacherResultDto> UpdateAsync(TeacherUpdateDto dto)
    {
        var teacher =await this.teacherRepository.SelectByIdAsync(dto.Id);

        if (teacher is null)
        {
            throw new CustomException(404, "Teacher not found");
        }

        teacher.FirstName = dto.FirstName;
        teacher.LastName = dto.LastName;
        teacher.Email = dto.Email;
        teacher.Password = dto.Password;
        teacher.UpdatedAt = DateTime.UtcNow;
        
        var result = await this.teacherRepository.ModifyAsync(teacher);

        return _mapper.Map<TeacherResultDto>(result);
    }
}
