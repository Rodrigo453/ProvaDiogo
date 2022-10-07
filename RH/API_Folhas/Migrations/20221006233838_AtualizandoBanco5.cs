using Microsoft.EntityFrameworkCore.Migrations;

namespace API_FOlhas.Migrations
{
    public partial class AtualizandoBanco5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Funcionario",
                table: "FolhaPagamento",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "ImpostoFgts",
                table: "FolhaPagamento",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ImpostoInnss",
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

            migrationBuilder.CreateIndex(
                name: "IX_FolhaPagamento_Funcionario",
                table: "FolhaPagamento",
                column: "Funcionario");

            migrationBuilder.AddForeignKey(
                name: "FK_FolhaPagamento_Funcionarios_Funcionario",
                table: "FolhaPagamento",
                column: "Funcionario",
                principalTable: "Funcionarios",
                principalColumn: "FolhaPagamento",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FolhaPagamento_Funcionarios_Funcionario",
                table: "FolhaPagamento");

            migrationBuilder.DropIndex(
                name: "IX_FolhaPagamento_Funcionario",
                table: "FolhaPagamento");

            migrationBuilder.DropColumn(
                name: "Funcionario",
                table: "FolhaPagamento");

            migrationBuilder.DropColumn(
                name: "ImpostoFgts",
                table: "FolhaPagamento");

            migrationBuilder.DropColumn(
                name: "ImpostoInnss",
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
    }
}
