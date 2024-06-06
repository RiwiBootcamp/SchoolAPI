using SchoolApi.Services.EnrollmentsRepository;
using Microsoft.AspNetCore.Mvc;
using SchoolApi.Models.Dtos;

namespace SchoolApi.Controllers
{
  [Route("api/enrollments")]
  [ApiController]
  public class EnrollmentsDeleteController: ControllerBase
  {
    private readonly IEnrollmentsRepository _enrollmentsRepository;
    public EnrollmentsDeleteController(IEnrollmentsRepository enrollmentsRepository)
    {
      _enrollmentsRepository = enrollmentsRepository;
    }

    [HttpDelete("{Id}")]
    public  Response<int> Delete(int Id)
    {
      return _enrollmentsRepository.Delete(Id);
    }
  }
}
