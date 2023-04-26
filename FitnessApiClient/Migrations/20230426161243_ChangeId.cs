using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessApiClient.Migrations
{
    /// <inheritdoc />
    public partial class ChangeId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketTypes",
                table: "TicketTypes");

            migrationBuilder.RenameColumn(
                name: "ArenaId",
                table: "TicketTypes",
                newName: "ArenaId");

            migrationBuilder.RenameColumn(
                name: "ArenaId",
                table: "Entries",
                newName: "TicketTypeId");

            migrationBuilder.RenameColumn(
                name: "ArenaId",
                table: "ClientTickets",
                newName: "TicketTypeId");

            migrationBuilder.AlterColumn<int>(
                name: "ArenaId",
                table: "TicketTypes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "TicketTypeId",
                table: "TicketTypes",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ArenaId",
                table: "Entries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ArenaId",
                table: "ClientTickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketTypes",
                table: "TicketTypes",
                column: "TicketTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketTypes",
                table: "TicketTypes");

            migrationBuilder.DropColumn(
                name: "TicketTypeId",
                table: "TicketTypes");

            migrationBuilder.DropColumn(
                name: "ArenaId",
                table: "Entries");

            migrationBuilder.DropColumn(
                name: "ArenaId",
                table: "ClientTickets");

            migrationBuilder.RenameColumn(
                name: "ArenaId",
                table: "TicketTypes",
                newName: "ArenaId");

            migrationBuilder.RenameColumn(
                name: "TicketTypeId",
                table: "Entries",
                newName: "ArenaId");

            migrationBuilder.RenameColumn(
                name: "TicketTypeId",
                table: "ClientTickets",
                newName: "ArenaId");

            migrationBuilder.AlterColumn<int>(
                name: "ArenaId",
                table: "TicketTypes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketTypes",
                table: "TicketTypes",
                column: "ArenaId");
        }
    }
}
