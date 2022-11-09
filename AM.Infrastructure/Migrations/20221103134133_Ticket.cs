using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    public partial class Ticket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    PassengerFK = table.Column<int>(type: "int", nullable: false),
                    FlightFK = table.Column<int>(type: "int", nullable: false),
                    NumTicket = table.Column<int>(type: "int", nullable: false),
                    Prix = table.Column<float>(type: "real", nullable: false),
                    siege = table.Column<int>(type: "int", nullable: false),
                    VIP = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => new { x.NumTicket, x.PassengerFK, x.FlightFK });
                    table.ForeignKey(
                        name: "FK_Tickets_flights_FlightFK",
                        column: x => x.FlightFK,
                        principalTable: "flights",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_passengers_PassengerFK",
                        column: x => x.PassengerFK,
                        principalTable: "passengers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_FlightFK",
                table: "Tickets",
                column: "FlightFK");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_PassengerFK",
                table: "Tickets",
                column: "PassengerFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");
        }
    }
}
