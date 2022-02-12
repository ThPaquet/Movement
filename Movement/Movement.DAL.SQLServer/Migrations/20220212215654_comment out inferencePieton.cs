using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movement.DAL.SQLServer.Migrations
{
    public partial class commentoutinferencePieton : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InferencesTraversePieton");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InferencesTraversePieton",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BorneDepartId = table.Column<int>(type: "int", nullable: false),
                    TypeUtilisateurId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DureeEnSecondes = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InferencesTraversePieton", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InferencesTraversePieton_Bornes_BorneDepartId",
                        column: x => x.BorneDepartId,
                        principalTable: "Bornes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InferencesTraversePieton_TypesUtilisateur_TypeUtilisateurId",
                        column: x => x.TypeUtilisateurId,
                        principalTable: "TypesUtilisateur",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InferencesTraversePieton_BorneDepartId",
                table: "InferencesTraversePieton",
                column: "BorneDepartId");

            migrationBuilder.CreateIndex(
                name: "IX_InferencesTraversePieton_TypeUtilisateurId",
                table: "InferencesTraversePieton",
                column: "TypeUtilisateurId");
        }
    }
}
