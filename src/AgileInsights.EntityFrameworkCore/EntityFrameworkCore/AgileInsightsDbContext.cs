using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AgileInsights.Authorization.Roles;
using AgileInsights.Authorization.Users;
using AgileInsights.MultiTenancy;
using AgileInsights.Connectivity;
using AgileInsights.Reference;

namespace AgileInsights.EntityFrameworkCore
{
    public class AgileInsightsDbContext : AbpZeroDbContext<Tenant, Role, User, AgileInsightsDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<ConnectionString> ConnectionStrings { get; set; }
        public virtual DbSet<Analytics.Analytics> Analytics { get; set; }

        public virtual DbSet<TableReference> TableReferences { get; set; }

        public AgileInsightsDbContext(DbContextOptions<AgileInsightsDbContext> options)
            : base(options)
        {
        }
    }
}
