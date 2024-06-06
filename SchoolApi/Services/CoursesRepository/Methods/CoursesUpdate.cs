using SchoolApi.Data;
using SchoolApi.Models;
using SchoolApi.Services.HttpMethods;
using Microsoft.EntityFrameworkCore;
using SchoolApi.Models.Dtos;


namespace SchoolApi.Services.CoursesRepository.Methods
{
  public class CoursesUpdate: IHttpPut<Course>
  {
    private readonly BaseContext _context;
    public CoursesUpdate(BaseContext context){
      _context = context;
    }

    public Response<Course> Update(int id, Course course)
    {
      course.Id = id;
      _context.Entry(course).State = EntityState.Modified;
      _context.SaveChanges();
      return new Response<Course>(course, $"Course ID: {course.Id}, was updated");
    }
  } 
}
