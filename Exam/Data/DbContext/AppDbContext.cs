using Exam.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Exam.Data.DbContest;

public class AppDbContext:DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; } 
    public DbSet<Group> Groups { get; set; }
    public DbSet<StudentGroup> StudentGroups { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Database=ExamR1_v1;Username=postgres;Password=1234");
    }
}
