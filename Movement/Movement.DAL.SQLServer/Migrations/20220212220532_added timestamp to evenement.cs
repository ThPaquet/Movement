using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movement.DAL.SQLServer.Migrations
{
    public partial class addedtimestamptoevenement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Evenements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Evenements");
        }
    }
}
