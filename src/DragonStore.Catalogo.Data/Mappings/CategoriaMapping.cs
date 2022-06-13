using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DragonStore.Catalogo.Domain;

namespace DragonStore.Catalogo.Data.Mappings
{
    public class CategoriaMapping : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("varchar(250)");

            // 1 : N => Categorias : Produtos
            builder.HasMany(c => c.Produtos)
                .WithOne(p => p.Categoria)
                .HasForeignKey(p => p.CategoriaId);

            builder.ToTable("Categorias");

            // Adiciona categorias padrão
            builder
               .HasData(
                    new Categoria("Armazenamento", 1, new Guid("7e265f96-f1ea-41f0-acbc-ec1e9ead3f91")),
                    new Categoria("Componentes", 2, new Guid("a5b8799e-2006-4f6b-ac07-f1f988d04adf")),
                     new Categoria("Periféricos", 3, new Guid("cf08c5a9-3d37-43cc-9246-05b0075a96ea")),
                     new Categoria("Computadores", 4, new Guid("e72a470c-fcdc-4869-a04b-e41155609d2f")));
            }
    }
}