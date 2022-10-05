using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MisApplication.Migrations
{
    public partial class Independent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "mis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EMO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Admission = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discharge = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NVD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dialysis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Physiotherapy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EPI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dressing = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nebulizer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InjectionPush = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stich = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DandC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surgery = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    USG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Xray = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ECG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CTG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lab = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PFquentity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PFvalue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mis", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "mis");
        }
    }
}
