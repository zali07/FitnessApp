using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessApiClient.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TicketId",
                table: "Entries",
                newName: "TicketTypeId");

            migrationBuilder.RenameColumn(
                name: "TicketId",
                table: "ClientTickets",
                newName: "TicketTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TicketTypeId",
                table: "Entries",
                newName: "TicketId");

            migrationBuilder.RenameColumn(
                name: "TicketTypeId",
                table: "ClientTickets",
                newName: "TicketId");
        }
    }
}
