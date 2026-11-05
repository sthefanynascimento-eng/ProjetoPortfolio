using Microsoft.EntityFrameworkCore;
using ProjetoTurmaAlunoDto.Models;


namespace ProjetoTurmaAlunoDto.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {


        }


        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
    }
}