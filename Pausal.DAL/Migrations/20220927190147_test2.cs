using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pausal.DAL.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RobaUsluga_StavkaFakture_StavkaFaktureId",
                table: "RobaUsluga");

            migrationBuilder.DropIndex(
                name: "IX_RobaUsluga_StavkaFaktureId",
                table: "RobaUsluga");

            migrationBuilder.DropColumn(
                name: "StavkaFaktureId",
                table: "RobaUsluga");

            migrationBuilder.AddColumn<int>(
                name: "RobaUslugaId",
                table: "StavkaFakture",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StavkaFakture_RobaUslugaId",
                table: "StavkaFakture",
                column: "RobaUslugaId");

            migrationBuilder.AddForeignKey(
                name: "FK_StavkaFakture_RobaUsluga_RobaUslugaId",
                table: "StavkaFakture",
                column: "RobaUslugaId",
                principalTable: "RobaUsluga",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StavkaFakture_RobaUsluga_RobaUslugaId",
                table: "StavkaFakture");

            migrationBuilder.DropIndex(
                name: "IX_StavkaFakture_RobaUslugaId",
                table: "StavkaFakture");

            migrationBuilder.DropColumn(
                name: "RobaUslugaId",
                table: "StavkaFakture");

            migrationBuilder.AddColumn<int>(
                name: "StavkaFaktureId",
                table: "RobaUsluga",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RobaUsluga_StavkaFaktureId",
                table: "RobaUsluga",
                column: "StavkaFaktureId");

            migrationBuilder.AddForeignKey(
                name: "FK_RobaUsluga_StavkaFakture_StavkaFaktureId",
                table: "RobaUsluga",
                column: "StavkaFaktureId",
                principalTable: "StavkaFakture",
                principalColumn: "Id");
        }
    }
}
