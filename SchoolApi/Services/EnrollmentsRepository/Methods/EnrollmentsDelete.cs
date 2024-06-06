using SchoolApi.Data;
using SchoolApi.Models;
using SchoolApi.Models.Dtos;
using SchoolApi.Services.HttpMethods;

namespace SchoolApi.Services.EnrollmentsRepository.Methods
{
  public class EnrollmentsDelete: IHttpDelete<Enrollment>
  {
    private readonly BaseContext _context;
    public EnrollmentsDelete(BaseContext context){
      _context = context;
    }

    public  Response<int> Delete(int id)
    {
      var dataEntry = _context.Enrollments.Find(id);
      _context.Enrollments.Remove(dataEntry);
      _context.SaveChanges();
      return new Response<int>(dataEntry.Id, $"Enrollment with id {dataEntry.Id} remove sucessfully");
    }
  } 
}
