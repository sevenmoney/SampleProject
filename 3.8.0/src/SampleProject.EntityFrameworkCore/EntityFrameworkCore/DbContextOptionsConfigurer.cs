using Microsoft.EntityFrameworkCore;

namespace SampleProject.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<SampleProjectDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for SampleProjectDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
