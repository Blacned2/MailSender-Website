using Microsoft.EntityFrameworkCore.Migrations;

namespace Side.Website.Migrations
{
    public partial class tables_03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_Country_CountryID",
                table: "City");

            migrationBuilder.DropForeignKey(
                name: "FK_Schools_City_CityID",
                table: "Schools");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Country",
                table: "Country");

            migrationBuilder.DropPrimaryKey(
                name: "PK_City",
                table: "City");

            migrationBuilder.DropColumn(
                name: "GraduateStatus",
                table: "Persons");

            migrationBuilder.RenameTable(
                name: "Country",
                newName: "Countries");

            migrationBuilder.RenameTable(
                name: "City",
                newName: "Cities");

            migrationBuilder.RenameIndex(
                name: "IX_City_CountryID",
                table: "Cities",
                newName: "IX_Cities_CountryID");

            migrationBuilder.AddColumn<int>(
                name: "GraduateStatusID",
                table: "Persons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "CountryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "CityID");

            migrationBuilder.CreateTable(
                name: "GraduateStatuses",
                columns: table => new
                {
                    GraduateStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GraduateStatuses", x => x.GraduateStatusID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_GraduateStatusID",
                table: "Persons",
                column: "GraduateStatusID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_CountryID",
                table: "Cities",
                column: "CountryID",
                principalTable: "Countries",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_GraduateStatuses_GraduateStatusID",
                table: "Persons",
                column: "GraduateStatusID",
                principalTable: "GraduateStatuses",
                principalColumn: "GraduateStatusID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schools_Cities_CityID",
                table: "Schools",
                column: "CityID",
                principalTable: "Cities",
                principalColumn: "CityID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_CountryID",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_GraduateStatuses_GraduateStatusID",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Schools_Cities_CityID",
                table: "Schools");

            migrationBuilder.DropTable(
                name: "GraduateStatuses");

            migrationBuilder.DropIndex(
                name: "IX_Persons_GraduateStatusID",
                table: "Persons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "GraduateStatusID",
                table: "Persons");

            migrationBuilder.RenameTable(
                name: "Countries",
                newName: "Country");

            migrationBuilder.RenameTable(
                name: "Cities",
                newName: "City");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_CountryID",
                table: "City",
                newName: "IX_City_CountryID");

            migrationBuilder.AddColumn<byte>(
                name: "GraduateStatus",
                table: "Persons",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Country",
                table: "Country",
                column: "CountryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_City",
                table: "City",
                column: "CityID");

            migrationBuilder.AddForeignKey(
                name: "FK_City_Country_CountryID",
                table: "City",
                column: "CountryID",
                principalTable: "Country",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schools_City_CityID",
                table: "Schools",
                column: "CityID",
                principalTable: "City",
                principalColumn: "CityID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
