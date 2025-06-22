using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using escola.Models;

namespace escola.Controllers;

public class MatriculaController : Controller
{
    private readonly ILogger<MatriculaController> _logger;

    public MatriculaController(ILogger<MatriculaController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
