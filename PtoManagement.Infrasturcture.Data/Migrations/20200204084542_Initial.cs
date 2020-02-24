using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PtoManagement.Infrasturcture.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Pto");

            migrationBuilder.EnsureSchema(
                name: "Lookup");

            migrationBuilder.CreateTable(
                name: "PtoTypes",
                columns: table => new
                {
                    PtoTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PtoTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PtoTypes", x => x.PtoTypeId);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTypes",
                schema: "Lookup",
                columns: table => new
                {
                    EmployeeTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeTypeName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTypes", x => x.EmployeeTypeId);
                });

            migrationBuilder.CreateTable(
                name: "PtoStatus",
                schema: "Lookup",
                columns: table => new
                {
                    PtoStatusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PtoStatusName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PtoStatus", x => x.PtoStatusId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                schema: "Pto",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamId = table.Column<int>(nullable: false),
                    EmployeeTypeId = table.Column<int>(nullable: false),
                    TotalAccrued = table.Column<int>(nullable: false),
                    TotalUsed = table.Column<int>(nullable: false),
                    EmployeeName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Ptos",
                schema: "Pto",
                columns: table => new
                {
                    PtoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(nullable: false),
                    PtoTypeId = table.Column<int>(nullable: false),
                    PtoStatusId = table.Column<int>(nullable: false),
                    DateFiled = table.Column<DateTime>(nullable: false),
                    LeaveStartDate = table.Column<DateTime>(nullable: false),
                    LeaveEndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ptos", x => x.PtoId);
                    table.ForeignKey(
                        name: "FK_Ptos_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalSchema: "Pto",
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ptos_PtoStatus_PtoStatusId",
                        column: x => x.PtoStatusId,
                        principalSchema: "Lookup",
                        principalTable: "PtoStatus",
                        principalColumn: "PtoStatusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ptos_PtoTypes_PtoTypeId",
                        column: x => x.PtoTypeId,
                        principalTable: "PtoTypes",
                        principalColumn: "PtoTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "EmployeeTypes",
                columns: new[] { "EmployeeTypeId", "EmployeeTypeName" },
                values: new object[,]
                {
                    { 1, "User" },
                    { 2, "Manager" },
                    { 3, "Admin" }
                });

            migrationBuilder.InsertData(
                schema: "Lookup",
                table: "PtoStatus",
                columns: new[] { "PtoStatusId", "PtoStatusName" },
                values: new object[,]
                {
                    { 1, "For Approval" },
                    { 2, "Approved" },
                    { 3, "Rejected" },
                    { 4, "Cancelled" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ptos_EmployeeId",
                schema: "Pto",
                table: "Ptos",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ptos_PtoStatusId",
                schema: "Pto",
                table: "Ptos",
                column: "PtoStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Ptos_PtoTypeId",
                schema: "Pto",
                table: "Ptos",
                column: "PtoTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeTypes",
                schema: "Lookup");

            migrationBuilder.DropTable(
                name: "Ptos",
                schema: "Pto");

            migrationBuilder.DropTable(
                name: "Employees",
                schema: "Pto");

            migrationBuilder.DropTable(
                name: "PtoStatus",
                schema: "Lookup");

            migrationBuilder.DropTable(
                name: "PtoTypes");
        }
    }
}
