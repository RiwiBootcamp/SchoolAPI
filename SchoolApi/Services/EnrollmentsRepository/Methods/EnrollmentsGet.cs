using Microsoft.EntityFrameworkCore;
using SchoolApi.Data;
using SchoolApi.Models;
using SchoolApi.Models.Dtos;
using SchoolApi.Services.HttpMethods;

namespace SchoolApi.Services.EnrollmentsRepository.Methods
{
  public class EnrollmentsGet: IHttpGet<Enrollment>
  {
    // BaseContext _context
    private readonly BaseContext _context;
    public EnrollmentsGet(BaseContext context){
      _context = context;
    }
        
    public Response<IEnumerable<Enrollment>> GetAll()
    {
      var data = _context.Enrollments
        .Include(x => x.Course)
        .Include(x => x.Student)
        .ToList();

      return new Response<IEnumerable<Enrollment>>(data, "This is all data from Enrollments");
    }

    public Response<Enrollment> GetById(int id)
    {
      var data = _context.Enrollments
        .Include(x => x.Course)
        .Include(x => x.Student)
        .FirstOrDefault(x => x.Id == id);
        
      return new Response<Enrollment>(data, "Enrollment was founded");
    }

    // Queries
    public PageResponse<IEnumerable<Enrollment>> GetAll(int pageNumber)
    {
      int pageSize = 2;
      var data = _context.Enrollments
        .Include(x => x.Course)
        .Include(x => x.Student)
        .Skip((pageNumber -1) * pageSize)
        .Take(pageSize)
        .ToList();

      return new PageResponse<IEnumerable<Enrollment>>(data, pageNumber, pageSize, "This is data for Enrollments");
    }

    public Response<IEnumerable<Enrollment>> GetAll(DateOnly date)
    {
      var data = _context.Enrollments
        .Where(x => x.Date == date)
        .Include(x => x.Course)
        .Include(x => x.Student)
        .ToList();

      return new Response<IEnumerable<Enrollment>>(data, $"These are the courses for the date: {date.ToString()}");
    }

    public Response<IEnumerable<Enrollment>> GetStudentEnrollments(int id)
    {
      var data = _context.Enrollments
        .Where(x => x.Student.Id == id)
        .Include(x => x.Course)
        .Include(x => x.Student)
        .ToList();

      return new Response<IEnumerable<Enrollment>>(data, $"These are the courses for the student ID: {id}");
    }
  } 
}
