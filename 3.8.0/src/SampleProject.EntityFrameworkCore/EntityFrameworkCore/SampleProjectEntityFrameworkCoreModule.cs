using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace SampleProject.EntityFrameworkCore
{
    [DependsOn(
        typeof(SampleProjectCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class SampleProjectEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SampleProjectEntityFrameworkCoreModule).GetAssembly());
        }
    }
}