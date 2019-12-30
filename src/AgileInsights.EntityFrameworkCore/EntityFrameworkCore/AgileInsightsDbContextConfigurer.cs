using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AgileInsights.EntityFrameworkCore
{
    public static class AgileInsightsDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AgileInsightsDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AgileInsightsDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
