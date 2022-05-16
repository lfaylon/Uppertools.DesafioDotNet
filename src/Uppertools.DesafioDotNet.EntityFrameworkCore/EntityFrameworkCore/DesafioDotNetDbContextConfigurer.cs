using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Uppertools.DesafioDotNet.EntityFrameworkCore
{
    public static class DesafioDotNetDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DesafioDotNetDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DesafioDotNetDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
