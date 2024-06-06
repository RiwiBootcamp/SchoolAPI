using SchoolApi.Data;
using SchoolApi.Models;
using SchoolApi.Models.Dtos;
using SchoolApi.Services.StudentsRepository.Methods;

namespace SchoolApi.Services.EnrollmentsRepository.Methods
{
  public class EnrollmentsCreate
  {
    // BaseContext _context
    private readonly BaseContext _context;
    public EnrollmentsCreate(BaseContext context){
      _context = context;
    }

    public async Task<Response<Enrollment>> Create(Enrollment enrollment)
    {
      var data = _context.Enrollments.Add(enrollment);
      _context.SaveChanges();

      Student student = _context.Students.Find(enrollment.IdStudent);
      // var student = req.GetById(enrollment.IdStudent);

      await SendEnrollmentEmailStudent.SendEmail(student);
      return new Response<Enrollment>(enrollment, "Enrollment was sucessfully created");
    }
  } 
}
