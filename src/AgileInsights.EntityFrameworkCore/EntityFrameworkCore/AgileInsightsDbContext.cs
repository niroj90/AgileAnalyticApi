using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AgileInsights.Authorization.Roles;
using AgileInsights.Authorization.Users;
using AgileInsights.MultiTenancy;
using AgileInsights.Reference;
using AgileInsights.Remote;

namespace AgileInsights.EntityFrameworkCore
{
    public class AgileInsightsDbContext : AbpZeroDbContext<Tenant, Role, User, AgileInsightsDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public virtual DbSet<Analytics.Analytics> Analytics { get; set; }

        public virtual DbSet<RemoteClient> RemoteClients { get; set; }

        public virtual DbSet<RemoteToken> RemoteClientTokens { get; set; }

        public AgileInsightsDbContext(DbContextOptions<AgileInsightsDbContext> options)
            : base(options)
        {
        }
    }
}
