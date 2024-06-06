cd $rootProjectDir/Services/${globalModelNaming}Repository/Methods

cat > ${globalModelNaming}Delete.cs << EOM
using "\$project_name".Data;
using "\$project_name".Models;
using "\$project_name".Services.HttpMethods;

namespace "\$project_name".Services."\$global_model_naming"Repository.Methods
{
  public class "\$global_model_naming"Delete: IHttpDelete<"\$model_name">
  {
    private readonly "\$db_context_name" _"\$db_context_field";
    public "\$global_model_naming"Delete("\$db_context_name" "\$db_context_field"){
      _"\$db_context_field" = "\$db_context_field";
    }

    public "\$http_delete_return" Delete(int id)
    {
      var dataEntry = _context."\$global_model_naming".Find(id);
      _context."\$global_model_naming".Remove(dataEntry);
      _context.SaveChanges();
      return new "\$http_delete_return"(dataEntry.Id, $""\$model_name" with id {dataEntry.Id} remove sucessfully");
    }
  } 
}
EOM