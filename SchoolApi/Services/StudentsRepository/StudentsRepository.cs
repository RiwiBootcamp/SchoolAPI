using SchoolApi.Data;
using SchoolApi.Models;
using SchoolApi.Models.Dtos;
using SchoolApi.Services.StudentsRepository.Methods;

namespace SchoolApi.Services.StudentsRepository
{
  public class StudentsRepository: IStudentsRepository
  {
    private readonly BaseContext _context;

    public StudentsRepository(BaseContext context)
    {
      _context = context;
    }

    public Response<IEnumerable<Student>> GetAll()
    {
      StudentsGet taskUnit = new(_context);
      return taskUnit.GetAll();
    }

    public Response<Student> GetById(int id)
    {
      StudentsGet taskUnit = new(_context);
      return taskUnit.GetById(id);
    }

    // queries
    public PageResponse<IEnumerable<Student>> GetAll(int pageNumber)
    {
      StudentsGet taskUnit = new(_context);
      return taskUnit.GetAll(pageNumber);
    }

    public Response<IEnumerable<Student>> GetStudentBirthDay(DateOnly birthDay)
    {
      StudentsGet taskUnit = new(_context);
      return taskUnit.GetStudentBirthDay(birthDay);
    }

    public Response<Student> Create(Student student)
    {
      StudentsCreate taskUnit = new(_context);
      return taskUnit.Create(student);
    }

    public Response<Student> Update(int id, Student student)
    {
      StudentsUpdate taskUnit  = new(_context);
      return taskUnit.Update(id, student);
    }

    public Response<int> Delete(int id)
    {
      StudentsDelete taskUnit = new(_context);
      return taskUnit.Delete(id);
    } 
  }
}