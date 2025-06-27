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
        List<Aluno> aluno = alunoRepository.listaralunos();
        return View(aluno);
    }

    public IActionResult Create()
    {
        return View();
    }
    public IActionResult Edit(int id)
    {
        Aluno aluno = alunoRepository.IDfinder(id);
        return View(aluno);
    }
    public IActionResult Delete(int id)
    {
        Aluno aluno = alunoRepository.IDfinder(id);
        return View(aluno);
    }
    public IActionResult Remove(int id)
    {
        alunoRepository.Remove(id);
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Edit(Aluno aluno)
    {
        if (aluno.Nome == null)
        {
            return View(aluno);
        }
        alunoRepository.EditarAluno(aluno);
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Create(Aluno aluno)
    {
        if (aluno.Nome == null)
        {
            return View(aluno);
        }
        alunoRepository.Create(aluno);
        return RedirectToAction("Index");

    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
