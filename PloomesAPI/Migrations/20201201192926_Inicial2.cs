using Microsoft.EntityFrameworkCore.Migrations;

namespace PloomesAPI.Migrations
{
    public partial class Inicial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Produto",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Descricao",
                table: "Produto",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
