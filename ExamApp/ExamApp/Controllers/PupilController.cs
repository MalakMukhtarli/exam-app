using ExamApp.Services.Pupils;
using Microsoft.AspNetCore.Mvc;

namespace ExamApp.Controllers;

public class PupilController : Controller
{
    public async Task<IActionResult> Index([FromServices] IPupilService service)
    {
        var data = await service.GetAll();
        return View(data);
    }  
}