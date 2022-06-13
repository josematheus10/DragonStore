using DragonStore.Catalogo.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DragonStore.Catalogo.Data.Mappings
{
    internal class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.Property(c => c.Descricao)
                .IsRequired()
                .HasColumnType("varchar(500)");

            builder.Property(c => c.Imagem)
                .IsRequired()
                .HasColumnType("varchar(250)");
     

            //builder.OwnsOne(c => c.Dimensoes, cm =>
            //{
            //    cm.Property(c => c.Altura)
            //        .HasColumnName("Altura")
            //        .HasColumnType("int");

            //    cm.Property(c => c.Largura)
            //        .HasColumnName("Largura")
            //        .HasColumnType("int");

            //    cm.Property(c => c.Profundidade)
            //        .HasColumnName("Profundidade")
            //        .HasColumnType("int");
            //});

            builder.ToTable("Produtos");

            builder.HasData( new Produto(
                       "Mouse",
                       "Logitech M280 Sem Fio Preto USB",
                       true,
                       110,
                       Guid.Parse("32954e23-4598-455b-bbbb-d75c66384811"),
                       DateTime.Now,
                       "https://www.umpoukodetudo.com.br/media/catalog/product/cache/1/image/1000x/9df78eab33525d08d6e5fb8d27136e95/l/o/logitech_m280_1.jpg"
                    ));
        }
    }
}
