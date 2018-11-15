using Abp.AspNetCore.Mvc.Views;

namespace SampleProject.Web.Views
{
    public abstract class SampleProjectRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected SampleProjectRazorPage()
        {
            LocalizationSourceName = SampleProjectConsts.LocalizationSourceName;
        }
    }
}
