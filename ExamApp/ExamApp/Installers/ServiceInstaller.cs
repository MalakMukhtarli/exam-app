using ExamApp.Services.Grades;
using ExamApp.Services.Lessons;
using ExamApp.Services.Pupils;

namespace ExamApp.Installers;

public class ServiceInstaller : IInstaller
{
    public void InstallServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IGradeService, GradeManager>();
        services.AddScoped<ILessonService, LessonManager>();
        services.AddScoped<IPupilService, PupilManager>();
        
    }
}