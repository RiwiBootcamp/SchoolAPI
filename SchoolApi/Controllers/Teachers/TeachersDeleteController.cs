using SchoolApi.Services.TeachersRepository;
using Microsoft.AspNetCore.Mvc;
using SchoolApi.Models.Dtos;

namespace SchoolApi.Controllers
{
  [Route("api/teachers")]
  [ApiController]
  public class TeachersDeleteController: ControllerBase
  {
    private readonly ITeachersRepository _teacherRepository;
    public TeachersDeleteController(ITeachersRepository teacherRepository)
    {
      _teacherRepository = teacherRepository;
    }

    [HttpDelete("{Id}")]
    public Response<int> Delete(int Id)
    {
      return _teacherRepository.Delete(Id);
    }
  }
}
