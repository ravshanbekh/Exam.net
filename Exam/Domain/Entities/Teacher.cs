using Exam.Domain.Configuration;

namespace Exam.Domain.Entities;

public class Teacher : Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public List<Group> Groups { get; set; }
    
}
