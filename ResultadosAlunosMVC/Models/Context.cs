using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResultadosAlunosMVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Alunos> Alunos { get; set; }
        //public DbSet<Alunos> Notas { get; set; }
        //public DbSet<Alunos> Faltas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Resultadosalunos;Integrated Security=true");
        }
    }
}
