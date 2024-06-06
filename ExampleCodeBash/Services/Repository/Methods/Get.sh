cd $rootProjectDir/Services/${globalModelNaming}Repository/Methods

cat > ${globalModelNaming}Get.cs << EOM
using "\$project_name".Data;
using "\$project_name".Models;
using "\$project_name".Services.HttpMethods;

namespace "\$project_name".Services."\$global_model_naming"Repository.Methods
{
  public class "\$global_model_naming"Get: IHttpGet<"\$model_name">
  {
    // BaseContext _context
    private readonly "\$db_context_name" _"\$db_context_field";
    public "\$global_model_naming"Get("\$db_context_name" "\$db_context_field"){
      _"\$db_context_field" = "\$db_context_field";
    }
        
    public "\$http_getAll_return" GetAll()
    {
      var data = _context."\$global_model_naming".ToList();

      return new "\$http_getAll_return"(data, "This is all data from "\$global_model_naming"");
    }


    public "\$http_getAllPaging_return" GetAll(int pageNumber)
    {
      int pageSize = 2;
      var data = _context."\$global_model_naming"
        .Skip((pageNumber -1) * pageSize)
        .Take(pageSize)
        .ToList();

      return new "\$http_getAllPaging_return"(data, pageNumber, pageSize, "This is data for "\$global_model_naming"");
    }

    public "\$http_getById_return" GetById(int id)
    {
      var data = _context."\$global_model_naming".Find(id);
      return new "\$http_getById_return"(data, ""\$model_name" was founded");
    }
  } 
}
EOM