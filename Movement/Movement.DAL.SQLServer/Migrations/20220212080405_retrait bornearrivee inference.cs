using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movement.DAL.SQLServer.Migrations
{
    public partial class retraitbornearriveeinference : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InferencesTraversePieton_Borne_BorneArriveeId",
                table: "InferencesTraversePieton");

            migrationBuilder.DropIndex(
                name: "IX_InferencesTraversePieton_BorneArriveeId",
                table: "InferencesTraversePieton");

            migrationBuilder.DropColumn(
                name: "BorneArriveeId",
                table: "InferencesTraversePieton");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BorneArriveeId",
                table: "InferencesTraversePieton",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_InferencesTraversePieton_BorneArriveeId",
                table: "InferencesTraversePieton",
                column: "BorneArriveeId");

            migrationBuilder.AddForeignKey(
                name: "FK_InferencesTraversePieton_Borne_BorneArriveeId",
                table: "InferencesTraversePieton",
                column: "BorneArriveeId",
                principalTable: "Borne",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
