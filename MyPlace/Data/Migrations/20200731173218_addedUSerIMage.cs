using Microsoft.EntityFrameworkCore.Migrations;

namespace MyPlace.Data.Migrations
{
    public partial class addedUSerIMage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Images",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Images",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
