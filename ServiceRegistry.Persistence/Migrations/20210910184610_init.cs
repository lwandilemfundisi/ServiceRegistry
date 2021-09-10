using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceRegistry.Persistence.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vendor",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VendorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VendorApplication",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VendorApplicationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorApplicationUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorApplication", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VendorApplication_Vendor_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VendorApplicationEndpoint",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VendorApplicationEndpointName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorApplicationEndpointDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorApplicationEndpointRoute = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    VendorApplicationId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorApplicationEndpoint", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VendorApplicationEndpoint_VendorApplication_VendorApplicationId",
                        column: x => x.VendorApplicationId,
                        principalTable: "VendorApplication",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VendorApplicationEndpointParameter",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ParameterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParameterDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParameterPosition = table.Column<int>(type: "int", nullable: true),
                    VendorApplicationEndpointId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorApplicationEndpointParameter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VendorApplicationEndpointParameter_VendorApplicationEndpoint_VendorApplicationEndpointId",
                        column: x => x.VendorApplicationEndpointId,
                        principalTable: "VendorApplicationEndpoint",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VendorApplication_VendorId",
                table: "VendorApplication",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_VendorApplicationEndpoint_VendorApplicationId",
                table: "VendorApplicationEndpoint",
                column: "VendorApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_VendorApplicationEndpointParameter_VendorApplicationEndpointId",
                table: "VendorApplicationEndpointParameter",
                column: "VendorApplicationEndpointId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VendorApplicationEndpointParameter");

            migrationBuilder.DropTable(
                name: "VendorApplicationEndpoint");

            migrationBuilder.DropTable(
                name: "VendorApplication");

            migrationBuilder.DropTable(
                name: "Vendor");
        }
    }
}
