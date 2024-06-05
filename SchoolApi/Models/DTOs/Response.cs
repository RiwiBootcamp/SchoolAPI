namespace SchoolApi.Models.Dtos
{
  public class Response<T>
  {
    public T Data {get; set;}
    public bool Succeded {get; set;}
    public string Message {get; set;}
    public Response()
    { }

    public Response(T data, string message, bool succeded = true)
    {
      Succeded = succeded;
      Message = message;
      Data = data;
    }
  }
}