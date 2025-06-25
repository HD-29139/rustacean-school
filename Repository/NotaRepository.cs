using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using escola.Data;
using escola.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace escola.Repository
{
    public class NotaRepository : INotaRepository
    {
        private readonly BancoContext bancoContext;

        public NotaRepository(BancoContext bancoContext)
        {
            this.bancoContext = bancoContext;
        }

        public Nota Create(Nota nota)
        {
            bancoContext.Notas.Add(nota);
            bancoContext.SaveChanges();
            return nota;
        }

        public Nota IDfinder(int id)
        {
            return bancoContext.Notas
            .Include(n => n.Matricula)
            .ThenInclude(m => m.Aluno)
            .Include(n => n.Matricula)
            .ThenInclude(m => m.Disciplina)
            .FirstOrDefault(n => n.NotaID == id);
        }

        public List<Nota> listarnotas()
        {
            return bancoContext.Notas
            .Include(n => n.Matricula)
            .ThenInclude(m => m.Aluno)
            .Include(n => n.Matricula)
            .ThenInclude(m => m.Disciplina)
            .ToList();
        }

        public Nota EditarNota(Nota nota)
        {
            Nota notaEdit = IDfinder(nota.NotaID) ?? throw new Exception("Nota não encontrada");

            notaEdit.Valor = nota.Valor;
            notaEdit.MatriculaID = nota.MatriculaID;

            bancoContext.Notas.Update(notaEdit);
            bancoContext.SaveChanges();
            return notaEdit;
        }

        public bool Remove(int id)
        {
            Nota nota = IDfinder(id) ?? throw new Exception("Nota não encontrada");
            bancoContext.Notas.Remove(nota);
            bancoContext.SaveChanges();
            return true;
        }
    }
}