using SchoolApi.Data;
using SchoolApi.Models;
using SchoolApi.Models.Dtos;
using SchoolApi.Services.CoursesRepository.Methods;

namespace SchoolApi.Services.CoursesRepository
{
  public class CoursesRepository: ICoursesRepository
  {
    private readonly BaseContext _context;

    public CoursesRepository(BaseContext context)
    {
      _context = context;
    }

    public Response<IEnumerable<Course>> GetAll()
    {
      CoursesGet taskUnit = new(_context);
      return taskUnit.GetAll();
    }

    public Response<Course> GetById(int id)
    {
      CoursesGet taskUnit = new(_context);
      return taskUnit.GetById(id);
    }

    public PageResponse<IEnumerable<Course>> GetAll(int pageNumber)
    {
      CoursesGet taskUnit = new(_context);
      return taskUnit.GetAll(pageNumber);
    }

    public Response<IEnumerable<Course>> GetTeacherCourses(int teacherId)
    {
      CoursesGet taskUnit = new(_context);
      return taskUnit.GetTeacherCourses(teacherId);
    }

    public Response<Course> Create(Course course)
    {
      CoursesCreate taskUnit = new(_context);
      return taskUnit.Create(course);
    }

    public Response<Course> Update(int id, Course course)
    {
      CoursesUpdate taskUnit  = new(_context);
      return taskUnit.Update(id, course);
    }

    public Response<int> Delete(int id)
    {
      CoursesDelete taskUnit = new(_context);
      return taskUnit.Delete(id);
    } 
  }
}
