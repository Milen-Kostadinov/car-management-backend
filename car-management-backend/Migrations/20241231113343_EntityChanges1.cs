using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace car_management_backend.Migrations
{
    /// <inheritdoc />
    public partial class EntityChanges1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Garages_Cars_CarId",
                table: "Garages");

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

            migrationBuilder.DropIndex(
                name: "IX_Garages_CarId",
                table: "Garages");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "Garages");

            migrationBuilder.DropColumn(
                name: "ScheduleDate",
                table: "Cars");

            migrationBuilder.AddColumn<string>(
                name: "Make",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ProductionYear",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Make",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "ProductionYear",
                table: "Cars");

            migrationBuilder.AddColumn<long>(
                name: "CarId",
                table: "Garages",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ScheduleDate",
                table: "Cars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Maintanances_CarId",
                table: "Maintanances",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Maintanances_GarageId",
                table: "Maintanances",
                column: "GarageId");

            migrationBuilder.CreateIndex(
                name: "IX_Garages_CarId",
                table: "Garages",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Garages_Cars_CarId",
                table: "Garages",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarId");

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
    }
}
