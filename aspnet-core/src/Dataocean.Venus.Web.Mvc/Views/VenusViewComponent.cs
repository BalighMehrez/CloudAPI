using Abp.AspNetCore.Mvc.ViewComponents;

namespace Dataocean.Venus.Web.Views
{
    public abstract class VenusViewComponent : AbpViewComponent
    {
        protected VenusViewComponent()
        {
            LocalizationSourceName = VenusConsts.LocalizationSourceName;
        }
    }
}
