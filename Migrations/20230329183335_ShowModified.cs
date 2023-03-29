using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventManagment.Migrations
{
    /// <inheritdoc />
    public partial class ShowModified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Seats_ShowId",
                table: "Seats",
                column: "ShowId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Shows_ShowId",
                table: "Seats",
                column: "ShowId",
                principalTable: "Shows",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Shows_ShowId",
                table: "Seats");

            migrationBuilder.DropIndex(
                name: "IX_Seats_ShowId",
                table: "Seats");
        }
    }
}
