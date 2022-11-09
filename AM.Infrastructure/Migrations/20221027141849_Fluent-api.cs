using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    public partial class Fluentapi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_flights_FlightsFlightId",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_passengers_PassengersId",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_flights_planes_PlaneId",
                table: "flights");

            migrationBuilder.DropPrimaryKey(
                name: "PK_planes",
                table: "planes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger");

            migrationBuilder.RenameTable(
                name: "planes",
                newName: "MyPlanes");

            migrationBuilder.RenameTable(
                name: "FlightPassenger",
                newName: "Reservation");

            migrationBuilder.RenameColumn(
                name: "Discriminator",
                table: "passengers",
                newName: "IsTraveller");

            migrationBuilder.RenameColumn(
                name: "Capacity",
                table: "MyPlanes",
                newName: "PlaneCapacity");

            migrationBuilder.RenameIndex(
                name: "IX_FlightPassenger_PassengersId",
                table: "Reservation",
                newName: "IX_Reservation_PassengersId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyPlanes",
                table: "MyPlanes",
                column: "PlaneId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservation",
                table: "Reservation",
                columns: new[] { "FlightsFlightId", "PassengersId" });

            migrationBuilder.AddForeignKey(
                name: "FK_flights_MyPlanes_PlaneId",
                table: "flights",
                column: "PlaneId",
                principalTable: "MyPlanes",
                principalColumn: "PlaneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_flights_FlightsFlightId",
                table: "Reservation",
                column: "FlightsFlightId",
                principalTable: "flights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_passengers_PassengersId",
                table: "Reservation",
                column: "PassengersId",
                principalTable: "passengers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_flights_MyPlanes_PlaneId",
                table: "flights");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_flights_FlightsFlightId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_passengers_PassengersId",
                table: "Reservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservation",
                table: "Reservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyPlanes",
                table: "MyPlanes");

            migrationBuilder.RenameTable(
                name: "Reservation",
                newName: "FlightPassenger");

            migrationBuilder.RenameTable(
                name: "MyPlanes",
                newName: "planes");

            migrationBuilder.RenameColumn(
                name: "IsTraveller",
                table: "passengers",
                newName: "Discriminator");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_PassengersId",
                table: "FlightPassenger",
                newName: "IX_FlightPassenger_PassengersId");

            migrationBuilder.RenameColumn(
                name: "PlaneCapacity",
                table: "planes",
                newName: "Capacity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger",
                columns: new[] { "FlightsFlightId", "PassengersId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_planes",
                table: "planes",
                column: "PlaneId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_flights_FlightsFlightId",
                table: "FlightPassenger",
                column: "FlightsFlightId",
                principalTable: "flights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_passengers_PassengersId",
                table: "FlightPassenger",
                column: "PassengersId",
                principalTable: "passengers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_flights_planes_PlaneId",
                table: "flights",
                column: "PlaneId",
                principalTable: "planes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
