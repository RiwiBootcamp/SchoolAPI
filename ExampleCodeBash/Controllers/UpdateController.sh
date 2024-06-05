cd "$rootProjectDir/Controllers/${globalModelNaming}"

cat > ${globalModelNaming}UpdateController.cs << EOM
using "\$project_name".Models;
using "\$project_name".Services."\$global_model_naming"Repository;
using Microsoft.AspNetCore.Mvc;

namespace "\$project_name".Controllers
{
  [Route("\$api_endpoint_name")]
  [ApiController]
  public class "\$global_model_naming"UpdateController: ControllerBase
  {
    private readonly I"\$global_model_naming"Repository _"\$repository_filed";
    public "\$global_model_naming"UpdateController(I"\$global_model_naming"Repository "\$repository_filed")
    {
      _"\$repository_filed" = "\$repository_filed";
    }

    [HttpPut("{Id}")]
    public "\$http_put_return" Update(int Id, "\$model_name" "\$model_name_argument")
    {
      return _"\$repository_filed".Update(Id, "\$model_name_argument");
    }
  }
}
EOM