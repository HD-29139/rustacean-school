using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace escola.Models
{
    public class Matricula
    {
        public int MatriculaID { get; set; }

        public int AlunoID { get; set; }
        public Aluno Aluno { get; set; }

        public int DisciplinaID { get; set; }
        public Disciplina Disciplina { get; set; }

        public ICollection<Nota> Notas { get; set; }
    }
}