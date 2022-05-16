using Microsoft.EntityFrameworkCore.Migrations;

namespace Uppertools.DesafioDotNet.Migrations
{
    public partial class InsertAccountTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            PathMigrations.GenerateSQL(migrationBuilder, "Insert-AccountTypes.sql");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
