using Microsoft.EntityFrameworkCore;

namespace ResultadosAlunosMVC.Models
{
    public class Context : DbContext
    {
        public DbSet<AlunoModel> DboAluno { get; set; }
        //        public DbSet<ResultadosAlunosMVC.Models.Nota> Notas { get; set; }
        //public DbSet<Faltas> Faltas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Resultadosalunos;Integrated Security=true");
        }
    }
}
