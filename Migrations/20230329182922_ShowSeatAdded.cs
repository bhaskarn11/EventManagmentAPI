using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventManagment.Migrations
{
    /// <inheritdoc />
    public partial class ShowSeatAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventVenue_Venue_VenueId",
                table: "EventVenue");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Venue_VenueId",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Venue",
                table: "Venue");

            migrationBuilder.RenameTable(
                name: "Venue",
                newName: "Venues");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Venues",
                table: "Venues",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Seats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Row = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    VenueId = table.Column<int>(type: "int", nullable: false),
                    ShowId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seats", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_EventVenue_Venues_VenueId",
                table: "EventVenue",
                column: "VenueId",
                principalTable: "Venues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Venues_VenueId",
                table: "Reviews",
                column: "VenueId",
                principalTable: "Venues",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventVenue_Venues_VenueId",
                table: "EventVenue");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Venues_VenueId",
                table: "Reviews");

            migrationBuilder.DropTable(
                name: "Seats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Venues",
                table: "Venues");

            migrationBuilder.RenameTable(
                name: "Venues",
                newName: "Venue");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Venue",
                table: "Venue",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EventVenue_Venue_VenueId",
                table: "EventVenue",
                column: "VenueId",
                principalTable: "Venue",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Venue_VenueId",
                table: "Reviews",
                column: "VenueId",
                principalTable: "Venue",
                principalColumn: "Id");
        }
    }
}
