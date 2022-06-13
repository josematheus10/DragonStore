﻿// <auto-generated />
using System;
using DragonStore.Catalogo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DragonStore.Catalogo.Data.Migrations
{
    [DbContext(typeof(CatalogoContext))]
    partial class CatalogoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DragonStore.Catalogo.Domain.Categoria", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Categorias", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("7e265f96-f1ea-41f0-acbc-ec1e9ead3f91"),
                            Codigo = 1,
                            Nome = "Armazenamento"
                        },
                        new
                        {
                            Id = new Guid("a5b8799e-2006-4f6b-ac07-f1f988d04adf"),
                            Codigo = 2,
                            Nome = "Componentes"
                        },
                        new
                        {
                            Id = new Guid("cf08c5a9-3d37-43cc-9246-05b0075a96ea"),
                            Codigo = 3,
                            Nome = "Periféricos"
                        },
                        new
                        {
                            Id = new Guid("e72a470c-fcdc-4869-a04b-e41155609d2f"),
                            Codigo = 4,
                            Nome = "Computadores"
                        });
                });

            modelBuilder.Entity("DragonStore.Catalogo.Domain.Produto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<Guid>("CategoriaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<int>("QuantidadeEstoque")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Produtos", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("113e93b9-3bbf-45d9-a9ba-46cbdfa196b3"),
                            Ativo = true,
                            CategoriaId = new Guid("32954e23-4598-455b-bbbb-d75c66384811"),
                            DataCadastro = new DateTime(2022, 6, 13, 0, 11, 29, 500, DateTimeKind.Local).AddTicks(9469),
                            Descricao = "Logitech M280 Sem Fio Preto USB",
                            Imagem = "https://www.umpoukodetudo.com.br/media/catalog/product/cache/1/image/1000x/9df78eab33525d08d6e5fb8d27136e95/l/o/logitech_m280_1.jpg",
                            Nome = "Mouse",
                            QuantidadeEstoque = 0,
                            Valor = 110m
                        });
                });

            modelBuilder.Entity("DragonStore.Catalogo.Domain.Produto", b =>
                {
                    b.HasOne("DragonStore.Catalogo.Domain.Categoria", "Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("DragonStore.Catalogo.Domain.Categoria", b =>
                {
                    b.Navigation("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}