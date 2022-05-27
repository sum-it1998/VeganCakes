using Microsoft.EntityFrameworkCore.Migrations;

namespace Vegan_Cakes.Migrations
{
    public partial class cakemodalChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsInStock",
                table: "Cakes",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsInStock",
                table: "Cakes");
        }
    }
}
