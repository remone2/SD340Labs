using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SD340Labs.Migrations
{
    public partial class ValidatePhoneNumbers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhoneNumberCheckViewModel",
                columns: table => new
                {
                    CountryCodeSelected = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumberRaw = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valid = table.Column<bool>(type: "bit", nullable: false),
                    HasExtension = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhoneNumberCheckViewModel");
        }
    }
}
