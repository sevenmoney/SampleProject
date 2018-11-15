using Abp.Modules;
using Abp.Reflection.Extensions;
using SampleProject.Localization;

namespace SampleProject
{
    public class SampleProjectCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            SampleProjectLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SampleProjectCoreModule).GetAssembly());
        }
    }
}