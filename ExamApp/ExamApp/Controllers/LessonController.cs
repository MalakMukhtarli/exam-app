using ExamApp.Services.Lessons;
using Microsoft.AspNetCore.Mvc;

namespace ExamApp.Controllers;

public class LessonController : Controller
{
    public async Task<IActionResult> Index([FromServices] ILessonService service)
    {
        var data = await service.GetAll();
        return View(data);
    }   
}