using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exercice02HotelEF.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    HotelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.HotelId);
                });

            migrationBuilder.CreateTable(
                name: "Chambres",
                columns: table => new
                {
                    ChambreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Statut = table.Column<int>(type: "int", nullable: false),
                    NombreLits = table.Column<int>(type: "int", nullable: false),
                    Tarif = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chambres", x => x.ChambreId);
                    table.ForeignKey(
                        name: "FK_Chambres_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "HotelId");
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prénom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NuméroTéléphone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                    table.ForeignKey(
                        name: "FK_Clients_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "HotelId");
                });

            migrationBuilder.CreateTable(
                name: "Réservations",
                columns: table => new
                {
                    ReservationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Statut = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Réservations", x => x.ReservationId);
                    table.ForeignKey(
                        name: "FK_Réservations_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Réservations_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "HotelId");
                });

            migrationBuilder.CreateTable(
                name: "ChambreReservation",
                columns: table => new
                {
                    ChambresChambreId = table.Column<int>(type: "int", nullable: false),
                    ReservationsReservationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChambreReservation", x => new { x.ChambresChambreId, x.ReservationsReservationId });
                    table.ForeignKey(
                        name: "FK_ChambreReservation_Chambres_ChambresChambreId",
                        column: x => x.ChambresChambreId,
                        principalTable: "Chambres",
                        principalColumn: "ChambreId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChambreReservation_Réservations_ReservationsReservationId",
                        column: x => x.ReservationsReservationId,
                        principalTable: "Réservations",
                        principalColumn: "ReservationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChambreReservation_ReservationsReservationId",
                table: "ChambreReservation",
                column: "ReservationsReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Chambres_HotelId",
                table: "Chambres",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Chambres_Numero",
                table: "Chambres",
                column: "Numero",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clients_HotelId",
                table: "Clients",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Réservations_ClientId",
                table: "Réservations",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Réservations_HotelId",
                table: "Réservations",
                column: "HotelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChambreReservation");

            migrationBuilder.DropTable(
                name: "Chambres");

            migrationBuilder.DropTable(
                name: "Réservations");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Hotels");
        }
    }
}
