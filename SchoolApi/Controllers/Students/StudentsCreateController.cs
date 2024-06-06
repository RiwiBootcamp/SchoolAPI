using SchoolApi.Models;
using SchoolApi.Services.StudentsRepository;
using Microsoft.AspNetCore.Mvc;
using SchoolApi.Models.Dtos;

namespace SchoolApi.Controllers
{
  [Route("api/students")]
  [ApiController]
  public class StudentsCreateController: ControllerBase
  {
    private readonly IStudentsRepository _studentRepository;
    public StudentsCreateController(IStudentsRepository studentRepository)
    {
      _studentRepository = studentRepository;
    }

    [HttpPost]
    public Response<Student> Create([FromBody] Student student)
    {
      return _studentRepository.Create(student);
    }
  }
}
