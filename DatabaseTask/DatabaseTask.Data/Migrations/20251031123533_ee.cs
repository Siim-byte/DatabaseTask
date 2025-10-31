using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class ee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "HeadDoctor",
                table: "Departments");

            migrationBuilder.AddColumn<Guid>(
                name: "DepartmentID",
                table: "Doctors",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_DepartmentID",
                table: "Doctors",
                column: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Departments_DepartmentID",
                table: "Doctors",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "DepartmentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Departments_DepartmentID",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_DepartmentID",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "DepartmentID",
                table: "Doctors");

            migrationBuilder.AddColumn<Guid>(
                name: "DoctorID",
                table: "Departments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HeadDoctor",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
    }
}
