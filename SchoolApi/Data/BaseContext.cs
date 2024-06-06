using Microsoft.EntityFrameworkCore;
using SchoolApi.Models;

namespace SchoolApi.Data
{
  // BaseContext
  public class BaseContext: DbContext
  {
    public BaseContext(DbContextOptions<BaseContext> options): base(options)
    { }

    // Remember that model is singular, and table is plural
    // DbSet<Model> SqlTable
    public DbSet<Teacher> Teachers {get; set;}
    public DbSet<Student> Students {get; set;}
    public DbSet<Enrollment> Enrollments {get; set;}
    public DbSet<Course> Courses {get; set;}
  }
}
