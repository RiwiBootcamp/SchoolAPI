using "$project_name".Services."$global_model_naming"Repository;
using Microsoft.AspNetCore.Mvc;

namespace "$project_name".Controllers
{
  [Route("$api_endpoint_name")]
  [ApiController]
  public class "$global_model_naming"DeleteController: ControllerBase
  {
    private readonly I"$global_model_naming"Repository _"$repository_filed";
    public "$global_model_naming"DeleteController(I"$global_model_naming"Repository "$repository_filed")
    {
      _"$repository_filed" = "$repository_filed";
    }

    [HttpDelete("{Id}")]
    public "$http_delete_return" Delete(int Id)
    {
      return _"$repository_filed".Delete(Id);
    }
  }
}
