using Exam.Domain.Configuration;

namespace Exam.Domain.Entities;

public class Student : Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public int Score { get; set; }
    public List<StudentGroup> StudentGroups { get; set; }

}
