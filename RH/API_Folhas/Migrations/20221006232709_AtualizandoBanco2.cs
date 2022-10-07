using Microsoft.EntityFrameworkCore.Migrations;

namespace API_FOlhas.Migrations
{
    public partial class AtualizandoBanco2 : Migration
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

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Funcionarios",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Funcionarios",
                type: "TEXT",
                maxLength: 11,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 11);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Funcionarios",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Funcionarios",
                type: "TEXT",
                maxLength: 11,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 11,
                oldNullable: true);

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
