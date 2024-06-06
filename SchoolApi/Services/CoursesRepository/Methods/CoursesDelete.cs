using SchoolApi.Data;
using SchoolApi.Models;
using SchoolApi.Models.Dtos;
using SchoolApi.Services.HttpMethods;

namespace SchoolApi.Services.CoursesRepository.Methods
{
  public class CoursesDelete: IHttpDelete<Course>
  {
    private readonly BaseContext _context;
    public CoursesDelete(BaseContext context){
      _context = context;
    }

    public Response<int> Delete(int id)
    {
      var dataEntry = _context.Courses.Find(id);
      _context.Courses.Remove(dataEntry);
      _context.SaveChanges();
      return new Response<int>(dataEntry.Id, $"Course with id {dataEntry.Id} remove sucessfully");
    }
  } 
}
