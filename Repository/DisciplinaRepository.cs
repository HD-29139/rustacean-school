using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using escola.Data;
using escola.Models;
using Microsoft.Identity.Client;

namespace escola.Repository
{
    public class DisciplinaRepository : IDisciplinaRepository
    {
        private readonly BancoContext bancoContext;

        public DisciplinaRepository(BancoContext bancoContext)
        {
            this.bancoContext = bancoContext;
        }

        public Disciplina Create(Disciplina disciplina)
        {
            bancoContext.Disciplinas.Add(disciplina);
            bancoContext.SaveChanges();
            return disciplina;
        }

        public Disciplina IDfinder(int id)
        {
            return bancoContext.Disciplinas.FirstOrDefault(x => x.DisciplinaID == id);
        }

        public List<Disciplina> listardisciplinas()
        {
            return bancoContext.Disciplinas.ToList();
        }

        public Disciplina EditarDisciplina(Disciplina disciplina)
        {
            Disciplina disciplinaEdit = IDfinder(disciplina.DisciplinaID) ?? throw new Exception("Disciplina não encontrada");
            disciplinaEdit.Nome = disciplina.Nome;
            bancoContext.Disciplinas.Update(disciplinaEdit);
            bancoContext.SaveChanges();
            return disciplinaEdit;
        }

        public bool Remove(int id)
        {
            Disciplina disciplina = IDfinder(id) ?? throw new Exception("Disciplina não encontrada");
            bancoContext.Disciplinas.Remove(disciplina);
            bancoContext.SaveChanges();
            return true;
        }
    }
}