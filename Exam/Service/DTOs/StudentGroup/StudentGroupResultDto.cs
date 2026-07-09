using Exam.Service.DTOs.Group;
using Exam.Service.DTOs.Student;

namespace Exam.Service.DTOs.StudentGroup;

public class StudentGroupResultDto
{
    public Guid Id { get; set; }
    public GroupResultDto Group { get; set; }
    public StudentResultDto Student { get; set; }
}
