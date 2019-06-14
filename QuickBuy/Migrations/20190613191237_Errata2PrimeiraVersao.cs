using Microsoft.EntityFrameworkCore.Migrations;

namespace QuickBuy.Repositorio.Migrations
{
    public partial class Errata2PrimeiraVersao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "NumeroEndereco",
                table: "Pedidos",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NumeroEndereco",
                table: "Pedidos",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 11);
        }
    }
}
