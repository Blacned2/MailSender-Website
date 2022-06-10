using Microsoft.EntityFrameworkCore.Migrations;

namespace Side.Website.Migrations
{
    public partial class tables_04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Schools_SchoolID",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_SchoolID",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "SchoolID",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "SchooldID",
                table: "Persons");

            migrationBuilder.AddColumn<string>(
                name: "SchoolName",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SchoolName",
                table: "Persons");

            migrationBuilder.AddColumn<int>(
                name: "SchoolID",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SchooldID",
                table: "Persons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_SchoolID",
                table: "Persons",
                column: "SchoolID");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Schools_SchoolID",
                table: "Persons",
                column: "SchoolID",
                principalTable: "Schools",
                principalColumn: "SchooldID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
