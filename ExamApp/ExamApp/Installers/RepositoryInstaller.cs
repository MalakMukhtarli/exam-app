using ExamApp.Repository;
using ExamApp.Repository.Concrete;

namespace ExamApp.Installers;

public class RepositoryInstaller : IInstaller
{
    public void InstallServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped(typeof(IRepositoryAsync<>), typeof(RepositoryBase<>));
        services.AddScoped<IGradeRepository, GradeRepository>();

    }
}