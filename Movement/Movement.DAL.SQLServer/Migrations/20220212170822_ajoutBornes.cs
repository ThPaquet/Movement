using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movement.DAL.SQLServer.Migrations
{
    public partial class ajoutBornes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Borne_Intersections_IntersectionId",
                table: "Borne");

            migrationBuilder.DropForeignKey(
                name: "FK_InferencesTraversePieton_Borne_BorneDepartId",
                table: "InferencesTraversePieton");

            migrationBuilder.DropForeignKey(
                name: "FK_TraversesPieton_Borne_BorneArriveeId",
                table: "TraversesPieton");

            migrationBuilder.DropForeignKey(
                name: "FK_TraversesPieton_Borne_BorneDepartId",
                table: "TraversesPieton");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Borne",
                table: "Borne");

            migrationBuilder.RenameTable(
                name: "Borne",
                newName: "Bornes");

            migrationBuilder.RenameIndex(
                name: "IX_Borne_IntersectionId",
                table: "Bornes",
                newName: "IX_Bornes_IntersectionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bornes",
                table: "Bornes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bornes_Intersections_IntersectionId",
                table: "Bornes",
                column: "IntersectionId",
                principalTable: "Intersections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InferencesTraversePieton_Bornes_BorneDepartId",
                table: "InferencesTraversePieton",
                column: "BorneDepartId",
                principalTable: "Bornes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TraversesPieton_Bornes_BorneArriveeId",
                table: "TraversesPieton",
                column: "BorneArriveeId",
                principalTable: "Bornes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TraversesPieton_Bornes_BorneDepartId",
                table: "TraversesPieton",
                column: "BorneDepartId",
                principalTable: "Bornes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bornes_Intersections_IntersectionId",
                table: "Bornes");

            migrationBuilder.DropForeignKey(
                name: "FK_InferencesTraversePieton_Bornes_BorneDepartId",
                table: "InferencesTraversePieton");

            migrationBuilder.DropForeignKey(
                name: "FK_TraversesPieton_Bornes_BorneArriveeId",
                table: "TraversesPieton");

            migrationBuilder.DropForeignKey(
                name: "FK_TraversesPieton_Bornes_BorneDepartId",
                table: "TraversesPieton");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bornes",
                table: "Bornes");

            migrationBuilder.RenameTable(
                name: "Bornes",
                newName: "Borne");

            migrationBuilder.RenameIndex(
                name: "IX_Bornes_IntersectionId",
                table: "Borne",
                newName: "IX_Borne_IntersectionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Borne",
                table: "Borne",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Borne_Intersections_IntersectionId",
                table: "Borne",
                column: "IntersectionId",
                principalTable: "Intersections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InferencesTraversePieton_Borne_BorneDepartId",
                table: "InferencesTraversePieton",
                column: "BorneDepartId",
                principalTable: "Borne",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TraversesPieton_Borne_BorneArriveeId",
                table: "TraversesPieton",
                column: "BorneArriveeId",
                principalTable: "Borne",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TraversesPieton_Borne_BorneDepartId",
                table: "TraversesPieton",
                column: "BorneDepartId",
                principalTable: "Borne",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
