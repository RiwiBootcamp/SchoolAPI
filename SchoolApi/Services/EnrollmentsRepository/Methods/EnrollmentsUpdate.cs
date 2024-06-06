using SchoolApi.Data;
using SchoolApi.Models;
using SchoolApi.Services.HttpMethods;
using Microsoft.EntityFrameworkCore;
using SchoolApi.Models.Dtos;


namespace SchoolApi.Services.EnrollmentsRepository.Methods
{
  public class EnrollmentsUpdate: IHttpPut<Enrollment>
  {
    private readonly BaseContext _context;
    public EnrollmentsUpdate(BaseContext context){
      _context = context;
    }

    public Response<Enrollment> Update(int id, Enrollment enrollment)
    {
      enrollment.Id = id;
      _context.Entry(enrollment).State = EntityState.Modified;
      _context.SaveChanges();
      return new Response<Enrollment>(enrollment, $"Enrollment ID: {enrollment.Id}, was updated");
    }
  } 
}
