using SchoolApi.Data;
using SchoolApi.Models;
using SchoolApi.Models.Dtos;
using SchoolApi.Services.HttpMethods;

namespace SchoolApi.Services.TeachersRepository.Methods
{
  public class TeachersDelete: IHttpDelete<Teacher>
  {
    private readonly BaseContext _context;
    public TeachersDelete(BaseContext context){
      _context = context;
    }

    public Response<int> Delete(int id)
    {
      var dataEntry = _context.Teachers.Find(id);
      _context.Teachers.Remove(dataEntry);
      _context.SaveChanges();
      return new Response<int>(dataEntry.Id, $"Teacher with id {dataEntry.Id} remove sucessfully");
    }
  } 
}
