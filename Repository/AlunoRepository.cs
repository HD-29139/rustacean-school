using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using escola.Data;
using escola.Models;

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
    }
}