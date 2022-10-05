using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace medica1.Migrations
{
    public partial class ManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CombinationGeneric_Name",
                columns: table => new
                {
                    Combinationgeneric_NamesID = table.Column<int>(type: "int", nullable: false),
                    GenericcombinationsMedicine_Type = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CombinationGeneric_Name", x => new { x.Combinationgeneric_NamesID, x.GenericcombinationsMedicine_Type });
                    table.ForeignKey(
                        name: "FK_CombinationGeneric_Name_combinations_GenericcombinationsMedicine_Type",
                        column: x => x.GenericcombinationsMedicine_Type,
                        principalTable: "combinations",
                        principalColumn: "Medicine_Type",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CombinationGeneric_Name_Generic_Names_Combinationgeneric_NamesID",
                        column: x => x.Combinationgeneric_NamesID,
                        principalTable: "Generic_Names",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CombinationMedicine_Type",
                columns: table => new
                {
                    CombinationMedicine_TypeID = table.Column<int>(type: "int", nullable: false),
                    Medicine_TypeCombinationMedicine_Type = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CombinationMedicine_Type", x => new { x.CombinationMedicine_TypeID, x.Medicine_TypeCombinationMedicine_Type });
                    table.ForeignKey(
                        name: "FK_CombinationMedicine_Type_combinations_Medicine_TypeCombinationMedicine_Type",
                        column: x => x.Medicine_TypeCombinationMedicine_Type,
                        principalTable: "combinations",
                        principalColumn: "Medicine_Type",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CombinationMedicine_Type_Medicine_Types_CombinationMedicine_TypeID",
                        column: x => x.CombinationMedicine_TypeID,
                        principalTable: "Medicine_Types",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Generic_NameMedicine_Name",
                columns: table => new
                {
                    Genetic_Namemedicine_NamesID = table.Column<int>(type: "int", nullable: false),
                    Medicine_Namegeneric_NamesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generic_NameMedicine_Name", x => new { x.Genetic_Namemedicine_NamesID, x.Medicine_Namegeneric_NamesID });
                    table.ForeignKey(
                        name: "FK_Generic_NameMedicine_Name_Generic_Names_Medicine_Namegeneric_NamesID",
                        column: x => x.Medicine_Namegeneric_NamesID,
                        principalTable: "Generic_Names",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Generic_NameMedicine_Name_Medicine_Names_Genetic_Namemedicine_NamesID",
                        column: x => x.Genetic_Namemedicine_NamesID,
                        principalTable: "Medicine_Names",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CombinationGeneric_Name_GenericcombinationsMedicine_Type",
                table: "CombinationGeneric_Name",
                column: "GenericcombinationsMedicine_Type");

            migrationBuilder.CreateIndex(
                name: "IX_CombinationMedicine_Type_Medicine_TypeCombinationMedicine_Type",
                table: "CombinationMedicine_Type",
                column: "Medicine_TypeCombinationMedicine_Type");

            migrationBuilder.CreateIndex(
                name: "IX_Generic_NameMedicine_Name_Medicine_Namegeneric_NamesID",
                table: "Generic_NameMedicine_Name",
                column: "Medicine_Namegeneric_NamesID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CombinationGeneric_Name");

            migrationBuilder.DropTable(
                name: "CombinationMedicine_Type");

            migrationBuilder.DropTable(
                name: "Generic_NameMedicine_Name");
        }
    }
}
