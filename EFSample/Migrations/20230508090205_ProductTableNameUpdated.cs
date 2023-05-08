using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFSample.Migrations
{
    public partial class ProductTableNameUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_cagatay",
                table: "cagatay");

            migrationBuilder.RenameTable(
                name: "cagatay",
                newName: "Products");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "cagatay");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cagatay",
                table: "cagatay",
                column: "Id");
        }
    }
}
