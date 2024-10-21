using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProjectPRN231.API.Migrations
{
    /// <inheritdoc />
    public partial class InitDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employeer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CivilId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvatarUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HiredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TerminationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employeer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Attendance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeerId = table.Column<int>(type: "int", nullable: false),
                    CheckedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendance", x => x.Id);
                    table.ForeignKey(
                        name: "Attendance_Employeer_FK",
                        column: x => x.EmployeerId,
                        principalTable: "Employeer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeerId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                    table.ForeignKey(
                        name: "Employeer_Department_PK",
                        column: x => x.EmployeerId,
                        principalTable: "Employeer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EducationLevel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeerId = table.Column<int>(type: "int", nullable: false),
                    SchoolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationLevel", x => x.Id);
                    table.ForeignKey(
                        name: "Employeer_EducationLevel_PK",
                        column: x => x.EmployeerId,
                        principalTable: "Employeer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeerId = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                    table.ForeignKey(
                        name: "Employeer_Location_FK",
                        column: x => x.EmployeerId,
                        principalTable: "Employeer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Salary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeerId = table.Column<int>(type: "int", nullable: false),
                    BaseSalary = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Allowance = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Deduction = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    PayDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salary", x => x.Id);
                    table.ForeignKey(
                        name: "Employeer_Salary_FK",
                        column: x => x.EmployeerId,
                        principalTable: "Employeer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkExperience",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeerId = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Relevant = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkExperience", x => x.Id);
                    table.ForeignKey(
                        name: "Employeer_WorkExperience_FK",
                        column: x => x.EmployeerId,
                        principalTable: "Employeer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AttendanceHours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttendanceId = table.Column<int>(type: "int", nullable: false),
                    CheckInTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOutTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceHours", x => x.Id);
                    table.ForeignKey(
                        name: "Attendance_AttendanceHours_PK",
                        column: x => x.AttendanceId,
                        principalTable: "Attendance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinSalary = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MaxsSalary = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobDetail", x => x.Id);
                    table.ForeignKey(
                        name: "Department_JobDetail_FK",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_EmployeerId",
                table: "Attendance",
                column: "EmployeerId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_Id",
                table: "Attendance",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_IsDeleted",
                table: "Attendance",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceHours_AttendanceId",
                table: "AttendanceHours",
                column: "AttendanceId");

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceHours_Id",
                table: "AttendanceHours",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceHours_IsDeleted",
                table: "AttendanceHours",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Department_EmployeerId",
                table: "Department",
                column: "EmployeerId");

            migrationBuilder.CreateIndex(
                name: "IX_Department_Id",
                table: "Department",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Department_IsDeleted",
                table: "Department",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_EducationLevel_EmployeerId",
                table: "EducationLevel",
                column: "EmployeerId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationLevel_Id",
                table: "EducationLevel",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_EducationLevel_IsDeleted",
                table: "EducationLevel",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Employeer_Id",
                table: "Employeer",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Employeer_IsDeleted",
                table: "Employeer",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_JobDetail_DepartmentId",
                table: "JobDetail",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_JobDetail_Id",
                table: "JobDetail",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_JobDetail_IsDeleted",
                table: "JobDetail",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Location_EmployeerId",
                table: "Location",
                column: "EmployeerId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_Id",
                table: "Location",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Location_IsDeleted",
                table: "Location",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Salary_EmployeerId",
                table: "Salary",
                column: "EmployeerId");

            migrationBuilder.CreateIndex(
                name: "IX_Salary_Id",
                table: "Salary",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Salary_IsDeleted",
                table: "Salary",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperience_EmployeerId",
                table: "WorkExperience",
                column: "EmployeerId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperience_Id",
                table: "WorkExperience",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperience_IsDeleted",
                table: "WorkExperience",
                column: "IsDeleted");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttendanceHours");

            migrationBuilder.DropTable(
                name: "EducationLevel");

            migrationBuilder.DropTable(
                name: "JobDetail");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Salary");

            migrationBuilder.DropTable(
                name: "WorkExperience");

            migrationBuilder.DropTable(
                name: "Attendance");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Employeer");
        }
    }
}
