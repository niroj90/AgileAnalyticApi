using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using AgileInsights.Configuration;
using AgileInsights.Web;

namespace AgileInsights.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AgileInsightsDbContextFactory : IDesignTimeDbContextFactory<AgileInsightsDbContext>
    {
        public AgileInsightsDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AgileInsightsDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AgileInsightsDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AgileInsightsConsts.ConnectionStringName));

            return new AgileInsightsDbContext(builder.Options);
        }
    }
}
