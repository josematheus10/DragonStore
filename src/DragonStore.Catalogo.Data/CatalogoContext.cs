using DragonStore.Catalogo.Domain;
using DragonStore.Core.Data;
using Microsoft.EntityFrameworkCore;

namespace DragonStore.Catalogo.Data
{
    public class CatalogoContext : DbContext, IUnitOfWork
    {
        public CatalogoContext(DbContextOptions<CatalogoContext> options) 
            : base(options) { }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder
                         .Model
                         .GetEntityTypes()
                         .SelectMany(
                             e => e.GetProperties()
                                 .Where(p => p.ClrType == typeof(string))))
            {
                property.SetColumnType("varchar(100)");
            }

            base.OnModelCreating(modelBuilder);
        }


        public Task<bool> Commit()
        {
            throw new NotImplementedException();
        }
    }
}