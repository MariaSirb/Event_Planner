using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Event_Planner.Migrations
{
    public partial class Date : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataInceput",
                table: "Locatie",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataSfarsit",
                table: "Locatie",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataInceput",
                table: "Locatie");

            migrationBuilder.DropColumn(
                name: "DataSfarsit",
                table: "Locatie");
        }
    }
}
