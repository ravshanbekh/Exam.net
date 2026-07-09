using Exam.Service.DTOs.Student;
using Exam.Service.DTOs.StudentGroup;

namespace Exam.Service.Interfaces;

public interface IStudentGroupService
{
    Task<StudentGroupResultDto> CreateAsync(StudentGroupCreationDto dto);
    Task<StudentGroupResultDto> UpdateAsync(StudentGroupUpdateDto dto);
    Task<bool> DeleteAsync(Guid id);
    Task<StudentGroupResultDto> GetByIdAsync(Guid id);
    Task<IEnumerable<StudentGroupResultDto>> GetAllAsync();
}
