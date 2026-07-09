namespace Exam.Service.DTOs.StudentGroup;

public class StudentGroupCreationDto
{
    public Guid GroupId { get; set; }
    public Guid StudentId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
