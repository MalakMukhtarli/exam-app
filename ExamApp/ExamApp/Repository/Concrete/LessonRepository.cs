using ExamApp.Entities.Models;
using ExamApp.Persistence;

namespace ExamApp.Repository.Concrete;

public class LessonRepository : RepositoryBase<Lesson>, ILessonRepository
{
    public LessonRepository(AppDbContext databaseContext) : base(databaseContext)
    {
    }
}