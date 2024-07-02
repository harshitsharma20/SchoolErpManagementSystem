using BusinessAccessLayer;
using DataAccessLayer;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using NLog;
using NLog.Web;
using SharedLayer;

var logger = LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
logger.Debug("init Program.cs");
try
{
    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.

    builder.Services.AddControllers().AddFluentValidation(v => v.RegisterValidatorsFromAssemblyContaining<StudentDTO>());
    builder.Services.AddScoped(typeof(IStudentRepository),typeof(StudentRepository));
    builder.Services.AddScoped(typeof(IStudentService), typeof(StudentService));
    builder.Services.AddScoped(typeof(ITeacherRepository), typeof(TeacherRepository));
    builder.Services.AddScoped(typeof(ITeacherService), typeof(TeacherService));
    builder.Services.AddScoped(typeof(IResultRepository), typeof(ResultRepository));
    builder.Services.AddScoped(typeof(IResultServices), typeof(ResultService));
    builder.Services.AddScoped(typeof(ISubjectRepository), typeof(SubjectRepository));
    builder.Services.AddScoped(typeof(ISubjectServices), typeof(SubjectService));
    builder.Services.AddScoped(typeof(IAuthorizationRepository), typeof(AuthorizationRepository));
    builder.Services.AddScoped(typeof(IAuthorizationService), typeof(AuthorizationService));
    builder.Services.AddScoped(typeof(IStudentSubjectRepository), typeof(StudentSubjectRepository));
    builder.Services.AddScoped(typeof(IStudentSubjectService), typeof(StudentSubjectService));
    builder.Services.AddAutoMapper(typeof(ProjectDbContext));
    builder.Services.AddCors(options =>
    {
        options.AddDefaultPolicy(builder =>
        {
            builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
        });
    });
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    //Connection String
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    builder.Services.AddDbContext<ProjectDbContext>(options => options.UseSqlServer(connectionString));

    builder.Services.AddSwaggerGen();
    // NLog: Setup NLog for Dependency injection
    builder.Logging.ClearProviders();
    builder.Host.UseNLog();

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseRouting();

    app.UseCors();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}
catch (Exception exception)
{
    // NLog: catch setup errors
    logger.Error(exception, "Stopped program because of exception");
    throw;
}
finally
{
    // Ensure to flush and stop internal timers/threads before application-exit (Avoid segmentation fault on Linux)
    LogManager.Shutdown();
}
