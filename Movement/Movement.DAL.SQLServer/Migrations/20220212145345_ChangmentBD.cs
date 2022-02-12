using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movement.DAL.SQLServer.Migrations
{
    public partial class ChangmentBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropForeignKey(
                name: "FK_InferencesTraversePieton_Intersections_IntersectionId",
                table: "InferencesTraversePieton");

            migrationBuilder.DropForeignKey(
                name: "FK_InferencesTraversePieton_TypesTransport_TypeTransportId",
                table: "InferencesTraversePieton");

            migrationBuilder.DropForeignKey(
                name: "FK_TraversesPieton_Intersections_IntersectionId",
                table: "TraversesPieton");

            migrationBuilder.DropForeignKey(
                name: "FK_TraversesPieton_TypesTransport_TypeTransportId",
                table: "TraversesPieton");

            migrationBuilder.DropIndex(
                name: "IX_TraversesPieton_IntersectionId",
                table: "TraversesPieton");

            migrationBuilder.DropIndex(
                name: "IX_InferencesTraversePieton_IntersectionId",
                table: "InferencesTraversePieton");

            migrationBuilder.DropColumn(
                name: "IntersectionId",
                table: "TraversesPieton");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Intersections");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Intersections");

            migrationBuilder.DropColumn(
                name: "IntersectionId",
                table: "InferencesTraversePieton");

            migrationBuilder.RenameColumn(
                name: "TypeTransportId",
                table: "TraversesPieton",
                newName: "TypeUtilisateurId");

            migrationBuilder.RenameIndex(
                name: "IX_TraversesPieton_TypeTransportId",
                table: "TraversesPieton",
                newName: "IX_TraversesPieton_TypeUtilisateurId");

            migrationBuilder.RenameColumn(
                name: "TypeTransportId",
                table: "InferencesTraversePieton",
                newName: "TypeUtilisateurId");

            migrationBuilder.RenameIndex(
                name: "IX_InferencesTraversePieton_TypeTransportId",
                table: "InferencesTraversePieton",
                newName: "IX_InferencesTraversePieton_TypeUtilisateurId");

            migrationBuilder.AddColumn<float>(
                name: "Latitude",
                table: "Borne",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Longitude",
                table: "Borne",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddForeignKey(
                name: "FK_InferencesTraversePieton_TypesUtilisateur_TypeUtilisateurId",
                table: "InferencesTraversePieton",
                column: "TypeUtilisateurId",
                principalTable: "TypesUtilisateur",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TraversesPieton_TypesUtilisateur_TypeUtilisateurId",
                table: "TraversesPieton",
                column: "TypeUtilisateurId",
                principalTable: "TypesUtilisateur",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InferencesTraversePieton_TypesUtilisateur_TypeUtilisateurId",
                table: "InferencesTraversePieton");

            migrationBuilder.DropForeignKey(
                name: "FK_TraversesPieton_TypesUtilisateur_TypeUtilisateurId",
                table: "TraversesPieton");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Borne");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Borne");

            migrationBuilder.RenameColumn(
                name: "TypeUtilisateurId",
                table: "TraversesPieton",
                newName: "TypeTransportId");

            migrationBuilder.RenameIndex(
                name: "IX_TraversesPieton_TypeUtilisateurId",
                table: "TraversesPieton",
                newName: "IX_TraversesPieton_TypeTransportId");

            migrationBuilder.RenameColumn(
                name: "TypeUtilisateurId",
                table: "InferencesTraversePieton",
                newName: "TypeTransportId");

            migrationBuilder.RenameIndex(
                name: "IX_InferencesTraversePieton_TypeUtilisateurId",
                table: "InferencesTraversePieton",
                newName: "IX_InferencesTraversePieton_TypeTransportId");

            migrationBuilder.AddColumn<int>(
                name: "IntersectionId",
                table: "TraversesPieton",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "Latitude",
                table: "Intersections",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Longitude",
                table: "Intersections",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "BorneArriveeId",
                table: "InferencesTraversePieton",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IntersectionId",
                table: "InferencesTraversePieton",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TraversesPieton_IntersectionId",
                table: "TraversesPieton",
                column: "IntersectionId");

            migrationBuilder.CreateIndex(
                name: "IX_InferencesTraversePieton_BorneArriveeId",
                table: "InferencesTraversePieton",
                column: "BorneArriveeId");

            migrationBuilder.CreateIndex(
                name: "IX_InferencesTraversePieton_IntersectionId",
                table: "InferencesTraversePieton",
                column: "IntersectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_InferencesTraversePieton_Borne_BorneArriveeId",
                table: "InferencesTraversePieton",
                column: "BorneArriveeId",
                principalTable: "Borne",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InferencesTraversePieton_Intersections_IntersectionId",
                table: "InferencesTraversePieton",
                column: "IntersectionId",
                principalTable: "Intersections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InferencesTraversePieton_TypesTransport_TypeTransportId",
                table: "InferencesTraversePieton",
                column: "TypeTransportId",
                principalTable: "TypesTransport",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TraversesPieton_Intersections_IntersectionId",
                table: "TraversesPieton",
                column: "IntersectionId",
                principalTable: "Intersections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TraversesPieton_TypesTransport_TypeTransportId",
                table: "TraversesPieton",
                column: "TypeTransportId",
                principalTable: "TypesTransport",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
