using Microsoft.AspNetCore.Mvc;
using Dataocean.Venus.Web.Controllers;

namespace Dataocean.Venus.Web.Public.Controllers
{
    public class AboutController : VenusControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
