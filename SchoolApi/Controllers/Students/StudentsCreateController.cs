using "$project_name".Models;
using "$project_name".Services."$global_model_naming"Repository;
using Microsoft.AspNetCore.Mvc;

namespace "$project_name".Controllers
{
  [Route("$api_endpoint_name")]
  [ApiController]
  public class "$global_model_naming"CreateController: ControllerBase
  {
    private readonly I"$global_model_naming"Repository _"$repository_filed";
    public "$global_model_naming"CreateController(I"$global_model_naming"Repository "$repository_filed")
    {
      _"$repository_filed" = "$repository_filed";
    }

    [HttpPost]
    public "$http_post_return" Create([FromBody] "$model_name" "$model_name_argument")
    {
      return _"$repository_filed".Create("$model_name_argument");
    }
  }
}
