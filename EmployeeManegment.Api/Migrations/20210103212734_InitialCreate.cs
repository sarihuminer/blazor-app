using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManegment.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "IT" },
                    { 2, "HR" },
                    { 3, "Payroll" },
                    { 4, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBirth", "DepartmentId", "Email", "FirstName", "Gender", "LastName", "PhotoPath" },
                values: new object[,]
                {
                    { 1, new DateTime(1900, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "dshajkashk@nsg.co.il", "jon", 0, "yuooo", "images/1540445753.png" },
                    { 2, new DateTime(1980, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "kljj@nsg.co.il", "bosh", 0, "yuooo", "images/computers.png" },
                    { 3, new DateTime(1999, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "kk@nsg.co.il", "kobi", 0, "sharon", "images/man-sitting-laptop-publicdomain.jpg" },
                    { 4, new DateTime(1888, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "rk@nsg.co.il", "robert", 0, "kazarov", "images/man-surfing-on-internet-publicdomain.jpg" },
                    { 5, new DateTime(2000, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "BB@nsg.co.il", "BOB", 0, "yuooo", "images/programmer.png" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
