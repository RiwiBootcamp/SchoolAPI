using SchoolApi.Data;
using SchoolApi.Models;
using SchoolApi.Models.Dtos;
using SchoolApi.Services.HttpMethods;

namespace SchoolApi.Services.StudentsRepository.Methods
{
  public class StudentsCreate: IHttpPost<Student>
  {
    // BaseContext _context
    private readonly BaseContext _context;
    public StudentsCreate(BaseContext context){
      _context = context;
    }

    public Response<Student> Create(Student student)
    {
      var data = _context.Students.Add(student);
      _context.SaveChanges();
      return  new Response<Student>(data.Entity, "Student was sucessfully created");
    }
  } 
}
