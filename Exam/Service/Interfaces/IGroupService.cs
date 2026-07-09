using Exam.Service.DTOs.Group;
using Exam.Service.DTOs.Student;

namespace Exam.Service.Interfaces;

public interface IGroupService
{
    Task<GroupResultDto> CreateAsync(GroupCreationDto dto);
    Task<GroupResultDto> UpdateAsync(GroupUpdateDto dto);
    Task<bool> DeleteAsync(Guid id);
    Task<GroupResultDto> GetByIdAsync(Guid id);
    Task<IEnumerable<GroupResultDto>> GetAllAsync();
}
