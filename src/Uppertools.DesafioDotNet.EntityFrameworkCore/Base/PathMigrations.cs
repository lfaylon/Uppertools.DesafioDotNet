using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.IO;

namespace Uppertools.DesafioDotNet
{
    public static class PathMigrations
    {
        public static void GenerateSQL(MigrationBuilder migrationBuilder, string nameScript)
        {
            try
            {
                var basePath = Directory.GetCurrentDirectory().ToString().Replace("Web.Host", @"EntityFrameworkCore\Scripts\");

                if (migrationBuilder == null) throw new ArgumentNullException(nameof(migrationBuilder));
                if (string.IsNullOrEmpty(nameScript)) throw new ArgumentNullException(nameof(nameScript));

                migrationBuilder.Sql(System.IO.File.ReadAllText($"{basePath}{nameScript}"));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
