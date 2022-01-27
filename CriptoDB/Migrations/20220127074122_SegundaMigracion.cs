using Microsoft.EntityFrameworkCore.Migrations;

namespace CriptoDB.Migrations
{
    public partial class SegundaMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MonedaId",
                table: "Contrato",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contrato_MonedaId",
                table: "Contrato",
                column: "MonedaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contrato_Moneda_MonedaId",
                table: "Contrato",
                column: "MonedaId",
                principalTable: "Moneda",
                principalColumn: "MonedaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contrato_Moneda_MonedaId",
                table: "Contrato");

            migrationBuilder.DropIndex(
                name: "IX_Contrato_MonedaId",
                table: "Contrato");

            migrationBuilder.AlterColumn<string>(
                name: "MonedaId",
                table: "Contrato",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }
    }
}
