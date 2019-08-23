using Abp.AutoMapper;
using Dataocean.Venus.Sessions.Dto;

namespace Dataocean.Venus.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
