using Exam.Domain.Entities;
using Exam.Service.DTOs.Group;

namespace Exam.Service.DTOs.Teacher;

public class TeacherResultDto
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public IEnumerable<GroupResultDto> Groups { get; set; }
}
