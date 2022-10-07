using Microsoft.EntityFrameworkCore.Migrations;

namespace API_FOlhas.Migrations
{
    public partial class AtualizandoBanco4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImpostoFgts",
                table: "FolhaPagamento");

            migrationBuilder.DropColumn(
                name: "ImpostoInss",
                table: "FolhaPagamento");

            migrationBuilder.DropColumn(
                name: "ImpostoRenda",
                table: "FolhaPagamento");

            migrationBuilder.DropColumn(
                name: "SalarioBruto",
                table: "FolhaPagamento");

            migrationBuilder.DropColumn(
                name: "SalarioLiquido",
                table: "FolhaPagamento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "ImpostoFgts",
                table: "FolhaPagamento",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ImpostoInss",
                table: "FolhaPagamento",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ImpostoRenda",
                table: "FolhaPagamento",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SalarioBruto",
                table: "FolhaPagamento",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SalarioLiquido",
                table: "FolhaPagamento",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
