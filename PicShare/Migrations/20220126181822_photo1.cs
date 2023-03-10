using Microsoft.EntityFrameworkCore.Migrations;

namespace PicShare.Migrations
{
    public partial class photo1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PhotoGraphy");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "PhotoGraphy",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "PhotoGraphy",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhotoGraphy_ApplicationUserId",
                table: "PhotoGraphy",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhotoGraphy_AspNetUsers_ApplicationUserId",
                table: "PhotoGraphy",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhotoGraphy_AspNetUsers_ApplicationUserId",
                table: "PhotoGraphy");

            migrationBuilder.DropIndex(
                name: "IX_PhotoGraphy_ApplicationUserId",
                table: "PhotoGraphy");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "PhotoGraphy");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "PhotoGraphy",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "PhotoGraphy",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);
        }
    }
}
