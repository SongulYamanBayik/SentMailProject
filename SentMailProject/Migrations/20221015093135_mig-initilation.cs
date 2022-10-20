using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SentMailProject.Migrations
{
    public partial class miginitilation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Senders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Senders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SentMails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReadStatus = table.Column<bool>(type: "bit", nullable: false),
                    SenderStarred = table.Column<bool>(type: "bit", nullable: false),
                    ToWhoStarred = table.Column<bool>(type: "bit", nullable: false),
                    SenderStatus = table.Column<bool>(type: "bit", nullable: false),
                    ToWhoStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SentMails", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ToWhos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToWhos", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Senders");

            migrationBuilder.DropTable(
                name: "SentMails");

            migrationBuilder.DropTable(
                name: "ToWhos");
        }
    }
}
