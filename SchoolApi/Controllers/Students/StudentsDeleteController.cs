using SchoolApi.Services.StudentsRepository;
using Microsoft.AspNetCore.Mvc;
using SchoolApi.Models.Dtos;

namespace SchoolApi.Controllers
{
  [Route("api/students")]
  [ApiController]
  public class StudentsDeleteController: ControllerBase
  {
    private readonly IStudentsRepository _studentRepository;
    public StudentsDeleteController(IStudentsRepository studentRepository)
    {
      _studentRepository = studentRepository;
    }

    [HttpDelete("{Id}")]
    public Response<int> Delete(int Id)
    {
      return _studentRepository.Delete(Id);
    }
  }
}
