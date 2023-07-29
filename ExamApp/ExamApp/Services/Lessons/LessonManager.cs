using ExamApp.Models.Grades;
using ExamApp.Models.Lessons;
using ExamApp.Repository;
using Microsoft.EntityFrameworkCore;

namespace ExamApp.Services.Lessons;

public class LessonManager : ILessonService
{
    private readonly ILessonRepository _lessonRepository;

    public LessonManager(ILessonRepository lessonRepository)
    {
        _lessonRepository = lessonRepository;
    }

    public async Task<List<LessonViewModel>> GetAll()
    {
        var lessons = await _lessonRepository.GetQuery().Where(x => x.Active)
            .Include(x => x.LessonGrades.Where(y=> !y.Deleted))
            .ThenInclude(x => x.Grade)
            .Select(x =>
                new LessonViewModel
                {
                    Code = x.Code,
                    Name = x.Name,
                    Grades = x.LessonGrades.Select(x => x.Grade.Value).ToList()
                }).ToListAsync();
            
        return lessons;
    }
}