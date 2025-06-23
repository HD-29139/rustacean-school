using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using escola.Models;

namespace escola.Repository
{
    public interface IDisciplinaRepository
    {
        Disciplina Create(Disciplina disciplina);
        List<Disciplina> listardisciplinas();
        Disciplina IDfinder(int id);
        Disciplina EditarDisciplina(Disciplina disciplina);
        bool Remove(int id);
    }
}