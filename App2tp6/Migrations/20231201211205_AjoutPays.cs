using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App2tp6.Migrations
{
    /// <inheritdoc />
    public partial class AjoutPays : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Pays",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pays",
                table: "Hotels");
        }
    }
}
