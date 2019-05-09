using Microsoft.EntityFrameworkCore;
using TesteTracking.Domain.Entities;

namespace TesteTracking
{
    public class ContextTeste : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"server=localhost; Port=5432; user id=postgres; password=senha!@#; database=Teste;");

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<ProdutoGrupo> Grupos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutoGrupoMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
