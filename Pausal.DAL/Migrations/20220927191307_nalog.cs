using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pausal.DAL.Migrations
{
    public partial class nalog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nalog_Racun_RacunUplatiocaId",
                table: "Nalog");

            migrationBuilder.DropIndex(
                name: "IX_Nalog_RacunUplatiocaId",
                table: "Nalog");

            migrationBuilder.DropColumn(
                name: "RacunUplatiocaId",
                table: "Nalog");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RacunUplatiocaId",
                table: "Nalog",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nalog_RacunUplatiocaId",
                table: "Nalog",
                column: "RacunUplatiocaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Nalog_Racun_RacunUplatiocaId",
                table: "Nalog",
                column: "RacunUplatiocaId",
                principalTable: "Racun",
                principalColumn: "Id");
        }
    }
}
