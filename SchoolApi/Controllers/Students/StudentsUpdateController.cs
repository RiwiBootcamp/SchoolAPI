using SchoolApi.Models;
using SchoolApi.Services.StudentsRepository;
using Microsoft.AspNetCore.Mvc;
using SchoolApi.Models.Dtos;

namespace SchoolApi.Controllers
{
  [Route("api/students")]
  [ApiController]
  public class StudentsUpdateController: ControllerBase
  {
    private readonly IStudentsRepository _studentRepository;
    public StudentsUpdateController(IStudentsRepository studentRepository)
    {
      _studentRepository = studentRepository;
    }

    [HttpPut("{Id}")]
    public Response<Student> Update(int Id, Student student)
    {
      return _studentRepository.Update(Id, student);
    }
  }
}
