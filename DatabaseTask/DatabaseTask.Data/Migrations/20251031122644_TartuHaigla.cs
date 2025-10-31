using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class TartuHaigla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    HeadDoctor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentID);
                });

            migrationBuilder.CreateTable(
                name: "MedicalVisits",
                columns: table => new
                {
                    MedicineID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalVisits", x => x.MedicineID);
                });

            migrationBuilder.CreateTable(
                name: "Medicines",
                columns: table => new
                {
                    MedicineID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ingredient = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dose = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicines", x => x.MedicineID);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdentificationNum = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Aadress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedicalVisitMedicineID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientID);
                    table.ForeignKey(
                        name: "FK_Patients_MedicalVisits_MedicalVisitMedicineID",
                        column: x => x.MedicalVisitMedicineID,
                        principalTable: "MedicalVisits",
                        principalColumn: "MedicineID");
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    DoctorID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Profession = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNuber = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedicineID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.DoctorID);
                    table.ForeignKey(
                        name: "FK_Doctors_Medicines_MedicineID",
                        column: x => x.MedicineID,
                        principalTable: "Medicines",
                        principalColumn: "MedicineID");
                });

            migrationBuilder.CreateTable(
                name: "DoctorMedicalVisit",
                columns: table => new
                {
                    DoctorID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VisitIDMedicineID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorMedicalVisit", x => new { x.DoctorID, x.VisitIDMedicineID });
                    table.ForeignKey(
                        name: "FK_DoctorMedicalVisit_Doctors_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Doctors",
                        principalColumn: "DoctorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorMedicalVisit_MedicalVisits_VisitIDMedicineID",
                        column: x => x.VisitIDMedicineID,
                        principalTable: "MedicalVisits",
                        principalColumn: "MedicineID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoctorMedicalVisit_VisitIDMedicineID",
                table: "DoctorMedicalVisit",
                column: "VisitIDMedicineID");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_MedicineID",
                table: "Doctors",
                column: "MedicineID");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_MedicalVisitMedicineID",
                table: "Patients",
                column: "MedicalVisitMedicineID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "DoctorMedicalVisit");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "MedicalVisits");

            migrationBuilder.DropTable(
                name: "Medicines");

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });
        }
    }
}
