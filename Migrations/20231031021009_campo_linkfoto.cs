using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LivroRecomendacao.Migrations
{
    public partial class campo_linkfoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LinkFoto",
                table: "Livro",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LinkFoto",
                table: "Livro");
        }
    }
}
