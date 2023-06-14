using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VarejistaProduto.Server.Migrations
{
    /// <inheritdoc />
    public partial class InputDadosTabelaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "DataCadastro", "Descricao", "Nome", "PrecoVenda", "Quantidade", "Tipo" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 13, 23, 49, 14, 998, DateTimeKind.Local).AddTicks(9368), "A Banana Nanica vai bem pura mesmo, banana com aveia, banana à milanesa e também pode ser utilizada para o preparo de bolos, tortas, entre outros. Fonte: Conquiste Sua Vida", "Banana Nanica", 6.30m, 20, "Orgânico" },
                    { 2, new DateTime(2023, 6, 13, 23, 49, 14, 998, DateTimeKind.Local).AddTicks(9379), "A Uva Thompson é uma das queridinhas espécies de uva sem sementes. Sua origem é turca ou grega, mas devido ao clima com muito sol e chuvas esporádicas, seu cultivo se adaptou muito bem ao clima brasileiro.", "Uva Thompsom", 12.30m, 12, "Não orgânico" },
                    { 3, new DateTime(2023, 6, 13, 23, 49, 14, 998, DateTimeKind.Local).AddTicks(9381), "A batata doce é uma fonte de carboidrato saudável, famosa por ser o alimento predileto de quem quer ganhar massa muscular.", "Batata Doce", 5.40m, 13, "Orgânico" },
                    { 4, new DateTime(2023, 6, 13, 23, 49, 14, 998, DateTimeKind.Local).AddTicks(9383), "Os Ovos Vermelhos Caipira Ito Vita são frescos, produzidos por galinhas criadas em espaços adequados aos seus comportamentos naturais como ciscar o chão, bater asas e se empoleirar.", "Ovos Caipira", 23.30m, 6, "Orgânico" },
                    { 5, new DateTime(2023, 6, 13, 23, 49, 14, 998, DateTimeKind.Local).AddTicks(9384), "O tomate italiano tem uma consistência mais encorpada em relação aos outros tipos existentes.", "Tomate Italiano", 10.30m, 30, "Não orgânico" },
                    { 6, new DateTime(2023, 6, 13, 23, 49, 14, 998, DateTimeKind.Local).AddTicks(9386), "A batata é um alimento presente diariamente na mesa dos brasileiros, um alimento de fácil cultivo, existem variedades de batatas, com diferentes tamanhos e cores.", "Batata", 6.34m, 40, "Não orgânico" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
