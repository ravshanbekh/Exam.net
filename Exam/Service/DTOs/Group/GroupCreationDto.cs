using Exam.Domain.Entities;

namespace Exam.Service.DTOs.Group;

public class GroupCreationDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Room { get; set; }
    public Guid? TeacherId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

}
