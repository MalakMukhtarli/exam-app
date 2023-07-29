using ExamApp.Models.Lessons;

namespace ExamApp.Services.Lessons;

public interface ILessonService
{
    Task<List<LessonViewModel>> GetAll();
}