using Abp.AspNetCore.Mvc.Controllers;

namespace SampleProject.Web.Controllers
{
    public abstract class SampleProjectControllerBase: AbpController
    {
        protected SampleProjectControllerBase()
        {
            LocalizationSourceName = SampleProjectConsts.LocalizationSourceName;
        }
    }
}