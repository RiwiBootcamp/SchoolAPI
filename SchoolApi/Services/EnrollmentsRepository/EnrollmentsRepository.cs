using SchoolApi.Data;
using SchoolApi.Models;
using SchoolApi.Models.Dtos;
using SchoolApi.Services.EnrollmentsRepository.Methods;

namespace SchoolApi.Services.EnrollmentsRepository
{
  public class EnrollmentsRepository: IEnrollmentsRepository
  {
    private readonly BaseContext _context;

    public EnrollmentsRepository(BaseContext context)
    {
      _context = context;
    }

    public Response<IEnumerable<Enrollment>> GetAll()
    {
      EnrollmentsGet taskUnit = new(_context);
      return taskUnit.GetAll();
    }

    public Response<Enrollment> GetById(int id)
    {
      EnrollmentsGet taskUnit = new(_context);
      return taskUnit.GetById(id);
    }

    // Queries
    public PageResponse<IEnumerable<Enrollment>> GetAll(int pageNumber)
    {
      EnrollmentsGet taskUnit = new(_context);
      return taskUnit.GetAll(pageNumber);
    }

    public Response<IEnumerable<Enrollment>> GetAll(DateOnly date)
    {
      EnrollmentsGet taskUnit = new(_context);
      return taskUnit.GetAll(date);
    }

    public Response<IEnumerable<Enrollment>> GetStudentEnrollments(int id)
    {
      EnrollmentsGet taskUnit = new(_context);
      return taskUnit.GetStudentEnrollments(id);
    }

    public Task<Response<Enrollment>> Create(Enrollment enrollment)
    {
      EnrollmentsCreate taskUnit = new(_context);
      return taskUnit.Create(enrollment);
    }

    public Response<Enrollment> Update(int id, Enrollment enrollment)
    {
      EnrollmentsUpdate taskUnit  = new(_context);
      return taskUnit.Update(id, enrollment);
    }

    public  Response<int> Delete(int id)
    {
      EnrollmentsDelete taskUnit = new(_context);
      return taskUnit.Delete(id);
    } 
  }
}
