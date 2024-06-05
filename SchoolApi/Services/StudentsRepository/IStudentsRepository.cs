using "$project_name".Models;
using "$project_name".Services.HttpMethods;

namespace "$project_name".Services."$global_model_naming"Repository
{
  // We have to create the following methods
  public interface I"$global_model_naming"Repository: IHttpGet<"$model_name">, 
    IHttpPost<"$model_name">, 
    IHttpPut<"$model_name">, 
    IHttpDelete<"$model_name">
  { }
}
