using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace escola.Models
{
    public class Aluno
    {
        public int AlunoID { get; set; }
        public string Nome { get; set; }
        public ICollection<Matricula> Matriculas { get; set; }

    }
}