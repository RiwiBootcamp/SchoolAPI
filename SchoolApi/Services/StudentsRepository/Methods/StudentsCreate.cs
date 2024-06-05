using "$project_name".Data;
using "$project_name".Models;
using "$project_name".Services.HttpMethods;

namespace "$project_name".Services."$global_model_naming"Repository.Methods
{
  public class "$global_model_naming"Create: IHttpPost<"$model_name">
  {
    // BaseContext _context
    private readonly "$db_context_name" _"$db_context_field";
    public "$global_model_naming"Create("$db_context_name" "$db_context_field"){
      _"$db_context_field" = "$db_context_field";
    }

    public "$http_post_return" Create("$model_name" "$model_name_argument")
    {
      _context."$global_model_naming".Add("$model_name_argument");
      _context.SaveChanges();
      return  "$model_name_argument";
    }
  } 
}
