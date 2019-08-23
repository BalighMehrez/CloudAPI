using Abp.AspNetCore.Mvc.ViewComponents;

namespace Dataocean.Venus.Web.Public.Views
{
    public abstract class VenusViewComponent : AbpViewComponent
    {
        protected VenusViewComponent()
        {
            LocalizationSourceName = VenusConsts.LocalizationSourceName;
        }
    }
}
