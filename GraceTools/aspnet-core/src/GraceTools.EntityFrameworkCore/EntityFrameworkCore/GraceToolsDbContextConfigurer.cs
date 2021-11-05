using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace GraceTools.EntityFrameworkCore
{
    public static class GraceToolsDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<GraceToolsDbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<GraceToolsDbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}
