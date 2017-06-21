using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ResumeMB.Migrations
{
    public partial class revampaccomp1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccomplishmentURL",
                table: "Accomplishments");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Accomplishments");

            migrationBuilder.RenameColumn(
                name: "AccYear",
                table: "Accomplishments",
                newName: "ExpInt");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExpInt",
                table: "Accomplishments",
                newName: "AccYear");

            migrationBuilder.AddColumn<string>(
                name: "AccomplishmentURL",
                table: "Accomplishments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Accomplishments",
                nullable: false,
                defaultValue: "");
        }
    }
}
