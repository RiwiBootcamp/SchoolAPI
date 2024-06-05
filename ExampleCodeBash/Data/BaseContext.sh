cd $rootProjectDir/Data

## Dont overwrite base context
test -f BaseContext.cs && exit

cat > BaseContext.cs << EOM
namespace "\$project_name".Data
{
  // BaseContext
  public class "\$db_context_name": DbContext
  {
    public "\$db_context_name"(DbContextOptions<"\$db_context_name"> options): base(options)
    { }

    // Remember that model is singular, and table is plural
    // DbSet<Model> SqlTable
    public DbSet<"\$model_name"> "\$global_model_naming" {get; set;}
  }
}
EOM