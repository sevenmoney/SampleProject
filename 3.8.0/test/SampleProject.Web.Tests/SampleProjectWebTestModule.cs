using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SampleProject.Web.Startup;
namespace SampleProject.Web.Tests
{
    [DependsOn(
        typeof(SampleProjectWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class SampleProjectWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SampleProjectWebTestModule).GetAssembly());
        }
    }
}