using AutoMapper;
using ExamCommon.Mapper;
using ExamDB.Interfaces;
using ExamDB.DBOperations;
using ExamDB;

public class Startup
{
    public IConfiguration Configuration { get; }
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }
    public void ConfigureServices(IServiceCollection services)
    {

        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        var mapConfig = new MapperConfiguration(mc =>
        {
            mc.AddProfile<MappingProfile>();
        });
        IMapper mapper = new Mapper(mapConfig);
        var connectionStrings = Configuration.GetSection("ConnectionStrings");
        services.AddSingleton<IAppointmentDBOperations, AppointmentDBOperations>();
        services.AddSingleton<IClientDBOperations, ClientDBOperations>();
        services.AddSingleton(mapper);
        services.AddSqlServer<DBContext>(connectionStrings["CarsDbContext"]);
        services.AddDbContext<DBContext>();
        services.AddControllers();
        services.AddCors();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {


        app.UseSwagger();
        app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", ""));

        app.UseRouting();

        app.UseCors(x => x
          .AllowAnyMethod()
          .AllowAnyHeader()
          .SetIsOriginAllowed(origin => true)
          .AllowCredentials());

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });

        app.UseHttpsRedirection();

        app.UseAuthorization();

    }
}






