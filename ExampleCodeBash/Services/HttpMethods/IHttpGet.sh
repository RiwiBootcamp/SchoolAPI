cd $rootProjectDir/Services/HttpMethods

## Dont overwrite
test -f IHttpGet.cs && exit

cat > IHttpGet.cs << EOM
namespace "\$project_name".Services.HttpMethods
{
  public interface IHttpGet<T>
  {
    // IEnumerable<T> 
    "\$http_getAll_return_local" GetAll();

    // T (int id)
    "\$http_getById_return_local" GetById("\$http_getById_param_type_local" "\$http_getById_param_local"); 
  }
}
EOM