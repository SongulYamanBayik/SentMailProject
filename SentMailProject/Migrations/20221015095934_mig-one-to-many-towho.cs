using Microsoft.EntityFrameworkCore.Migrations;

namespace SentMailProject.Migrations
{
    public partial class migonetomanytowho : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "ToWhos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ToWhos_AppUserID",
                table: "ToWhos",
                column: "AppUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_ToWhos_AspNetUsers_AppUserID",
                table: "ToWhos",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToWhos_AspNetUsers_AppUserID",
                table: "ToWhos");

            migrationBuilder.DropIndex(
                name: "IX_ToWhos_AppUserID",
                table: "ToWhos");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "ToWhos");
        }
    }
}
