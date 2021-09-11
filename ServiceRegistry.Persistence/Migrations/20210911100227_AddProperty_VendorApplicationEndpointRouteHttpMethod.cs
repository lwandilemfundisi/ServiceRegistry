using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceRegistry.Persistence.Migrations
{
    public partial class AddProperty_VendorApplicationEndpointRouteHttpMethod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VendorApplicationEndpointRouteHttpMethod",
                table: "VendorApplicationEndpoint",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VendorApplicationEndpointRouteHttpMethod",
                table: "VendorApplicationEndpoint");
        }
    }
}
