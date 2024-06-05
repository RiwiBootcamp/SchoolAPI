cd $rootProjectDir/Services/${globalModelNaming}Repository

cat > ${globalModelNaming}Repository.cs << EOM
namespace "\$project_name".Services."\$global_model_naming"Repository
{
  public class "\$global_model_naming"Repository: I"\$global_model_naming"Repository
  {
    private readonly BaseContext _context;

    public "\$global_model_naming"Repository(BaseContext context)
    {
      _context = context;
    }

    public "\$http_getAll_return" GetAll()
    {
      "\$global_model_naming"Get taskUnit = new(_context);
      return taskUnit.GetAll();
    }

    public "\$http_getById_return" GetById(int id)
    {
      "\$global_model_naming"Get taskUnit = new(_context);
      return taskUnit.GetById(id);
    }

    public "\$http_post_return" Create("\$model_name" "\$model_name_argument")
    {
      "\$global_model_naming"Create taskUnit = new(_context);
      return taskUnit.Create("\$model_name_argument");
    }

    public "\$http_put_return" Update(int id, "\$model_name" "\$model_name_argument")
    {
      "\$global_model_naming"Update taskUnit  = new(_context);
      return taskUnit.Update(id, "\$model_name_argument");
    }

    public "\$http_delete_return" Delete(int id)
    {
      "\$global_model_naming"Delete taskUnit = new(_context);
      return taskUnit.Delete(id);
    } 
  }
}
EOM