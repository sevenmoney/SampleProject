using Abp.Application.Services;

namespace SampleProject
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class SampleProjectAppServiceBase : ApplicationService
    {
        protected SampleProjectAppServiceBase()
        {
            LocalizationSourceName = SampleProjectConsts.LocalizationSourceName;
        }
    }
}