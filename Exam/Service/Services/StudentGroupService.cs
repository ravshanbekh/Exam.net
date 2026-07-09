using Exam.Service.DTOs.StudentGroup;
using Exam.Service.Interfaces;

namespace Exam.Service.Services;

public class StudentGroupService : IStudentGroupService
{
    public Task<StudentGroupResultDto> CreateAsync(StudentGroupCreationDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<StudentGroupResultDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<StudentGroupResultDto> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<StudentGroupResultDto> UpdateAsync(StudentGroupUpdateDto dto)
    {
        throw new NotImplementedException();
    }
}
