using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.EntityFrameworkCore
{
    public class SampleProjectDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public SampleProjectDbContext(DbContextOptions<SampleProjectDbContext> options) 
            : base(options)
        {

        }
    }
}
