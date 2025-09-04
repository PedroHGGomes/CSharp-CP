using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TDS_TB_BRINQUEDOS",
                columns: table => new
                {
                    ID_BRINQUEDO = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NOME_BRINQUEDO = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    TIPO_BRINQUEDO = table.Column<string>(type: "NVARCHAR2(60)", maxLength: 60, nullable: false),
                    CLASSIFICACAO = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: false),
                    TAMANHO = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: false),
                    PRECO = table.Column<decimal>(type: "DECIMAL(10,2)", precision: 10, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TDS_TB_BRINQUEDOS", x => x.ID_BRINQUEDO);
                });

            migrationBuilder.InsertData(
                table: "TDS_TB_BRINQUEDOS",
                columns: new[] { "ID_BRINQUEDO", "CLASSIFICACAO", "NOME_BRINQUEDO", "PRECO", "TAMANHO", "TIPO_BRINQUEDO" },
                values: new object[,]
                {
                    { 1, "Livre", "Carrinho", 29.90m, "Pequeno", "Veículo" },
                    { 2, "Livre", "Boneca", 59.90m, "Médio", "Boneca" },
                    { 3, "+6", "Quebra-cabeça 100 peças", 39.90m, "Médio", "Puzzle" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TDS_TB_BRINQUEDOS");
        }
    }
}
