namespace Exam.Service.DTOs.Student;

public class StudentUpdateDto
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public int Score { get; set; }
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}
