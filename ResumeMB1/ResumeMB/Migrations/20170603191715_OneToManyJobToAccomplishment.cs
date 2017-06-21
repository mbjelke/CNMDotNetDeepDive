using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ResumeMB.Migrations
{
    public partial class OneToManyJobToAccomplishment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Experience",
                newName: "JobID");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Accomplishments",
                newName: "Accomp");

            migrationBuilder.RenameColumn(
                name: "ExpInt",
                table: "Accomplishments",
                newName: "JobID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Accomplishments",
                newName: "AccomplishmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Accomplishments_JobID",
                table: "Accomplishments",
                column: "JobID");

            migrationBuilder.AddForeignKey(
                name: "FK_Accomplishments_Experience_JobID",
                table: "Accomplishments",
                column: "JobID",
                principalTable: "Experience",
                principalColumn: "JobID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accomplishments_Experience_JobID",
                table: "Accomplishments");

            migrationBuilder.DropIndex(
                name: "IX_Accomplishments_JobID",
                table: "Accomplishments");

            migrationBuilder.RenameColumn(
                name: "JobID",
                table: "Experience",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "JobID",
                table: "Accomplishments",
                newName: "ExpInt");

            migrationBuilder.RenameColumn(
                name: "Accomp",
                table: "Accomplishments",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "AccomplishmentId",
                table: "Accomplishments",
                newName: "Id");
        }
    }
}
