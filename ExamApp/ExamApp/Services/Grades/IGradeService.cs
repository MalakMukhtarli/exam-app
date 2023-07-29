using ExamApp.Models;
using ExamApp.Models.Grades;

namespace ExamApp.Services.Grades;

public interface IGradeService
{
    Task<List<GradeViewModel>> GetAll();
    Task<ResultViewModel> Create(byte grade);
}