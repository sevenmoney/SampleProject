using SampleProject.Configuration;
using SampleProject.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace SampleProject.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class SampleProjectDbContextFactory : IDesignTimeDbContextFactory<SampleProjectDbContext>
    {
        public SampleProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SampleProjectDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(SampleProjectConsts.ConnectionStringName)
            );

            return new SampleProjectDbContext(builder.Options);
        }
    }
}