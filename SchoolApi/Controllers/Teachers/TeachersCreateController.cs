using SchoolApi.Models;
using SchoolApi.Services.TeachersRepository;
using Microsoft.AspNetCore.Mvc;
using SchoolApi.Models.Dtos;

namespace SchoolApi.Controllers
{
  [Route("api/teachers")]
  [ApiController]
  public class TeachersCreateController: ControllerBase
  {
    private readonly ITeachersRepository _teacherRepository;
    public TeachersCreateController(ITeachersRepository teacherRepository)
    {
      _teacherRepository = teacherRepository;
    }

    [HttpPost]
    public Response<Teacher> Create([FromBody] Teacher teacher)
    {
      return _teacherRepository.Create(teacher);
    }
  }
}
