using SchoolApi.Models;
using SchoolApi.Models.Dtos;

namespace SchoolApi.Services.HttpMethods
{
  public interface IHttpGet<T>
  {
    // IEnumerable<T> 
    Response<IEnumerable<T>> GetAll();

    // IEnumerable<T> 
    PageResponse<IEnumerable<T>> GetAll(int pageNumber);

    // T (int id)
    Response<T> GetById(int id); 
  }
}
