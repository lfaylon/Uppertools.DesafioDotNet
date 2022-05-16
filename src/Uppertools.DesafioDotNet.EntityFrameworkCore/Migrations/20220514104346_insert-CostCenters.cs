using Microsoft.EntityFrameworkCore.Migrations;

namespace Uppertools.DesafioDotNet.Migrations
{
    public partial class insertCostCenters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            PathMigrations.GenerateSQL(migrationBuilder, "Insert-CostCenters.sql");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
