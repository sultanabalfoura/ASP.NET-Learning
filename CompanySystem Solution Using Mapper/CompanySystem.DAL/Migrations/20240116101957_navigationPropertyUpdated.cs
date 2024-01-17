using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanySystem.DAL.Migrations
{
    public partial class navigationPropertyUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Departments_DepartmentId",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Employee",
                newName: "departmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_DepartmentId",
                table: "Employee",
                newName: "IX_Employee_departmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Departments_departmentId",
                table: "Employee",
                column: "departmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Departments_departmentId",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "departmentId",
                table: "Employee",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_departmentId",
                table: "Employee",
                newName: "IX_Employee_DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Departments_DepartmentId",
                table: "Employee",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
