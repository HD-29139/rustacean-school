using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using escola.Models;
using escola.Data;
using escola.Repository;

namespace escola.Controllers;

public class AlunoController : Controller
{
    private readonly IAlunoRepository alunoRepository;

    public AlunoController(IAlunoRepository AlunoRepository)
    {
        alunoRepository = AlunoRepository;
    }
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Aluno aluno)
    {
        alunoRepository.Create(aluno);
        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
