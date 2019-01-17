using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace week6Lab.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserKey = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Fname = table.Column<string>(nullable: true),
                    Lname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserKey);
                });

            migrationBuilder.CreateTable(
                name: "DBMessage",
                columns: table => new
                {
                    Key = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserKey = table.Column<int>(nullable: false),
                    TimeSent = table.Column<DateTime>(nullable: false),
                    Msg = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    Priority = table.Column<bool>(nullable: false),
                    Reply = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBMessage", x => x.Key);
                    table.ForeignKey(
                        name: "FK_DBMessage_User_UserKey",
                        column: x => x.UserKey,
                        principalTable: "User",
                        principalColumn: "UserKey",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DBMessage_UserKey",
                table: "DBMessage",
                column: "UserKey");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DBMessage");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
