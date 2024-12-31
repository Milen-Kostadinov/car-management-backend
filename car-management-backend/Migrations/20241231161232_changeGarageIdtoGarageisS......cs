using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace car_management_backend.Migrations
{
    /// <inheritdoc />
    public partial class changeGarageIdtoGarageisS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GarageId",
                table: "Cars",
                newName: "GarageIds");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GarageIds",
                table: "Cars",
                newName: "GarageId");
        }
    }
}
