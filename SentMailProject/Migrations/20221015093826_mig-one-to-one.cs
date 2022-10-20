using Microsoft.EntityFrameworkCore.Migrations;

namespace SentMailProject.Migrations
{
    public partial class migonetoone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SenderID",
                table: "SentMails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ToWhoID",
                table: "SentMails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SentMails_SenderID",
                table: "SentMails",
                column: "SenderID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SentMails_ToWhoID",
                table: "SentMails",
                column: "ToWhoID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SentMails_Senders_SenderID",
                table: "SentMails",
                column: "SenderID",
                principalTable: "Senders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SentMails_ToWhos_ToWhoID",
                table: "SentMails",
                column: "ToWhoID",
                principalTable: "ToWhos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SentMails_Senders_SenderID",
                table: "SentMails");

            migrationBuilder.DropForeignKey(
                name: "FK_SentMails_ToWhos_ToWhoID",
                table: "SentMails");

            migrationBuilder.DropIndex(
                name: "IX_SentMails_SenderID",
                table: "SentMails");

            migrationBuilder.DropIndex(
                name: "IX_SentMails_ToWhoID",
                table: "SentMails");

            migrationBuilder.DropColumn(
                name: "SenderID",
                table: "SentMails");

            migrationBuilder.DropColumn(
                name: "ToWhoID",
                table: "SentMails");
        }
    }
}
