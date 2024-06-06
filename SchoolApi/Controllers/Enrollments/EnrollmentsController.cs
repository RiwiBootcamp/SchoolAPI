using SchoolApi.Models;
using SchoolApi.Services.EnrollmentsRepository;
using Microsoft.AspNetCore.Mvc;
using SchoolApi.Models.Dtos;

namespace SchoolApi.Controllers
{
  [Route("api/enrollments")]
  [ApiController]
  // Remember that in works in onion (this is level 1, repository is level 2), so
  // others classes, don't know about this one
  public class EnrollmentsController: ControllerBase
  {
    private readonly IEnrollmentsRepository _enrollmentsRepository;
    public EnrollmentsController(IEnrollmentsRepository enrollmentsRepository)
    {
      _enrollmentsRepository = enrollmentsRepository;
    }

    [HttpGet]
    public Response<IEnumerable<Enrollment>> GetAll()
    {
      return _enrollmentsRepository.GetAll();
    }

    [HttpGet("{Id}")]
    public Response<Enrollment> GetById(int Id)
    {
      return _enrollmentsRepository.GetById(Id);
    }

    // Queries
    [HttpGet]
    [Route("query/paging")]
    public PageResponse<IEnumerable<Enrollment>> GetAll([FromQuery] int pageNumber)
    {
      return _enrollmentsRepository.GetAll(pageNumber);
    }

    [HttpGet]
    [Route("query/student")]
    public Response<IEnumerable<Enrollment>> GetStudentEnrollments([FromQuery] int id)
    {
      return _enrollmentsRepository.GetStudentEnrollments(id);
    }

    [HttpGet]
    [Route("query/date")]
    public Response<IEnumerable<Enrollment>> GetAll([FromQuery] DateOnly date)
    {
      return _enrollmentsRepository.GetAll(date);
    }
  }
}
