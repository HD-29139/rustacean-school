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
    public class MatriculaRepository : IMatriculaRepository
    {
        private readonly BancoContext bancoContext;

        public MatriculaRepository(BancoContext bancoContext)
        {
            this.bancoContext = bancoContext;
        }

        public Matricula Create(Matricula matricula)
        {
            bancoContext.Matriculas.Add(matricula);
            bancoContext.SaveChanges();
            return matricula;
        }

        public Matricula IDfinder(int id)
        {
            return bancoContext.Matriculas
            .Include(x => x.Aluno)
            .Include(x => x.Disciplina)
            .FirstOrDefault(x => x.MatriculaID == id);
        }

        public List<Matricula> listarmatriculas()
        {
            return bancoContext.Matriculas
            .Include(x => x.Aluno)
            .Include(x => x.Disciplina)
            .ToList();
        }

        public Matricula EditarMatricula(Matricula matricula)
        {
            Matricula matriculaEdit = IDfinder(matricula.MatriculaID) ?? throw new Exception("Matricula não encontrada");

            matriculaEdit.AlunoID = matricula.AlunoID;
            matriculaEdit.DisciplinaID = matricula.DisciplinaID;

            bancoContext.Matriculas.Update(matriculaEdit);
            bancoContext.SaveChanges();
            return matriculaEdit;
        }

        public bool Remove(int id)
        {
            Matricula matricula = IDfinder(id) ?? throw new Exception("Matricula não encontrada");
            bancoContext.Matriculas.Remove(matricula);
            bancoContext.SaveChanges();
            return true;
        }
    }
}