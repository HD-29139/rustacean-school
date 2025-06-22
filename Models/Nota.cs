using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace escola.Models
{
    public class Nota
    {
        public int NotaID { get; set; }
        public double Valor { get; set; }
        public int MatriculaID { get; set; }
        public Matricula Matricula { get; set; }
    }
}