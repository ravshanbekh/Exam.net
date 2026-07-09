using Exam.Domain.Entities;

namespace Exam.Service.DTOs.Group;

public class GroupUpdateDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Room { get; set; }
    public Guid? TeacherId { get; set; }
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}
