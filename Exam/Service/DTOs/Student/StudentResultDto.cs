using Exam.Domain.Entities;
using Exam.Service.DTOs.StudentGroup;

namespace Exam.Service.DTOs.Student;

public class StudentResultDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public int Score { get; set; }
    public IEnumerable<StudentGroupResultDto> StudentGroups { get; set; }
}
