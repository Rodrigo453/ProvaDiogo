using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API_FOlhas.Migrations
{
    public partial class AtualizandoBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Folhas",
                table: "Folhas");

            migrationBuilder.RenameTable(
                name: "Folhas",
                newName: "FolhaPagamento");

            migrationBuilder.RenameColumn(
                name: "FuncionarioId",
                table: "Funcionarios",
                newName: "FolhaPagamento");

            migrationBuilder.AlterColumn<int>(
                name: "FolhaPagamento",
                table: "Funcionarios",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CriadoEm",
                table: "FolhaPagamento",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
                name: "QuantidadeHoras",
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

            migrationBuilder.AddColumn<double>(
                name: "ValorHora",
                table: "FolhaPagamento",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FolhaPagamento",
                table: "FolhaPagamento",
                column: "FolhaPagamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionarios_FolhaPagamento_FolhaPagamento",
                table: "Funcionarios",
                column: "FolhaPagamento",
                principalTable: "FolhaPagamento",
                principalColumn: "FolhaPagamentoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_FolhaPagamento_FolhaPagamento",
                table: "Funcionarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FolhaPagamento",
                table: "FolhaPagamento");

            migrationBuilder.DropColumn(
                name: "CriadoEm",
                table: "FolhaPagamento");

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
                name: "QuantidadeHoras",
                table: "FolhaPagamento");

            migrationBuilder.DropColumn(
                name: "SalarioBruto",
                table: "FolhaPagamento");

            migrationBuilder.DropColumn(
                name: "SalarioLiquido",
                table: "FolhaPagamento");

            migrationBuilder.DropColumn(
                name: "ValorHora",
                table: "FolhaPagamento");

            migrationBuilder.RenameTable(
                name: "FolhaPagamento",
                newName: "Folhas");

            migrationBuilder.RenameColumn(
                name: "FolhaPagamento",
                table: "Funcionarios",
                newName: "FuncionarioId");

            migrationBuilder.AlterColumn<int>(
                name: "FuncionarioId",
                table: "Funcionarios",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Folhas",
                table: "Folhas",
                column: "FolhaPagamentoId");
        }
    }
}
