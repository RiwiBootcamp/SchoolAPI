using SchoolApi.Services.CoursesRepository;
using Microsoft.AspNetCore.Mvc;
using SchoolApi.Models.Dtos;

namespace SchoolApi.Controllers
{
  [Route("api/courses")]
  [ApiController]
  public class CoursesDeleteController: ControllerBase
  {
    private readonly ICoursesRepository _coursesRepository;
    public CoursesDeleteController(ICoursesRepository coursesRepository)
    {
      _coursesRepository = coursesRepository;
    }

    [HttpDelete("{Id}")]
    public Response<int> Delete(int Id)
    {
      return _coursesRepository.Delete(Id);
    }
  }
}
