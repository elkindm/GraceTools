using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace GraceTools.EntityFrameworkCore
{
    public static class GraceToolsDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<GraceToolsDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<GraceToolsDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
