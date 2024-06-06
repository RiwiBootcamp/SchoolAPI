using SchoolApi.Models;
using SchoolApi.Models.Dtos;
using SchoolApi.Services.HttpMethods;

namespace SchoolApi.Services.CoursesRepository
{
  // We have to create the following methods
  public interface ICoursesRepository: IHttpGet<Course>, 
    IHttpPost<Course>, 
    IHttpPut<Course>, 
    IHttpDelete<Course>
  {
    Response<IEnumerable<Course>> GetTeacherCourses(int teacherId);
  }
}
