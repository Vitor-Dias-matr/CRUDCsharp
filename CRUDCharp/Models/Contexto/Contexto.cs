using CRUDCharp.Models.Alunos;
using CRUDCharp.Models.Funcionarios;
using Microsoft.EntityFrameworkCore;

namespace CRUDCharp.Models.Contexto
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> option) : base(option)
        {
            Database.EnsureCreated();
        }

        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
    }
}
