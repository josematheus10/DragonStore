using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DragonStore.Catalogo.Data.Migrations
{
    public partial class AddProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Ativo", "CategoriaId", "DataCadastro", "Descricao", "Imagem", "Nome", "QuantidadeEstoque", "Valor" },
                values: new object[] { new Guid("113e93b9-3bbf-45d9-a9ba-46cbdfa196b3"), true, new Guid("32954e23-4598-455b-bbbb-d75c66384811"), new DateTime(2022, 6, 13, 0, 11, 29, 500, DateTimeKind.Local).AddTicks(9469), "Logitech M280 Sem Fio Preto USB", "https://www.umpoukodetudo.com.br/media/catalog/product/cache/1/image/1000x/9df78eab33525d08d6e5fb8d27136e95/l/o/logitech_m280_1.jpg", "Mouse", 0, 110m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("113e93b9-3bbf-45d9-a9ba-46cbdfa196b3"));
        }
    }
}
