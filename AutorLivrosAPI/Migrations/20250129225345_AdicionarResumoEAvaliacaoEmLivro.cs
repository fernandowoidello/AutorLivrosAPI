using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutorLivrosAPI.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarResumoEAvaliacaoEmLivro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "sobrenome",
                table: "Autores",
                newName: "Sobrenome");

            migrationBuilder.AddColumn<double>(
                name: "Avaliação",
                table: "Livros",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Resumo",
                table: "Livros",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Avaliação",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "Resumo",
                table: "Livros");

            migrationBuilder.RenameColumn(
                name: "Sobrenome",
                table: "Autores",
                newName: "sobrenome");
        }
    }
}
