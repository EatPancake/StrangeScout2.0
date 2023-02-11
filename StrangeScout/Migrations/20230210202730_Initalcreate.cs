using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StrangeScout.Migrations
{
    /// <inheritdoc />
    public partial class Initalcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Event = table.Column<string>(type: "TEXT", nullable: false),
                    Round = table.Column<int>(type: "INTEGER", nullable: false),
                    TeamNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    ConesA = table.Column<int>(name: "Cones_A", type: "INTEGER", nullable: false),
                    CubesA = table.Column<int>(name: "Cubes_A", type: "INTEGER", nullable: false),
                    Cones = table.Column<int>(type: "INTEGER", nullable: false),
                    Cubes = table.Column<int>(type: "INTEGER", nullable: false),
                    ConesE = table.Column<int>(name: "Cones_E", type: "INTEGER", nullable: false),
                    CubesE = table.Column<int>(name: "Cubes_E", type: "INTEGER", nullable: false),
                    DoubleSubstationA = table.Column<int>(name: "DoubleSubstation_A", type: "INTEGER", nullable: false),
                    SingleSubstationA = table.Column<int>(name: "SingleSubstation_A", type: "INTEGER", nullable: false),
                    CenterA = table.Column<int>(name: "Center_A", type: "INTEGER", nullable: false),
                    DoubleSubstation = table.Column<int>(type: "INTEGER", nullable: false),
                    SingleSubstation = table.Column<int>(type: "INTEGER", nullable: false),
                    Center = table.Column<int>(type: "INTEGER", nullable: false),
                    DoubleSubstationE = table.Column<int>(name: "DoubleSubstation_E", type: "INTEGER", nullable: false),
                    SingleSubstationE = table.Column<int>(name: "SingleSubstation_E", type: "INTEGER", nullable: false),
                    CenterE = table.Column<int>(name: "Center_E", type: "INTEGER", nullable: false),
                    TopA = table.Column<int>(name: "Top_A", type: "INTEGER", nullable: false),
                    MidA = table.Column<int>(name: "Mid_A", type: "INTEGER", nullable: false),
                    BotA = table.Column<int>(name: "Bot_A", type: "INTEGER", nullable: false),
                    Top = table.Column<int>(type: "INTEGER", nullable: false),
                    Mid = table.Column<int>(type: "INTEGER", nullable: false),
                    Bot = table.Column<int>(type: "INTEGER", nullable: false),
                    TopE = table.Column<int>(name: "Top_E", type: "INTEGER", nullable: false),
                    MidE = table.Column<int>(name: "Mid_E", type: "INTEGER", nullable: false),
                    BotE = table.Column<int>(name: "Bot_E", type: "INTEGER", nullable: false),
                    CycleTime = table.Column<float>(type: "REAL", nullable: false),
                    EngagedA = table.Column<string>(name: "Engaged_A", type: "TEXT", nullable: true),
                    Engaged = table.Column<string>(type: "TEXT", nullable: true),
                    Mobility = table.Column<string>(type: "TEXT", nullable: true),
                    Parked = table.Column<string>(type: "TEXT", nullable: true),
                    Points = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Matches");
        }
    }
}
