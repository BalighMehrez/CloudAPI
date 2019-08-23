using Microsoft.AspNetCore.Antiforgery;

namespace Dataocean.Venus.Web.Controllers
{
    public class AntiForgeryController : VenusControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}

