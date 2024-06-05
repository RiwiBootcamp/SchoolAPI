cd $rootProjectDir/Services/HttpMethods

## Dont overwrite
test -f IHttpPut.cs && exit

cat > IHttpPost.cs << EOM
namespace "\$project_name".Services.HttpMethods
{
  public interface IHttpPost<T>
  {
    // T (T model)
    "\$http_post_return_local" Create("\$http_post_param_type_local" "\$http_post_param_local"); 
  }
}
EOM