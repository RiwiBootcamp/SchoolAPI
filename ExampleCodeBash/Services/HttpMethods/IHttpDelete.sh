cd $rootProjectDir/Services/HttpMethods

## Dont overwrite
test -f IHttpDelete.cs && exit

cat > IHttpDelete.cs << EOM
namespace "\$project_name".Services.HttpMethods
{
  public interface IHttpDelete<T>
  {
    // int (int id)
    "\$http_delete_return_local" Delete("\$http_delete_param_type_local" "\$http_delete_param_local"); 
  }
}
EOM