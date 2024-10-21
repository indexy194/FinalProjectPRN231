using FinalProjectPRN231.API.DTO.Configurations;
using FinalProjectPRN231.API.Infra.Data;
using FinalProjectPRN231.API.Services;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace FinalProjectPRN231.API
{
    public static class HostingExtentions
    {
        private const string MyAllowSpecificOrigins = "AllowOrigin";
        public static void ConfigureServices(this WebApplicationBuilder builder)
        {
            builder.Host.ConfigureAppConfiguration((hostingContext, config) => { ApiSettings.Instance.SetConfiguration(hostingContext.Configuration); });
            builder.Host.UseSerilog((hostContext, services, configuration) =>
            {
                configuration.ReadFrom.Configuration(hostContext.Configuration);
            });
            // Add services to the container.
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddAuthentication();
            builder.Services.AddAuthorization();
            builder.Services.AddCors(o => o.AddPolicy("AllowOrigin", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));
            var str = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(str ?? throw new InvalidOperationException("Connection is not found"));
            });
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            //DI
            builder.Services.AddScoped<IAttendanceHourServices, AttendanceHourServices>();
            builder.Services.AddScoped<IAttendanceServices, AttendanceServices>();
            builder.Services.AddScoped<IDepartmentServices, DepartmentServices>();
            builder.Services.AddScoped<IEducationLevelServices, EducationLevelServices>();
            builder.Services.AddScoped<IEmployeerServices, EmployeerServices>();
            builder.Services.AddScoped<IJobDetailServices, JobDetailServices>();
            builder.Services.AddScoped<IlocationServices, LocationServices>();
            builder.Services.AddScoped<ISalaryServices, SalaryServices>();
            builder.Services.AddScoped<IWorkExperienceServices, WorkExperienceServices>();
           
        }
        public static WebApplication ConfigurePipeline(this WebApplication app)
        {
            app.UseSerilogRequestLogging();
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseCors(MyAllowSpecificOrigins);
            app.UseAuthentication();
            app.UseAuthorization();
            app.MapControllers();
            return app;
        }
    }
}
