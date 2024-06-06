using SchoolApi.Models;
using SchoolApi.Models.Dtos;
using SchoolApi.Services.HttpMethods;

namespace SchoolApi.Services.EnrollmentsRepository
{
  // We have to create the following methods
  public interface IEnrollmentsRepository: IHttpGet<Enrollment>,
    IHttpPut<Enrollment>, 
    IHttpDelete<Enrollment>
  {
    Response<IEnumerable<Enrollment>> GetAll(DateOnly date);
    Response<IEnumerable<Enrollment>> GetStudentEnrollments(int id);

    Task<Response<Enrollment>> Create(Enrollment model); 
  }
}
