using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movement.DAL.SQLServer.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActionsFeu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionsFeu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Intersections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitude = table.Column<float>(type: "real", nullable: false),
                    Latitude = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intersections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypesTransport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypesTransport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypesUtilisateur",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypesUtilisateur", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Borne",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IntersectionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Borne", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Borne_Intersections_IntersectionId",
                        column: x => x.IntersectionId,
                        principalTable: "Intersections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InferencesTraverseVehicules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IntersectionId = table.Column<int>(type: "int", nullable: false),
                    TypeTransportId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Direction = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InferencesTraverseVehicules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InferencesTraverseVehicules_Intersections_IntersectionId",
                        column: x => x.IntersectionId,
                        principalTable: "Intersections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InferencesTraverseVehicules_TypesTransport_TypeTransportId",
                        column: x => x.TypeTransportId,
                        principalTable: "TypesTransport",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TraversesVehicule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IntersectionId = table.Column<int>(type: "int", nullable: false),
                    TypeTransportId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Direction = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TraversesVehicule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TraversesVehicule_Intersections_IntersectionId",
                        column: x => x.IntersectionId,
                        principalTable: "Intersections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TraversesVehicule_TypesTransport_TypeTransportId",
                        column: x => x.TypeTransportId,
                        principalTable: "TypesTransport",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Utilisateurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeUtilisateurId = table.Column<int>(type: "int", nullable: false),
                    Cle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateurs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Utilisateurs_TypesUtilisateur_TypeUtilisateurId",
                        column: x => x.TypeUtilisateurId,
                        principalTable: "TypesUtilisateur",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InferencesTraversePieton",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IntersectionId = table.Column<int>(type: "int", nullable: false),
                    TypeTransportId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BorneDepartId = table.Column<int>(type: "int", nullable: false),
                    BorneArriveeId = table.Column<int>(type: "int", nullable: false),
                    DureeEnSecondes = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InferencesTraversePieton", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InferencesTraversePieton_Borne_BorneArriveeId",
                        column: x => x.BorneArriveeId,
                        principalTable: "Borne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InferencesTraversePieton_Borne_BorneDepartId",
                        column: x => x.BorneDepartId,
                        principalTable: "Borne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InferencesTraversePieton_Intersections_IntersectionId",
                        column: x => x.IntersectionId,
                        principalTable: "Intersections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InferencesTraversePieton_TypesTransport_TypeTransportId",
                        column: x => x.TypeTransportId,
                        principalTable: "TypesTransport",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TraversesPieton",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IntersectionId = table.Column<int>(type: "int", nullable: false),
                    TypeTransportId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BorneDepartId = table.Column<int>(type: "int", nullable: false),
                    BorneArriveeId = table.Column<int>(type: "int", nullable: false),
                    DureeEnSecondes = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TraversesPieton", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TraversesPieton_Borne_BorneArriveeId",
                        column: x => x.BorneArriveeId,
                        principalTable: "Borne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TraversesPieton_Borne_BorneDepartId",
                        column: x => x.BorneDepartId,
                        principalTable: "Borne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TraversesPieton_Intersections_IntersectionId",
                        column: x => x.IntersectionId,
                        principalTable: "Intersections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TraversesPieton_TypesTransport_TypeTransportId",
                        column: x => x.TypeTransportId,
                        principalTable: "TypesTransport",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Evenements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UtilisateurId = table.Column<int>(type: "int", nullable: false),
                    IntersectionId = table.Column<int>(type: "int", nullable: false),
                    ActionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evenements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evenements_ActionsFeu_ActionId",
                        column: x => x.ActionId,
                        principalTable: "ActionsFeu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Evenements_Intersections_IntersectionId",
                        column: x => x.IntersectionId,
                        principalTable: "Intersections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Evenements_Utilisateurs_UtilisateurId",
                        column: x => x.UtilisateurId,
                        principalTable: "Utilisateurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Borne_IntersectionId",
                table: "Borne",
                column: "IntersectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Evenements_ActionId",
                table: "Evenements",
                column: "ActionId");

            migrationBuilder.CreateIndex(
                name: "IX_Evenements_IntersectionId",
                table: "Evenements",
                column: "IntersectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Evenements_UtilisateurId",
                table: "Evenements",
                column: "UtilisateurId");

            migrationBuilder.CreateIndex(
                name: "IX_InferencesTraversePieton_BorneArriveeId",
                table: "InferencesTraversePieton",
                column: "BorneArriveeId");

            migrationBuilder.CreateIndex(
                name: "IX_InferencesTraversePieton_BorneDepartId",
                table: "InferencesTraversePieton",
                column: "BorneDepartId");

            migrationBuilder.CreateIndex(
                name: "IX_InferencesTraversePieton_IntersectionId",
                table: "InferencesTraversePieton",
                column: "IntersectionId");

            migrationBuilder.CreateIndex(
                name: "IX_InferencesTraversePieton_TypeTransportId",
                table: "InferencesTraversePieton",
                column: "TypeTransportId");

            migrationBuilder.CreateIndex(
                name: "IX_InferencesTraverseVehicules_IntersectionId",
                table: "InferencesTraverseVehicules",
                column: "IntersectionId");

            migrationBuilder.CreateIndex(
                name: "IX_InferencesTraverseVehicules_TypeTransportId",
                table: "InferencesTraverseVehicules",
                column: "TypeTransportId");

            migrationBuilder.CreateIndex(
                name: "IX_TraversesPieton_BorneArriveeId",
                table: "TraversesPieton",
                column: "BorneArriveeId");

            migrationBuilder.CreateIndex(
                name: "IX_TraversesPieton_BorneDepartId",
                table: "TraversesPieton",
                column: "BorneDepartId");

            migrationBuilder.CreateIndex(
                name: "IX_TraversesPieton_IntersectionId",
                table: "TraversesPieton",
                column: "IntersectionId");

            migrationBuilder.CreateIndex(
                name: "IX_TraversesPieton_TypeTransportId",
                table: "TraversesPieton",
                column: "TypeTransportId");

            migrationBuilder.CreateIndex(
                name: "IX_TraversesVehicule_IntersectionId",
                table: "TraversesVehicule",
                column: "IntersectionId");

            migrationBuilder.CreateIndex(
                name: "IX_TraversesVehicule_TypeTransportId",
                table: "TraversesVehicule",
                column: "TypeTransportId");

            migrationBuilder.CreateIndex(
                name: "IX_Utilisateurs_TypeUtilisateurId",
                table: "Utilisateurs",
                column: "TypeUtilisateurId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evenements");

            migrationBuilder.DropTable(
                name: "InferencesTraversePieton");

            migrationBuilder.DropTable(
                name: "InferencesTraverseVehicules");

            migrationBuilder.DropTable(
                name: "TraversesPieton");

            migrationBuilder.DropTable(
                name: "TraversesVehicule");

            migrationBuilder.DropTable(
                name: "ActionsFeu");

            migrationBuilder.DropTable(
                name: "Utilisateurs");

            migrationBuilder.DropTable(
                name: "Borne");

            migrationBuilder.DropTable(
                name: "TypesTransport");

            migrationBuilder.DropTable(
                name: "TypesUtilisateur");

            migrationBuilder.DropTable(
                name: "Intersections");
        }
    }
}
