using ExamApp.Entities.Models;
using ExamApp.Models;
using ExamApp.Models.Grades;
using ExamApp.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExamApp.Services.Grades;

public class GradeManager : IGradeService
{
    private readonly IGradeRepository _gradeRepository;

    public GradeManager(IGradeRepository gradeRepository)
    {
        _gradeRepository = gradeRepository;
    }

    public async Task<List<GradeViewModel>> GetAll()
    {
        var grades = await _gradeRepository.GetQuery().Where(x => x.Active).Select(x=> 
            new GradeViewModel
            {
                Value = x.Value
            }).ToListAsync();
            
        return grades;
    }

    public async Task<ResultViewModel> Create(byte grade)
    {
        if (grade < 1 || grade > 12)
            return new ResultViewModel{ Error = true, Message = "Siniflər 0-dan aşağı və ya 11dən yuxarı ola bilməz"};
        
        var grades = await _gradeRepository.GetQuery().FirstOrDefaultAsync(x => x.Active && x.Value == grade);
            
        if (grades is not null)
            return new ResultViewModel{ Error = true, Message = "Bu sinif artıq yaradılıb"};;

        await _gradeRepository.AddAsync(new Grade{Value = grade});

        return new ResultViewModel{ Error = false, Message = "Əməliyyat uğurla bitirildi"};
    }
}