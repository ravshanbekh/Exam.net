// one to one  -- 1 ga 1
// one to many -- 1 ga kop
// many to many -- kopga kop
//TEntity orqali generic repo

using Exam.Data.IRepositories;
using Exam.Data.Repositories;
using Exam.Domain.Entities;

public class Program
{
    public static void Main(string[] args)
    {
        IRepository<Teacher> teacherRepository = new Repository<Teacher>();

        teacherRepository.InsertAsync(new Teacher
        {
            Id = 1,
            FirstName = "Test",
            LastName = "Test",
            Email = "test@example.com",
            Groups = [],
            Password = "password",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        });

        IRepository<Group> groupRepository = new Repository<Group>();

        groupRepository.InsertAsync(new Group
        {
            Id = 1,
            Name = "Group 1",
            TeacherId = 1,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        });
    }
}

