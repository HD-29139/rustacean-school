using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using escola.Models;

namespace escola.Controllers;

public class NotaController : Controller
{
    private readonly ILogger<NotaController> _logger;

    public NotaController(ILogger<NotaController> logger)
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
