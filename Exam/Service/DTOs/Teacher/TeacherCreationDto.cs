namespace Exam.Service.DTOs.Teacher;

public class TeacherCreationDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public DateTime CreatedAt { get; set; }= DateTime.UtcNow;
}
