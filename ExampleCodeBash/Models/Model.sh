cd $rootProjectDir/Models

cat > ${modelName}.cs << EOM
namespace "\$project_name".Models
{
  public class "\$model_name"
  {
    // A good part of models have ID
    public int Id {get; set;}
  }
}
EOM