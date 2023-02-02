using Microsoft.EntityFrameworkCore.Migrations;

namespace TraversalCore.Data.Migrations
{
    public partial class add_mig_create_Entity_ContactUses_MessageStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "MessageStatus",
                table: "ContactUses",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MessageStatus",
                table: "ContactUses");
        }
    }
}
