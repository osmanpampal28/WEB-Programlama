using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCWEB.Migrations
{
    public partial class hepsi0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_CategorieS_CategoriesID",
                table: "Blogs");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriesID",
                table: "Blogs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_CategorieS_CategoriesID",
                table: "Blogs",
                column: "CategoriesID",
                principalTable: "CategorieS",
                principalColumn: "CategoriesID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_CategorieS_CategoriesID",
                table: "Blogs");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriesID",
                table: "Blogs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_CategorieS_CategoriesID",
                table: "Blogs",
                column: "CategoriesID",
                principalTable: "CategorieS",
                principalColumn: "CategoriesID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
