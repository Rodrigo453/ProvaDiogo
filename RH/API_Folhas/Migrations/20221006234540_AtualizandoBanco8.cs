using Microsoft.EntityFrameworkCore.Migrations;

namespace API_FOlhas.Migrations
{
    public partial class AtualizandoBanco8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_FolhaPagamento_FolhaPagamento",
                table: "Funcionarios");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionarios_FolhaPagamento_FolhaPagamento",
                table: "Funcionarios",
                column: "FolhaPagamento",
                principalTable: "FolhaPagamento",
                principalColumn: "FolhaPagamentoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
