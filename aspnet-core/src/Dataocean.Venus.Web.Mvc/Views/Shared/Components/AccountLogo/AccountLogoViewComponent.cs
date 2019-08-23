using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dataocean.Venus.Web.Session;

namespace Dataocean.Venus.Web.Views.Shared.Components.AccountLogo
{
    public class AccountLogoViewComponent : VenusViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AccountLogoViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var loginInfo = await _sessionCache.GetCurrentLoginInformationsAsync();
            return View(new AccountLogoViewModel(loginInfo));
        }
    }
}

