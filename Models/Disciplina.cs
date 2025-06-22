using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace escola.Models
{
    public class Disciplina
    {
        public int DisciplinaID { get; set; }
        public string Nome { get; set; }
        public ICollection<Matricula> Matriculas { get; set; }
    }
}