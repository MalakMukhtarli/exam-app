using ExamApp.Entities.Models;
using ExamApp.Persistence;

namespace ExamApp.Repository.Concrete;

public class PupilRepository : RepositoryBase<Pupil>, IPupilRepository
{
    public PupilRepository(AppDbContext databaseContext) : base(databaseContext)
    {
    }
}