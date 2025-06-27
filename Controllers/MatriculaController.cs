using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using escola.Models;
using escola.Data;
using escola.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace escola.Controllers;

public class MatriculaController : Controller
{
    private readonly IMatriculaRepository MatriculaRepository;
    private readonly BancoContext BancoContext;

    public MatriculaController(IMatriculaRepository matriculaRepository, BancoContext bancoContext)
    {
        MatriculaRepository = matriculaRepository;
        BancoContext = bancoContext;
    }
    public IActionResult Index()
    {
        List<Matricula> matricula = MatriculaRepository.listarmatriculas();
        return View(matricula);
    }

    public IActionResult Create()
    {
        ViewBag.Alunos = new SelectList(BancoContext.Alunos, "AlunoID", "Nome");
        ViewBag.Disciplinas = new SelectList(BancoContext.Disciplinas, "DisciplinaID", "Nome");
        return View();
    }
    public IActionResult Edit(int id)
    {
        Matricula matricula = MatriculaRepository.IDfinder(id);
        ViewBag.Alunos = new SelectList(BancoContext.Alunos, "AlunoID", "Nome");
        ViewBag.Disciplinas = new SelectList(BancoContext.Disciplinas, "DisciplinaID", "Nome");
        return View(matricula);
    }
    public IActionResult Delete(int id)
    {
        Matricula matricula = MatriculaRepository.IDfinder(id);
        return View(matricula);
    }
    public IActionResult Remove(int id)
    {
        MatriculaRepository.Remove(id);
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Edit(Matricula matricula)
    {
         bool jaExiste = BancoContext.Matriculas
        .Any(m => m.AlunoID == matricula.AlunoID && m.DisciplinaID == matricula.DisciplinaID);

    if (jaExiste)
    {
        ModelState.AddModelError("", "Este aluno já está matriculado nesta disciplina.");

        ViewBag.Alunos = new SelectList(BancoContext.Alunos, "AlunoID", "Nome");
        ViewBag.Disciplinas = new SelectList(BancoContext.Disciplinas, "DisciplinaID", "Nome");
        return View(matricula);
    }
        MatriculaRepository.EditarMatricula(matricula);
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Create(Matricula matricula)
    {
                 bool jaExiste = BancoContext.Matriculas
        .Any(m => m.AlunoID == matricula.AlunoID && m.DisciplinaID == matricula.DisciplinaID);

    if (jaExiste)
    {
        ModelState.AddModelError("", "Este aluno já está matriculado nesta disciplina.");

        ViewBag.Alunos = new SelectList(BancoContext.Alunos, "AlunoID", "Nome");
        ViewBag.Disciplinas = new SelectList(BancoContext.Disciplinas, "DisciplinaID", "Nome");
        return View(matricula);
    }
        MatriculaRepository.Create(matricula);
        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
