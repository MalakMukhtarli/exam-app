using ExamApp.Entities.Models;
using ExamApp.Persistence;

namespace ExamApp.Repository.Concrete;

public class GradeRepository : RepositoryBase<Grade>, IGradeRepository
{
    public GradeRepository(AppDbContext databaseContext) : base(databaseContext)
    {
    }
}