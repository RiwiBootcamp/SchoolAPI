using SchoolApi.Models.Dtos;

namespace SchoolApi.Services.HttpMethods
{
  public interface IHttpDelete<T>
  {
    // int (int id)
    Response<int> Delete(int id); 
  }
}
