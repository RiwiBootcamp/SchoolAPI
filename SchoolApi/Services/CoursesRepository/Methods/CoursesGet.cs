using Microsoft.EntityFrameworkCore;
using SchoolApi.Data;
using SchoolApi.Models;
using SchoolApi.Models.Dtos;
using SchoolApi.Services.HttpMethods;

namespace SchoolApi.Services.CoursesRepository.Methods
{
  public class CoursesGet: IHttpGet<Course>
  {
    // BaseContext _context
    private readonly BaseContext _context;
    public CoursesGet(BaseContext context){
      _context = context;
    }
        
    public Response<IEnumerable<Course>> GetAll()
    {
      var data = _context.Courses
        .Include(x => x.Teacher)
        .ToList();

      return new Response<IEnumerable<Course>>(data, "This is all data from Courses");
    }

    public Response<Course> GetById(int id)
    {
      var data = _context.Courses
        .Include(x => x.Teacher)
        .FirstOrDefault(x => x.Id == id);
      return new Response<Course>(data, "Course was founded");
    }


    // Queries
    public PageResponse<IEnumerable<Course>> GetAll(int pageNumber)
    {
      int pageSize = 2;
      var data = _context.Courses
        .Include(x => x.Teacher)
        .Skip((pageNumber -1) * pageSize)
        .Take(pageSize)
        .ToList();

      return new PageResponse<IEnumerable<Course>>(data, pageNumber, pageSize, "This is data for Courses");
    }

    public Response<IEnumerable<Course>> GetTeacherCourses(int teacherId)
    {
      var data = _context.Courses
        .Where(x => x.Teacher.Id == teacherId)
        .Include(x => x.Teacher)
        .ToList();

      return new Response<IEnumerable<Course>>(data, "This is data for Courses");
    }
  } 
}
