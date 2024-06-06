using SchoolApi.Models;
using SchoolApi.Services.CoursesRepository;
using Microsoft.AspNetCore.Mvc;
using SchoolApi.Models.Dtos;

namespace SchoolApi.Controllers
{
  [Route("api/courses")]
  [ApiController]
  public class CoursesUpdateController: ControllerBase
  {
    private readonly ICoursesRepository _coursesRepository;
    public CoursesUpdateController(ICoursesRepository coursesRepository)
    {
      _coursesRepository = coursesRepository;
    }

    [HttpPut("{Id}")]
    public Response<Course> Update(int Id, Course course)
    {
      return _coursesRepository.Update(Id, course);
    }
  }
}
