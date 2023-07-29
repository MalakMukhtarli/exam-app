using ExamApp.Models.Admins;
using ExamApp.Services.Grades;
using Microsoft.AspNetCore.Mvc;

namespace ExamApp.Controllers;

public class AdminController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateGrade(AdminViewModel model, [FromServices] IGradeService gradeService)
    {
        var result = await gradeService.Create(model.Grade.Value);

        if (result.Error)
        {
            ModelState.AddModelError("", $"{result.Message}");
            return View("Index");
        }
        
        return RedirectToAction("Index", "Admin");
    }
}