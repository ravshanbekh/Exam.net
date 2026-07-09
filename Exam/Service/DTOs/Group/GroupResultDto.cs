using Exam.Domain.Entities;
using Exam.Service.DTOs.StudentGroup;

namespace Exam.Service.DTOs.Group;

public class GroupResultDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Room { get; set; }
    public Guid? TeacherId { get; set; }
    public IEnumerable<StudentGroupResultDto> StudentGroups { get; set; }
}
