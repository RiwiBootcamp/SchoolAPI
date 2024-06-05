namespace SchoolApi.Models.Dtos
{
  public class PageResponse<T>: Response<T>
  {
    public int CurrentPage {get; set;}
    public int PageSize {get; set;}

    public PageResponse(T data, int currentPage, int pageSize, string message)
    : base(data, message)
    {
      CurrentPage = currentPage;
      PageSize = pageSize;
    }
  }
}