using SchoolApi.Data;
using SchoolApi.Models;
using SchoolApi.Models.Dtos;
using SchoolApi.Services.TeachersRepository.Methods;

namespace SchoolApi.Services.TeachersRepository
{
  public class TeachersRepository: ITeachersRepository
  {
    private readonly BaseContext _context;

    public TeachersRepository(BaseContext context)
    {
      _context = context;
    }

    public Response<IEnumerable<Teacher>> GetAll()
    {
      TeachersGet taskUnit = new(_context);
      return taskUnit.GetAll();
    }

    public PageResponse<IEnumerable<Teacher>> GetAll(int pageNumber)
    {
      TeachersGet taskUnit = new(_context);
      return taskUnit.GetAll(pageNumber);
    }

    public Response<Teacher> GetById(int id)
    {
      TeachersGet taskUnit = new(_context);
      return taskUnit.GetById(id);
    }

    public Response<Teacher> Create(Teacher teacher)
    {
      TeachersCreate taskUnit = new(_context);
      return taskUnit.Create(teacher);
    }

    public Response<Teacher> Update(int id, Teacher teacher)
    {
      TeachersUpdate taskUnit  = new(_context);
      return taskUnit.Update(id, teacher);
    }

    public Response<int> Delete(int id)
    {
      TeachersDelete taskUnit = new(_context);
      return taskUnit.Delete(id);
    } 
  }
}
