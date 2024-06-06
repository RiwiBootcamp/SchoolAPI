using Microsoft.EntityFrameworkCore;
using SchoolApi.Data;
using SchoolApi.Services.CoursesRepository;
using SchoolApi.Services.EnrollmentsRepository;
using SchoolApi.Services.StudentsRepository;
using SchoolApi.Services.TeachersRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//----- PERSONAL SERVICES -----//

// BaseContext: Intance of DbContext
builder.Services.AddDbContext<BaseContext> ( options => 
  options.UseMySql
  (
    // MySqlConnection: Alias use in appsettings.json to link mysql database
    builder.Configuration.GetConnectionString("MySqlConnection"),

    // 8.0.20-mysql: Version of Pomelo SQL
    Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.20-mysql")
  )
);

// Inyection of dependencies in Controllers
builder.Services.AddScoped<ITeachersRepository, TeachersRepository>();
builder.Services.AddScoped<IStudentsRepository, StudentsRepository>();
builder.Services.AddScoped<IEnrollmentsRepository, EnrollmentsRepository>();
builder.Services.AddScoped<ICoursesRepository, CoursesRepository>();


//----- END PERSONAL SERVICES -----//

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
