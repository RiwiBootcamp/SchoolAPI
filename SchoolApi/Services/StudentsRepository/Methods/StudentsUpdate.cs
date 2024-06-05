using "$project_name".Data;
using "$project_name".Models;
using "$project_name".Services.HttpMethods;
using Microsoft.EntityFrameworkCore;


namespace "$project_name".Services."$global_model_naming"Repository.Methods
{
  public class "$global_model_naming"Update: IHttpPut<"$model_name">
  {
    private readonly "$db_context_name" _"$db_context_field";
    public "$global_model_naming"Update("$db_context_name" "$db_context_field"){
      _"$db_context_field" = "$db_context_field";
    }

    public "$http_put_return" Update(int id, "$model_name" "$model_name_argument")
    {
      "$model_name_argument".Id = id;
      _context.Entry("$model_name_argument").State = EntityState.Modified;
      _context.SaveChanges();
      return "$model_name_argument";
    }
  } 
}
