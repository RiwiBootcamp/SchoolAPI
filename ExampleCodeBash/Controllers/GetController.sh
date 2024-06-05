cd "$rootProjectDir/Controllers/${globalModelNaming}"

cat > ${globalModelNaming}Controller.cs << EOM
using "\$project_name".Models;
using "\$project_name".Services."\$global_model_naming"Repository;
using Microsoft.AspNetCore.Mvc;

namespace "\$project_name".Controllers
{
  [Route("\$api_endpoint_name")]
  [ApiController]
  // Remember that in works in onion (this is level 1, repository is level 2), so
  // others classes, don't know about this one
  public class "\$global_model_naming"Controller: ControllerBase
  {
    private readonly I"\$global_model_naming"Repository _"\$repository_filed";
    public "\$global_model_naming"Controller(I"\$global_model_naming"Repository "\$repository_filed")
    {
      _"\$repository_filed" = "\$repository_filed";
    }

    [HttpGet]
    public "\$http_getAll_return" GetAll()
    {
      return _"\$repository_filed".GetAll();
    }

    [HttpGet("{Id}")]
    public "\$http_getById_return" GetById(int Id)
    {
      return _"\$repository_filed".GetById(Id);
    }
  }
}
EOM