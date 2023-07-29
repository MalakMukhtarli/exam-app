using ExamApp.Models.Pupils;

namespace ExamApp.Services.Pupils;

public interface IPupilService
{
    Task<List<PupilViewModel>> GetAll();
}