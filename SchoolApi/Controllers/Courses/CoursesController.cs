using SchoolApi.Models;
using SchoolApi.Services.CoursesRepository;
using Microsoft.AspNetCore.Mvc;
using SchoolApi.Models.Dtos;

namespace SchoolApi.Controllers
{
  [Route("api/courses")]
  [ApiController]
  // Remember that in works in onion (this is level 1, repository is level 2), so
  // others classes, don't know about this one
  public class CoursesController: ControllerBase
  {
    private readonly ICoursesRepository _coursesRepository;
    public CoursesController(ICoursesRepository coursesRepository)
    {
      _coursesRepository = coursesRepository;
    }

    [HttpGet]
    public Response<IEnumerable<Course>> GetAll()
    {
      return _coursesRepository.GetAll();
    }

    [HttpGet("{Id}")]
    public Response<Course> GetById(int Id)
    {
      return _coursesRepository.GetById(Id);
    }

    // Queries
    [HttpGet]
    [Route("query/paging")]
    public PageResponse<IEnumerable<Course>> GetAll([FromQuery] int pageNumber)
    {
      return _coursesRepository.GetAll(pageNumber);
    }

    [HttpGet]
    [Route("query/teacher")]
    public Response<IEnumerable<Course>> GetTeacherCourses([FromQuery] int id)
    {
      return _coursesRepository.GetTeacherCourses(id);
    }
  }
}
