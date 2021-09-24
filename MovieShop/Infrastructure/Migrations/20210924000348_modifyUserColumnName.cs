using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class modifyUserColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HahsedPassword",
                table: "User",
                newName: "HashedPassword");

            migrationBuilder.RenameColumn(
                name: "DataOfBirth",
                table: "User",
                newName: "DateOfBirth");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HashedPassword",
                table: "User",
                newName: "HahsedPassword");

            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "User",
                newName: "DataOfBirth");
        }
    }
}
