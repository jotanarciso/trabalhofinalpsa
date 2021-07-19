using Microsoft.EntityFrameworkCore.Migrations;

namespace CadastroAulas.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AulaAluno",
                columns: table => new
                {
                    key = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aluno = table.Column<string>(nullable: true),
                    Codcred = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AulaAluno", x => x.key);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AulaAluno");
        }
    }
}
