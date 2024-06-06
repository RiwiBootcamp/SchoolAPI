using SchoolApi.Models;
using SchoolApi.Services.StudentsRepository;
using Microsoft.AspNetCore.Mvc;
using SchoolApi.Models.Dtos;

namespace SchoolApi.Controllers
{
  [Route("api/students")]
  [ApiController]
  // Remember that in works in onion (this is level 1, repository is level 2), so
  // others classes, don't know about this one
  public class StudentsController: ControllerBase
  {
    private readonly IStudentsRepository _studentRepository;
    public StudentsController(IStudentsRepository studentRepository)
    {
      _studentRepository = studentRepository;
    }

    [HttpGet]
    public Response<IEnumerable<Student>> GetAll()
    {
      return _studentRepository.GetAll();
    }

    [HttpGet("{Id}")]
    public Response<Student> GetById(int Id)
    {
      return _studentRepository.GetById(Id);
    }

    // Query
    [HttpGet]
    [Route("query/paging")]
    public PageResponse<IEnumerable<Student>> GetAll([FromQuery] int pageNumber)
    {
      return _studentRepository.GetAll(pageNumber);
    }

    [HttpGet]
    [Route("query/birthday")]
    public Response<IEnumerable<Student>> GetStudentBirthDay([FromQuery] DateOnly value)
    {
      return _studentRepository.GetStudentBirthDay(value);
    }
  }
}
