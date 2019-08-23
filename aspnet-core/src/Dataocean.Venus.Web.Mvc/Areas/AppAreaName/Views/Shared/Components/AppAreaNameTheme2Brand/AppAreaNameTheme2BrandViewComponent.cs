using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dataocean.Venus.Web.Areas.AppAreaName.Models.Layout;
using Dataocean.Venus.Web.Session;
using Dataocean.Venus.Web.Views;

namespace Dataocean.Venus.Web.Areas.AppAreaName.Views.Shared.Components.AppAreaNameTheme2Brand
{
    public class AppAreaNameTheme2BrandViewComponent : VenusViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppAreaNameTheme2BrandViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var headerModel = new HeaderViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(headerModel);
        }
    }
}

