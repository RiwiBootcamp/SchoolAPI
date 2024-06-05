using SchoolApi.Models.Dtos;

namespace SchoolApi.Services.HttpMethods
{
  public interface IHttpPut<T>
  {
    // T (T model)
    Response<T> Update(int id, T model);
  }
}
