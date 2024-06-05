cd $rootProjectDir/Services/HttpMethods

## Dont overwrite
test -f IHttpPut.cs && exit

cat > IHttpPut.cs << EOM
namespace "\$project_name".Services.HttpMethods
{
  public interface IHttpPut<T>
  {
    // T (T model)
    "\$http_put_return_local" Update(int id, "\$http_put_param_type_local" "\$http_put_param_local");
  }
}
EOM