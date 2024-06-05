using SchoolApi.Models;
using SchoolApi.Services.TeachersRepository;
using Microsoft.AspNetCore.Mvc;
using SchoolApi.Models.Dtos;

namespace SchoolApi.Controllers
{
  [Route("api/teachers")]
  [ApiController]
  public class TeachersUpdateController: ControllerBase
  {
    private readonly ITeachersRepository _teacherRepository;
    public TeachersUpdateController(ITeachersRepository teacherRepository)
    {
      _teacherRepository = teacherRepository;
    }

    [HttpPut("{Id}")]
    public Response<Teacher> Update(int Id, Teacher teacher)
    {
      return _teacherRepository.Update(Id, teacher);
    }
  }
}
