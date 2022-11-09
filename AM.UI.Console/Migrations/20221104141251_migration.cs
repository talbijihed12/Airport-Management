using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.UI.Console.Migrations
{
    public partial class migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Flights_flightsFlightId",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Passengers_passengersId",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Planes_PlaneId",
                table: "Flights");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Planes",
                table: "Planes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger");

            migrationBuilder.RenameTable(
                name: "Planes",
                newName: "MyPlane");

            migrationBuilder.RenameTable(
                name: "FlightPassenger",
                newName: "reservation");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Passengers",
                newName: "PassLastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Passengers",
                newName: "PassFirstName");

            migrationBuilder.RenameColumn(
                name: "Discriminator",
                table: "Passengers",
                newName: "IsTraveller");

            migrationBuilder.RenameColumn(
                name: "Capacity",
                table: "MyPlane",
                newName: "PlaneCapacity");

            migrationBuilder.RenameIndex(
                name: "IX_FlightPassenger_passengersId",
                table: "reservation",
                newName: "IX_reservation_passengersId");

            migrationBuilder.AlterColumn<string>(
                name: "PassFirstName",
                table: "Passengers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyPlane",
                table: "MyPlane",
                column: "PlaneId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_reservation",
                table: "reservation",
                columns: new[] { "flightsFlightId", "passengersId" });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    NumTicket = table.Column<int>(type: "int", nullable: false),
                    PassengerFk = table.Column<int>(type: "int", nullable: false),
                    FlightFk = table.Column<int>(type: "int", nullable: false),
                    Prix = table.Column<float>(type: "real", nullable: false),
                    Siege = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VIP = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => new { x.PassengerFk, x.FlightFk, x.NumTicket });
                    table.ForeignKey(
                        name: "FK_Tickets_Flights_FlightFk",
                        column: x => x.FlightFk,
                        principalTable: "Flights",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Passengers_PassengerFk",
                        column: x => x.PassengerFk,
                        principalTable: "Passengers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_FlightFk",
                table: "Tickets",
                column: "FlightFk");

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_MyPlane_PlaneId",
                table: "Flights",
                column: "PlaneId",
                principalTable: "MyPlane",
                principalColumn: "PlaneId");

            migrationBuilder.AddForeignKey(
                name: "FK_reservation_Flights_flightsFlightId",
                table: "reservation",
                column: "flightsFlightId",
                principalTable: "Flights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_reservation_Passengers_passengersId",
                table: "reservation",
                column: "passengersId",
                principalTable: "Passengers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flights_MyPlane_PlaneId",
                table: "Flights");

            migrationBuilder.DropForeignKey(
                name: "FK_reservation_Flights_flightsFlightId",
                table: "reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_reservation_Passengers_passengersId",
                table: "reservation");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_reservation",
                table: "reservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyPlane",
                table: "MyPlane");

            migrationBuilder.RenameTable(
                name: "reservation",
                newName: "FlightPassenger");

            migrationBuilder.RenameTable(
                name: "MyPlane",
                newName: "Planes");

            migrationBuilder.RenameColumn(
                name: "PassLastName",
                table: "Passengers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "PassFirstName",
                table: "Passengers",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "IsTraveller",
                table: "Passengers",
                newName: "Discriminator");

            migrationBuilder.RenameIndex(
                name: "IX_reservation_passengersId",
                table: "FlightPassenger",
                newName: "IX_FlightPassenger_passengersId");

            migrationBuilder.RenameColumn(
                name: "PlaneCapacity",
                table: "Planes",
                newName: "Capacity");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Passengers",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger",
                columns: new[] { "flightsFlightId", "passengersId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Planes",
                table: "Planes",
                column: "PlaneId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_Flights_flightsFlightId",
                table: "FlightPassenger",
                column: "flightsFlightId",
                principalTable: "Flights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_Passengers_passengersId",
                table: "FlightPassenger",
                column: "passengersId",
                principalTable: "Passengers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Planes_PlaneId",
                table: "Flights",
                column: "PlaneId",
                principalTable: "Planes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
