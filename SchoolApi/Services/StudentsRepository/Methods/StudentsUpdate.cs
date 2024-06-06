using SchoolApi.Data;
using SchoolApi.Models;
using SchoolApi.Services.HttpMethods;
using Microsoft.EntityFrameworkCore;
using SchoolApi.Models.Dtos;


namespace SchoolApi.Services.StudentsRepository.Methods
{
  public class StudentsUpdate: IHttpPut<Student>
  {
    private readonly BaseContext _context;
    public StudentsUpdate(BaseContext context){
      _context = context;
    }

    public Response<Student> Update(int id, Student student)
    {
      student.Id = id;
      _context.Entry(student).State = EntityState.Modified;
      _context.SaveChanges();
      return new Response<Student>(student, $"Student ID: {student.Id}, was updated");
    }
  } 
}
