using Microsoft.EntityFrameworkCore.Migrations;

namespace SpryStore.DataAccessLayer.Migrations
{
    public partial class emp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmployeeDescription",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeTitle",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeDescription",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeeTitle",
                table: "Employees");
        }
    }
}
