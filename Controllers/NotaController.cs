using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using escola.Models;
using escola.Data;
using escola.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace escola.Controllers;

public class NotaController : Controller
{
    private readonly INotaRepository NotaRepository;
    private readonly BancoContext BancoContext;

    public NotaController(INotaRepository notaRepository, BancoContext bancoContext)
    {
        NotaRepository = notaRepository;
        BancoContext = bancoContext;
    }
    public IActionResult Index()
    {
        List<Nota> nota = NotaRepository.listarnotas();
        return View(nota);
    }

    public IActionResult Create()
    {
        ViewBag.Matriculas = new SelectList(BancoContext.Matriculas, "MatriculaID", "MatriculaID");
        return View();
    }
    public IActionResult Edit(int id)
    {
        Nota nota = NotaRepository.IDfinder(id);
        ViewBag.Matriculas = new SelectList(BancoContext.Matriculas, "MatriculaID", "MatriculaID");
        return View(nota);
    }
    public IActionResult Delete(int id)
    {
        Nota nota = NotaRepository.IDfinder(id);
        return View(nota);
    }
    public IActionResult Remove(int id)
    {
        NotaRepository.Remove(id);
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Edit(Nota nota)
    {
            NotaRepository.EditarNota(nota);
            return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Create(Nota nota)
    {
        NotaRepository.Create(nota);
        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
