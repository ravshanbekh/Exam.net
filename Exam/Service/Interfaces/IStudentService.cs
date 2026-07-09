using Exam.Service.DTOs.Student;

namespace Exam.Service.Interfaces;

public interface IStudentService
{
    Task<StudentResultDto> CreateAsync(StudentCreationDto dto);
    Task<StudentResultDto> UpdateAsync(StudentUpdateDto dto);
    Task<bool> DeleteAsync(Guid id);
    Task<StudentResultDto> GetByIdAsync(Guid id);
    Task<IEnumerable<StudentResultDto>> GetAllAsync();
}
