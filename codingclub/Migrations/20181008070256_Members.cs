using Microsoft.EntityFrameworkCore.Migrations;

namespace CodingClubTest.Migrations
{
    public partial class Members : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Classification",
                table: "Member",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Member",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Member",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "buffID",
                table: "Member",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Classification",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "buffID",
                table: "Member");
        }
    }
}
