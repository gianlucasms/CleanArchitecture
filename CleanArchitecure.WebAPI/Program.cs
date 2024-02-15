using CleanArchitecure.Persistence.Context;
using CleanArchitecure.Persistence;
using CleanArchitecture.Application.Services;
using CleanArchitecure.Domain.Interfaces;
using CleanArchitecure.Persistence.Repositories;

namespace CleanArchitecure.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.ConfigurePersistenceApp(builder.Configuration);
            builder.Services.ConfigureApplicationApp();

            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            CreateDatabase(app);

            app.UseSwagger();
            app.UseSwaggerUI();
            app.MapControllers();
            app.Run();

        }

        static void CreateDatabase(WebApplication app)
        {
            var serviceScope = app.Services.CreateScope();
            var dataContext = serviceScope.ServiceProvider.GetService<AppDbContext>();
            dataContext?.Database.EnsureCreated();
        }
    }
}

