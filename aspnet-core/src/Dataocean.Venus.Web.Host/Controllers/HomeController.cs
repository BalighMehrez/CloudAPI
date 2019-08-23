using Abp.Auditing;
using Microsoft.AspNetCore.Mvc;

namespace Dataocean.Venus.Web.Controllers
{
    public class HomeController : VenusControllerBase
    {
        [DisableAuditing]
        public IActionResult Index()
        {
            return Redirect("/swagger");
        }
    }
}

