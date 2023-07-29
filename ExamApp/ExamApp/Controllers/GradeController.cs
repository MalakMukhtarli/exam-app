using ExamApp.Services.Grades;
using Microsoft.AspNetCore.Mvc;

namespace ExamApp.Controllers;

public class GradeController : Controller
{
    public async Task<IActionResult> Index([FromServices] IGradeService service)
    {
        var data = await service.GetAll();
        return View(data);
    }
    
}