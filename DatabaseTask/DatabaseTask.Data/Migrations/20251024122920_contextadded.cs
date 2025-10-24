using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class contextadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Group_Employee_EmployeeId",
                table: "Group");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Group",
                table: "Group");

            migrationBuilder.RenameTable(
                name: "Group",
                newName: "Groups");

            migrationBuilder.RenameIndex(
                name: "IX_Group_EmployeeId",
                table: "Groups",
                newName: "IX_Groups_EmployeeId");

            migrationBuilder.AddColumn<string>(
                name: "JobTitleName",
                table: "Employee",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AbsenseId",
                table: "Groups",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ChildGroupHistoryStartDate",
                table: "Groups",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "QueueRegDate",
                table: "Groups",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Groups",
                table: "Groups",
                column: "GroupId");

            migrationBuilder.CreateTable(
                name: "Absenses",
                columns: table => new
                {
                    AbsenseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Absenses", x => x.AbsenseId);
                });

            migrationBuilder.CreateTable(
                name: "ChildGroupHistories",
                columns: table => new
                {
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChildGroupHistories", x => x.StartDate);
                });

            migrationBuilder.CreateTable(
                name: "JobTitles",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitles", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Morning = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MorningSnack = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lunch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DinnerSnack = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dinner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Portions = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Morning);
                });

            migrationBuilder.CreateTable(
                name: "Queues",
                columns: table => new
                {
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Queues", x => x.RegDate);
                });

            migrationBuilder.CreateTable(
                name: "Children",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AbsenseId = table.Column<int>(type: "int", nullable: true),
                    QueueRegDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Children", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Children_Absenses_AbsenseId",
                        column: x => x.AbsenseId,
                        principalTable: "Absenses",
                        principalColumn: "AbsenseId");
                    table.ForeignKey(
                        name: "FK_Children_Queues_QueueRegDate",
                        column: x => x.QueueRegDate,
                        principalTable: "Queues",
                        principalColumn: "RegDate");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_JobTitleName",
                table: "Employee",
                column: "JobTitleName");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_AbsenseId",
                table: "Groups",
                column: "AbsenseId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_ChildGroupHistoryStartDate",
                table: "Groups",
                column: "ChildGroupHistoryStartDate");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_QueueRegDate",
                table: "Groups",
                column: "QueueRegDate");

            migrationBuilder.CreateIndex(
                name: "IX_Children_AbsenseId",
                table: "Children",
                column: "AbsenseId");

            migrationBuilder.CreateIndex(
                name: "IX_Children_QueueRegDate",
                table: "Children",
                column: "QueueRegDate");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_JobTitles_JobTitleName",
                table: "Employee",
                column: "JobTitleName",
                principalTable: "JobTitles",
                principalColumn: "Name");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Absenses_AbsenseId",
                table: "Groups",
                column: "AbsenseId",
                principalTable: "Absenses",
                principalColumn: "AbsenseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_ChildGroupHistories_ChildGroupHistoryStartDate",
                table: "Groups",
                column: "ChildGroupHistoryStartDate",
                principalTable: "ChildGroupHistories",
                principalColumn: "StartDate");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Employee_EmployeeId",
                table: "Groups",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Queues_QueueRegDate",
                table: "Groups",
                column: "QueueRegDate",
                principalTable: "Queues",
                principalColumn: "RegDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_JobTitles_JobTitleName",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Absenses_AbsenseId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_ChildGroupHistories_ChildGroupHistoryStartDate",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Employee_EmployeeId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Queues_QueueRegDate",
                table: "Groups");

            migrationBuilder.DropTable(
                name: "ChildGroupHistories");

            migrationBuilder.DropTable(
                name: "Children");

            migrationBuilder.DropTable(
                name: "JobTitles");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Absenses");

            migrationBuilder.DropTable(
                name: "Queues");

            migrationBuilder.DropIndex(
                name: "IX_Employee_JobTitleName",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Groups",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Groups_AbsenseId",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Groups_ChildGroupHistoryStartDate",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Groups_QueueRegDate",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "JobTitleName",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "AbsenseId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "ChildGroupHistoryStartDate",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "QueueRegDate",
                table: "Groups");

            migrationBuilder.RenameTable(
                name: "Groups",
                newName: "Group");

            migrationBuilder.RenameIndex(
                name: "IX_Groups_EmployeeId",
                table: "Group",
                newName: "IX_Group_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Group",
                table: "Group",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Group_Employee_EmployeeId",
                table: "Group",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id");
        }
    }
}
