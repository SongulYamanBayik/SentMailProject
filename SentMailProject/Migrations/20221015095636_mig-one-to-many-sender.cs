using Microsoft.EntityFrameworkCore.Migrations;

namespace SentMailProject.Migrations
{
    public partial class migonetomanysender : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "Senders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Senders_AppUserID",
                table: "Senders",
                column: "AppUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Senders_AspNetUsers_AppUserID",
                table: "Senders",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Senders_AspNetUsers_AppUserID",
                table: "Senders");

            migrationBuilder.DropIndex(
                name: "IX_Senders_AppUserID",
                table: "Senders");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "Senders");
        }
    }
}
