using Microsoft.EntityFrameworkCore;
using SchoolApi.Data;
using SchoolApi.Models;
using SchoolApi.Models.Dtos;
using SchoolApi.Services.HttpMethods;

namespace SchoolApi.Services.TeachersRepository.Methods
{
  public class TeachersGet: IHttpGet<Teacher>
  {
    // BaseContext _context
    private readonly BaseContext _context;
    public TeachersGet(BaseContext context){
      _context = context;
    }

    public Response<IEnumerable<Teacher>> GetAll()
    {
      var data = _context.Teachers.ToList();

      return new Response<IEnumerable<Teacher>>(data, "This is all data from teachers");
    }
        
    public PageResponse<IEnumerable<Teacher>> GetAll(int pageNumber)
    {
      int pageSize = 2;
      var data = _context.Teachers
        .Skip((pageNumber -1) * pageSize)
        .Take(pageSize)
        .ToList();

      return new PageResponse<IEnumerable<Teacher>>(data, pageNumber, pageSize, "This is data for teachers");
    }

    public Response<Teacher> GetById(int id)
    {
      var data = _context.Teachers.Find(id);
      return new Response<Teacher>(data, "Teacher was founded");
    }
  } 
}
