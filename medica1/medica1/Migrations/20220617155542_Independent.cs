using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace medica1.Migrations
{
    public partial class Independent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "combinations",
                columns: table => new
                {
                    Medicine_Type = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Streanth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Minimum_Dose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Max_Dose = table.Column<int>(type: "int", nullable: false),
                    Create_By = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_combinations", x => x.Medicine_Type);
                });

            migrationBuilder.CreateTable(
                name: "Generic_Names",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Short_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_By = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Change_by = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generic_Names", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Medicine_Names",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicine_Names", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Medicine_Types",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicine_Types", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "combinations");

            migrationBuilder.DropTable(
                name: "Generic_Names");

            migrationBuilder.DropTable(
                name: "Medicine_Names");

            migrationBuilder.DropTable(
                name: "Medicine_Types");
        }
    }
}
