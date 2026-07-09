using Exam.Domain.Configuration;

namespace Exam.Domain.Entities;

public class Group:Auditable
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Room { get; set; }
    public Teacher Teacher { get; set; }
    public long? TeacherId { get; set; }
    public IEnumerable<StudentGroup> StudentGroups { get; set; }
}
