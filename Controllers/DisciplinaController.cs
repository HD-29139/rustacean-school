using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using escola.Models;
using escola.Data;
using escola.Repository;

namespace escola.Controllers;

public class DisciplinaController : Controller
{
    private readonly IDisciplinaRepository DisciplinaRepository;

    public DisciplinaController(IDisciplinaRepository disciplinaRepository)
    {
        DisciplinaRepository = disciplinaRepository;
    }
    public IActionResult Index()
    {
        List<Disciplina> disciplina = DisciplinaRepository.listardisciplinas();
        return View(disciplina);
    }

    public IActionResult Create()
    {
        return View();
    }
    public IActionResult Edit(int id)
    {
        Disciplina disciplina = DisciplinaRepository.IDfinder(id);
        return View(disciplina);
    }
    public IActionResult Delete(int id)
    {
        Disciplina disciplina = DisciplinaRepository.IDfinder(id);
        return View(disciplina);
    }
    public IActionResult Remove(int id)
    {
        DisciplinaRepository.Remove(id);
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Edit(Disciplina disciplina)
    {
        if (disciplina.Nome == null)
        {
            return View(disciplina);
        }
        DisciplinaRepository.EditarDisciplina(disciplina);
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Create(Disciplina disciplina)
    {
        if (disciplina.Nome == null)
        {
            return View(disciplina);
        }
        DisciplinaRepository.Create(disciplina);
        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
