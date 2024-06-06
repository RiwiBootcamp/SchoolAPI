using SchoolApi.Models;
using SchoolApi.Services.TeachersRepository;
using Microsoft.AspNetCore.Mvc;
using SchoolApi.Models.Dtos;

namespace SchoolApi.Controllers
{
  [Route("api/teachers")]
  [ApiController]
  // Remember that in works in onion (this is level 1, repository is level 2), so
  // others classes, don't know about this one
  public class TeachersController: ControllerBase
  {
    private readonly ITeachersRepository _teacherRepository;
    public TeachersController(ITeachersRepository teacherRepository)
    {
      _teacherRepository = teacherRepository;
    }

    [HttpGet]
    [Route("query/paging")]
    public PageResponse<IEnumerable<Teacher>> GetAll([FromQuery] int pageNumber)
    {
      return _teacherRepository.GetAll(pageNumber);
    }

    [HttpGet]
    public Response<IEnumerable<Teacher>> GetAll()
    {
      return _teacherRepository.GetAll();
    }


    [HttpGet("{Id}")]
    public Response<Teacher> GetById(int Id)
    {
      return _teacherRepository.GetById(Id);
    }
  }
}
