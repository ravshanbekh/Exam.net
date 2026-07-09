using Exam.Service.DTOs.Student;
using Exam.Service.DTOs.Teacher;

namespace Exam.Service.Interfaces;

public interface ITeacherService
{
    Task<TeacherResultDto> CreateAsync(TeacherCreationDto dto);
    Task<TeacherResultDto> UpdateAsync(TeacherUpdateDto dto);
    Task<bool> DeleteAsync(Guid id);
    Task<TeacherResultDto> GetByIdAsync(Guid id);
    Task<IEnumerable<TeacherResultDto>> GetAllAsync();
}
