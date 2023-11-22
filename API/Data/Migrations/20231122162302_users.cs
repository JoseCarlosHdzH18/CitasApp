using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class users : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photo_Users_AppUSerId",
                table: "Photo");

            migrationBuilder.RenameColumn(
                name: "DateofBirth",
                table: "Users",
                newName: "DateOfBirth");

            migrationBuilder.RenameColumn(
                name: "AppUSerId",
                table: "Photo",
                newName: "AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Photo_AppUSerId",
                table: "Photo",
                newName: "IX_Photo_AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_Users_AppUserId",
                table: "Photo",
                column: "AppUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photo_Users_AppUserId",
                table: "Photo");

            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "Users",
                newName: "DateofBirth");

            migrationBuilder.RenameColumn(
                name: "AppUserId",
                table: "Photo",
                newName: "AppUSerId");

            migrationBuilder.RenameIndex(
                name: "IX_Photo_AppUserId",
                table: "Photo",
                newName: "IX_Photo_AppUSerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_Users_AppUSerId",
                table: "Photo",
                column: "AppUSerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
