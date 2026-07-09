using Exam.Service.DTOs.Student;
using Exam.Service.Interfaces;

namespace Exam.Service.Services;

public class StudentService : IStudentService
{
    public Task<StudentResultDto> CreateAsync(StudentCreationDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<StudentResultDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<StudentResultDto> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<StudentResultDto> UpdateAsync(StudentUpdateDto dto)
    {
        throw new NotImplementedException();
    }
}
