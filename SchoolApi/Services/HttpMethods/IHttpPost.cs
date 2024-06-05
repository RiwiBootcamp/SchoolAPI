using SchoolApi.Models.Dtos;

namespace SchoolApi.Services.HttpMethods
{
  public interface IHttpPost<T>
  {
    // T (T model)
    Response<T> Create(T model); 
  }
}
