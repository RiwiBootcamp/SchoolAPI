using SchoolApi.Models;
using SchoolApi.Services.EnrollmentsRepository;
using Microsoft.AspNetCore.Mvc;
using SchoolApi.Models.Dtos;

namespace SchoolApi.Controllers
{
  [Route("api/enrollments")]
  [ApiController]
  public class EnrollmentsCreateController: ControllerBase
  {
    private readonly IEnrollmentsRepository _enrollmentsRepository;
    public EnrollmentsCreateController(IEnrollmentsRepository enrollmentsRepository)
    {
      _enrollmentsRepository = enrollmentsRepository;
    }

    [HttpPost]
    public Task<Response<Enrollment>> Create([FromBody] Enrollment enrollment)
    {
      return _enrollmentsRepository.Create(enrollment);
    }
  }
}
