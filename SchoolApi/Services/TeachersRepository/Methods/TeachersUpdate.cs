using SchoolApi.Data;
using SchoolApi.Models;
using SchoolApi.Services.HttpMethods;
using Microsoft.EntityFrameworkCore;
using SchoolApi.Models.Dtos;


namespace SchoolApi.Services.TeachersRepository.Methods
{
  public class TeachersUpdate: IHttpPut<Teacher>
  {
    private readonly BaseContext _context;
    public TeachersUpdate(BaseContext context){
      _context = context;
    }

    public Response<Teacher> Update(int id, Teacher teacher)
    {
      teacher.Id = id;

      _context.Entry(teacher).State = EntityState.Modified;
      _context.SaveChanges();
      return new Response<Teacher>(teacher, $"Teacher ID: {teacher.Id}, was updated");
    }
  } 
}
