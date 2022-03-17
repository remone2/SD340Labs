using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SD340Labs.Migrations
{
    public partial class AddInverseProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrentClientId",
                table: "Room",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PreviousClientId",
                table: "Room",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Room_CurrentClientId",
                table: "Room",
                column: "CurrentClientId",
                unique: true,
                filter: "[CurrentClientId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Room_PreviousClientId",
                table: "Room",
                column: "PreviousClientId",
                unique: true,
                filter: "[PreviousClientId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Room_Client_CurrentClientId",
                table: "Room",
                column: "CurrentClientId",
                principalTable: "Client",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Room_Client_PreviousClientId",
                table: "Room",
                column: "PreviousClientId",
                principalTable: "Client",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Room_Client_CurrentClientId",
                table: "Room");

            migrationBuilder.DropForeignKey(
                name: "FK_Room_Client_PreviousClientId",
                table: "Room");

            migrationBuilder.DropIndex(
                name: "IX_Room_CurrentClientId",
                table: "Room");

            migrationBuilder.DropIndex(
                name: "IX_Room_PreviousClientId",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "CurrentClientId",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "PreviousClientId",
                table: "Room");
        }
    }
}
