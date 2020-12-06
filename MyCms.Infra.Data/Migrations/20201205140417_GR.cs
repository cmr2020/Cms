using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCms.Infra.Data.Migrations
{
    public partial class GR : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pages_PageGroups_PageGroupGroupId",
                table: "Pages");

            migrationBuilder.RenameColumn(
                name: "PageGroupGroupId",
                table: "Pages",
                newName: "PageGroupGroupID");

            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "Pages",
                newName: "GroupID");

            migrationBuilder.RenameColumn(
                name: "PageId",
                table: "Pages",
                newName: "PageID");

            migrationBuilder.RenameIndex(
                name: "IX_Pages_PageGroupGroupId",
                table: "Pages",
                newName: "IX_Pages_PageGroupGroupID");

            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "PageGroups",
                newName: "GroupID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_PageGroups_PageGroupGroupID",
                table: "Pages",
                column: "PageGroupGroupID",
                principalTable: "PageGroups",
                principalColumn: "GroupID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pages_PageGroups_PageGroupGroupID",
                table: "Pages");

            migrationBuilder.RenameColumn(
                name: "PageGroupGroupID",
                table: "Pages",
                newName: "PageGroupGroupId");

            migrationBuilder.RenameColumn(
                name: "GroupID",
                table: "Pages",
                newName: "GroupId");

            migrationBuilder.RenameColumn(
                name: "PageID",
                table: "Pages",
                newName: "PageId");

            migrationBuilder.RenameIndex(
                name: "IX_Pages_PageGroupGroupID",
                table: "Pages",
                newName: "IX_Pages_PageGroupGroupId");

            migrationBuilder.RenameColumn(
                name: "GroupID",
                table: "PageGroups",
                newName: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_PageGroups_PageGroupGroupId",
                table: "Pages",
                column: "PageGroupGroupId",
                principalTable: "PageGroups",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
