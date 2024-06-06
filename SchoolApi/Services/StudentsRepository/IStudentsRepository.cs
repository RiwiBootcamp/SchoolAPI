using SchoolApi.Models;
using SchoolApi.Models.Dtos;
using SchoolApi.Services.HttpMethods;

namespace SchoolApi.Services.StudentsRepository
{
  // We have to create the following methods
  public interface IStudentsRepository: IHttpGet<Student>, 
    IHttpPost<Student>, 
    IHttpPut<Student>, 
    IHttpDelete<Student>
  {
    public Response<IEnumerable<Student>> GetStudentBirthDay(DateOnly birthDay);
  }
}
