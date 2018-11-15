using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace SampleProject
{
    [DependsOn(
        typeof(SampleProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SampleProjectApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SampleProjectApplicationModule).GetAssembly());
        }
    }
}