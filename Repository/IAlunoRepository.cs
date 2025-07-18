using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using escola.Models;

namespace escola.Repository
{
    public interface IAlunoRepository
    {
        Aluno Create(Aluno aluno);
        List<Aluno> listaralunos();
        Aluno IDfinder(int id);
        Aluno EditarAluno(Aluno aluno);
        bool Remove(int id);
    }
}