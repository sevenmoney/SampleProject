using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SampleProject.Configuration;
using SampleProject.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace SampleProject.Web.Startup
{
    [DependsOn(
        typeof(SampleProjectApplicationModule), 
        typeof(SampleProjectEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class SampleProjectWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public SampleProjectWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(SampleProjectConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<SampleProjectNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(SampleProjectApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SampleProjectWebModule).GetAssembly());
        }
    }
}