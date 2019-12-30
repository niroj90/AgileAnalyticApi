using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AgileInsights.Authorization.Roles;
using AgileInsights.Authorization.Users;
using AgileInsights.MultiTenancy;

namespace AgileInsights.EntityFrameworkCore
{
    public class AgileInsightsDbContext : AbpZeroDbContext<Tenant, Role, User, AgileInsightsDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AgileInsightsDbContext(DbContextOptions<AgileInsightsDbContext> options)
            : base(options)
        {
        }
    }
}
