using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class m : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "DoctorID",
                table: "Departments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_DoctorID",
                table: "Departments",
                column: "DoctorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Doctors_DoctorID",
                table: "Departments",
                column: "DoctorID",
                principalTable: "Doctors",
                principalColumn: "DoctorID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Doctors_DoctorID",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_DoctorID",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "DoctorID",
                table: "Departments");
        }
    }
}
