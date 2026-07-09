namespace Exam.Service.DTOs.StudentGroup;

public class StudentGroupUpdateDto
{
    public Guid Id { get; set; }
    public Guid GroupId { get; set; }
    public Guid StudentId { get; set; }
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}
