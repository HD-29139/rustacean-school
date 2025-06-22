using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using escola.Models;
using Microsoft.EntityFrameworkCore;

namespace escola.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<Nota> Notas { get; set; }
    }
}