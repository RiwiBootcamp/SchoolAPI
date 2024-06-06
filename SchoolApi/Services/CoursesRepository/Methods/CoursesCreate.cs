using SchoolApi.Data;
using SchoolApi.Models;
using SchoolApi.Models.Dtos;
using SchoolApi.Services.HttpMethods;

namespace SchoolApi.Services.CoursesRepository.Methods
{
  public class CoursesCreate: IHttpPost<Course>
  {
    // BaseContext _context
    private readonly BaseContext _context;
    public CoursesCreate(BaseContext context){
      _context = context;
    }

    public Response<Course> Create(Course course)
    {
      var data = _context.Courses.Add(course);
      _context.SaveChanges();
      return new Response<Course>(data.Entity, "Course was sucessfully created");
    }
  } 
}
