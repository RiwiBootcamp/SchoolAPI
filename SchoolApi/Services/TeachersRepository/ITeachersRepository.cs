using SchoolApi.Models;
using SchoolApi.Services.HttpMethods;

namespace SchoolApi.Services.TeachersRepository
{
  // We have to create the following methods
  public interface ITeachersRepository: IHttpGet<Teacher>, 
    IHttpPost<Teacher>, 
    IHttpPut<Teacher>, 
    IHttpDelete<Teacher>
  {

  }
}
