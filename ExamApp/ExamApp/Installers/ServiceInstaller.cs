using ExamApp.Services.Grades;

namespace ExamApp.Installers;

public class ServiceInstaller : IInstaller
{
    public void InstallServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IGradeService, GradeManager>();
        
    }
}