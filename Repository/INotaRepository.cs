using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using escola.Models;

namespace escola.Repository
{
    public interface INotaRepository
    {
        Nota Create(Nota nota);
        List<Nota> listarnotas();
        Nota IDfinder(int id);
        Nota EditarNota(Nota nota);
        bool Remove(int id);
    }
}