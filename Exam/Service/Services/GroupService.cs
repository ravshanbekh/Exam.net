using Exam.Service.DTOs.Group;
using Exam.Service.Interfaces;

namespace Exam.Service.Services;

public class GroupService : IGroupService
{
    public Task<GroupResultDto> CreateAsync(GroupCreationDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<GroupResultDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<GroupResultDto> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<GroupResultDto> UpdateAsync(GroupUpdateDto dto)
    {
        throw new NotImplementedException();
    }
}
