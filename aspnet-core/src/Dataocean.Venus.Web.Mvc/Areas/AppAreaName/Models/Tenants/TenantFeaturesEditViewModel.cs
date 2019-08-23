using Abp.AutoMapper;
using Dataocean.Venus.MultiTenancy;
using Dataocean.Venus.MultiTenancy.Dto;
using Dataocean.Venus.Web.Areas.AppAreaName.Models.Common;

namespace Dataocean.Venus.Web.Areas.AppAreaName.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }

        public TenantFeaturesEditViewModel(Tenant tenant, GetTenantFeaturesEditOutput output)
        {
            Tenant = tenant;
            output.MapTo(this);
        }
    }
}
