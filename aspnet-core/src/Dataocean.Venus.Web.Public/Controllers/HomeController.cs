using Microsoft.AspNetCore.Mvc;
using Dataocean.Venus.Web.Controllers;

namespace Dataocean.Venus.Web.Public.Controllers
{
    public class HomeController : VenusControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
