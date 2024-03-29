using Microsoft.EntityFrameworkCore;
using SmartSchool.API.Models;

namespace COMERCIAL02.Desktop.myDocuments.WORKSPACE.SmartSchool.SmartSchool.Data
{
    public class SmartContext : DbContext
    {
        public SmartContext(DbContextOptions<SmartContext> options) : base(options) { }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<AlunoDisciplina> AlunosDisciplinas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AlunoDisciplina>()
                .HasKey(AD => new { AD.AlunoId, AD.DisciplinaId });
        }
    }
}