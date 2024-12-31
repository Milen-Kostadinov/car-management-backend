using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace car_management_backend.Migrations
{
    /// <inheritdoc />
    public partial class EntityChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GarageId",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.CreateIndex(
                name: "IX_Maintanances_CarId",
                table: "Maintanances",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Maintanances_GarageId",
                table: "Maintanances",
                column: "GarageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Maintanances_Cars_CarId",
                table: "Maintanances",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Maintanances_Garages_GarageId",
                table: "Maintanances",
                column: "GarageId",
                principalTable: "Garages",
                principalColumn: "GarageId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Maintanances_Cars_CarId",
                table: "Maintanances");

            migrationBuilder.DropForeignKey(
                name: "FK_Maintanances_Garages_GarageId",
                table: "Maintanances");

            migrationBuilder.DropIndex(
                name: "IX_Maintanances_CarId",
                table: "Maintanances");

            migrationBuilder.DropIndex(
                name: "IX_Maintanances_GarageId",
                table: "Maintanances");

            migrationBuilder.DropColumn(
                name: "GarageId",
                table: "Cars");
        }
    }
}
