using SchoolApi.Data;
using SchoolApi.Models;
using SchoolApi.Models.Dtos;
using SchoolApi.Services.HttpMethods;

namespace SchoolApi.Services.TeachersRepository.Methods
{
  public class TeachersCreate: IHttpPost<Teacher>
  {
    // BaseContext _context
    private readonly BaseContext _context;
    public TeachersCreate(BaseContext context){
      _context = context;
    }

    public Response<Teacher> Create(Teacher teacher)
    {
      var data = _context.Teachers.Add(teacher);
      _context.SaveChanges();
      return new Response<Teacher>(data.Entity, "Teacher was created sucessfully");
    }
  } 
}
