using Abp.AspNetCore.Mvc.Authorization;
using Dataocean.Venus.Storage;

namespace Dataocean.Venus.Web.Controllers
{
    [AbpMvcAuthorize]
    public class ProfileController : ProfileControllerBase
    {
        public ProfileController(ITempFileCacheManager tempFileCacheManager) :
            base(tempFileCacheManager)
        {
        }
    }
}
