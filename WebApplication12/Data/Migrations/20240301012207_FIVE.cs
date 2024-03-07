using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication12.Data.Migrations
{
    /// <inheritdoc />
    public partial class FIVE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "DepID",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepID",
                table: "Employees",
                column: "DepID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepID",
                table: "Employees",
                column: "DepID",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepID",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DepID",
                table: "Employees");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
