using SchoolApi.Data;
using SchoolApi.Models;
using SchoolApi.Models.Dtos;
using SchoolApi.Services.HttpMethods;

namespace SchoolApi.Services.StudentsRepository.Methods
{
  public class StudentsGet: IHttpGet<Student>
  {
    // BaseContext _context
    private readonly BaseContext _context;
    public StudentsGet(BaseContext context){
      _context = context;
    }
    public Response<IEnumerable<Student>> GetAll()
    {
      var data = _context.Students.ToList();

      return new Response<IEnumerable<Student>>(data, "This is all data from students");
    }

    public Response<Student> GetById(int id)
    {
      var data = _context.Students.Find(id);
      return new Response<Student>(data, "Student was founded");
    }

    public PageResponse<IEnumerable<Student>> GetAll(int pageNumber)
    {
      int pageSize = 2;
      var data = _context.Students
        .Skip((pageNumber -1) * pageSize)
        .Take(pageSize)
        .ToList();

      return new PageResponse<IEnumerable<Student>>(data, pageNumber, pageSize, "This is data for students");
    }

    public Response<IEnumerable<Student>> GetStudentBirthDay(DateOnly birthDay)
    {
      var data = _context.Students
        .Where(x => x.BirthDate == birthDay)
        .ToList();

      return new Response<IEnumerable<Student>>(data, "This is all data from students");
    }
  } 
}
