using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProjectPRN231.API.Migrations
{
    /// <inheritdoc />
    public partial class Update_Employeer_Field : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Employeer",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Employeer");
        }
    }
}
