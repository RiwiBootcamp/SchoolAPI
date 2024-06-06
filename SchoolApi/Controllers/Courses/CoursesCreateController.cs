using SchoolApi.Models;
using SchoolApi.Services.CoursesRepository;
using Microsoft.AspNetCore.Mvc;
using SchoolApi.Models.Dtos;

namespace SchoolApi.Controllers
{
  [Route("api/courses")]
  [ApiController]
  public class CoursesCreateController: ControllerBase
  {
    private readonly ICoursesRepository _coursesRepository;
    public CoursesCreateController(ICoursesRepository coursesRepository)
    {
      _coursesRepository = coursesRepository;
    }

    [HttpPost]
    public Response<Course> Create([FromBody] Course course)
    {
      return _coursesRepository.Create(course);
    }
  }
}
