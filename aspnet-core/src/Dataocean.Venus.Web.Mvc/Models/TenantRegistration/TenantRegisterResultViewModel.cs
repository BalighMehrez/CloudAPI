using Abp.AutoMapper;
using Dataocean.Venus.MultiTenancy.Dto;

namespace Dataocean.Venus.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(RegisterTenantOutput))]
    public class TenantRegisterResultViewModel : RegisterTenantOutput
    {
        public string TenantLoginAddress { get; set; }
    }
}
