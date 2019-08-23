using Abp.Domain.Services;

namespace Dataocean.Venus
{
    public abstract class VenusDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected VenusDomainServiceBase()
        {
            LocalizationSourceName = VenusConsts.LocalizationSourceName;
        }
    }
}

