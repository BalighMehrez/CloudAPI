using Abp;

namespace Dataocean.Venus
{
    /// <summary>
    /// This class can be used as a base class for services in this application.
    /// It has some useful objects property-injected and has some basic methods most of services may need to.
    /// It's suitable for non domain nor application service classes.
    /// For domain services inherit <see cref="VenusDomainServiceBase"/>.
    /// For application services inherit VenusAppServiceBase.
    /// </summary>
    public abstract class VenusServiceBase : AbpServiceBase
    {
        protected VenusServiceBase()
        {
            LocalizationSourceName = VenusConsts.LocalizationSourceName;
        }
    }
}
