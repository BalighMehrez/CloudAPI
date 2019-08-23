using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Dataocean.Venus.Web.Public.Views
{
    public abstract class VenusRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected VenusRazorPage()
        {
            LocalizationSourceName = VenusConsts.LocalizationSourceName;
        }
    }
}

