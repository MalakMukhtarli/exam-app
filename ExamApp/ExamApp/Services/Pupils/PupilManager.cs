using ExamApp.Models.Grades;
using ExamApp.Models.Pupils;
using ExamApp.Repository;
using Microsoft.EntityFrameworkCore;

namespace ExamApp.Services.Pupils;

public class PupilManager : IPupilService
{
    private readonly IPupilRepository _pupilRepository;

    public PupilManager(IPupilRepository pupilRepository)
    {
        _pupilRepository = pupilRepository;
    }

    public async Task<List<PupilViewModel>> GetAll()
    {
        var grades = await _pupilRepository.GetQuery().Where(x => x.Active)
            .Include(x=>x.PupilGrades.Where(y=> !y.Deleted))
            .ThenInclude(x=>x.Grade)
            .Select(x=> 
            new PupilViewModel
            {
                Number = x.Number,
                Name = x.Name,
                Surname = x.Surname,
                Grade = x.PupilGrades.FirstOrDefault().Grade.Value
            }).ToListAsync();
            
        return grades;
    }
}