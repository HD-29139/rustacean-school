using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using escola.Models;

namespace escola.Repository
{
    public interface IMatriculaRepository
    {
        Matricula Create(Matricula matricula);
        List<Matricula> listarmatriculas();
        Matricula IDfinder(int id);
        Matricula EditarMatricula(Matricula matricula);
        bool Remove(int id);
    }
}