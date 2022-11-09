using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    public partial class fluentapi2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "EmployementDate",
                table: "passengers",
                type: "DateTime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "passengers",
                type: "DateTime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ManufactureDate",
                table: "MyPlanes",
                type: "DateTime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FlightDate",
                table: "flights",
                type: "DateTime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EffectiveArrival",
                table: "flights",
                type: "DateTime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "EmployementDate",
                table: "passengers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "passengers",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ManufactureDate",
                table: "MyPlanes",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FlightDate",
                table: "flights",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EffectiveArrival",
                table: "flights",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime2");
        }
    }
}
