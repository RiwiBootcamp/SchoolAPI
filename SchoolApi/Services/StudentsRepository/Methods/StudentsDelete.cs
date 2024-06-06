using SchoolApi.Data;
using SchoolApi.Models;
using SchoolApi.Models.Dtos;
using SchoolApi.Services.HttpMethods;

namespace SchoolApi.Services.StudentsRepository.Methods
{
  public class StudentsDelete: IHttpDelete<Student>
  {
    private readonly BaseContext _context;
    public StudentsDelete(BaseContext context){
      _context = context;
    }

    public Response<int> Delete(int id)
    {
      var dataEntry = _context.Students.Find(id);
      _context.Students.Remove(dataEntry);
      _context.SaveChanges();
      return new Response<int>(dataEntry.Id, $"Student with id {dataEntry.Id} remove sucessfully");
    }
  } 
}
