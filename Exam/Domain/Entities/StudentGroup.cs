using Exam.Domain.Configuration;

namespace Exam.Domain.Entities;

public class StudentGroup : Auditable
{
    public long GroupId { get; set; }
    public Group Group { get; set; }
    public long StudentID { get; set; }
    public Student Student { get; set; }
}
