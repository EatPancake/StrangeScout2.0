using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StrangeScout.Migrations
{
    /// <inheritdoc />
    public partial class IntitalCreate : Migration
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
                    Cones = table.Column<int>(type: "INTEGER", nullable: false),
                    Cubes = table.Column<int>(type: "INTEGER", nullable: false),
                    DoubleSubstation = table.Column<int>(type: "INTEGER", nullable: false),
                    SingleSubstation = table.Column<int>(type: "INTEGER", nullable: false),
                    Center = table.Column<int>(type: "INTEGER", nullable: false),
                    Top = table.Column<int>(type: "INTEGER", nullable: false),
                    Mid = table.Column<int>(type: "INTEGER", nullable: false),
                    Bot = table.Column<int>(type: "INTEGER", nullable: false),
                    CycleTime = table.Column<float>(type: "REAL", nullable: false),
                    Engaged = table.Column<bool>(type: "INTEGER", nullable: false),
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
