using ExamApp.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ExamApp.Installers;

public class DbContextInstaller : IInstaller
{
    public void InstallServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("Default")));
    }
}