using SchoolApi.Models;
using SchoolApi.Services.EnrollmentsRepository;
using Microsoft.AspNetCore.Mvc;
using SchoolApi.Models.Dtos;

namespace SchoolApi.Controllers
{
  [Route("api/enrollments")]
  [ApiController]
  public class EnrollmentsUpdateController: ControllerBase
  {
    private readonly IEnrollmentsRepository _enrollmentsRepository;
    public EnrollmentsUpdateController(IEnrollmentsRepository enrollmentsRepository)
    {
      _enrollmentsRepository = enrollmentsRepository;
    }

    [HttpPut("{Id}")]
    public Response<Enrollment> Update(int Id, Enrollment enrollment)
    {
      return _enrollmentsRepository.Update(Id, enrollment);
    }
  }
}
