using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Dataocean.Venus.Authorization;
using Dataocean.Venus.Web.Controllers;

namespace Dataocean.Venus.Web.Areas.AppAreaName.Controllers
{
    [Area("AppAreaName")]
    [AbpMvcAuthorize(AppPermissions.Pages_Tenant_Dashboard)]
    public class DashboardController : VenusControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
