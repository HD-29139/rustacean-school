using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using escola.Data;
using escola.Models;
using Microsoft.Identity.Client;

namespace escola.Repository
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly BancoContext bancoContext;

        public AlunoRepository(BancoContext bancoContext)
        {
            this.bancoContext = bancoContext;
        }

        public Aluno Create(Aluno aluno)
        {
            bancoContext.Alunos.Add(aluno);
            bancoContext.SaveChanges();
            return aluno;
        }

        public Aluno IDfinder(int id)
        {
            return bancoContext.Alunos.FirstOrDefault(x => x.AlunoID == id);
        }

        public List<Aluno> listaralunos()
        {
            return bancoContext.Alunos.ToList();
        }

        public Aluno EditarAluno(Aluno aluno)
        {
            Aluno alunoEdit = IDfinder(aluno.AlunoID) ?? throw new Exception("Aluno não encontrado");
            alunoEdit.Nome = aluno.Nome;
            bancoContext.Alunos.Update(alunoEdit);
            bancoContext.SaveChanges();
            return alunoEdit;
        }
    }
}