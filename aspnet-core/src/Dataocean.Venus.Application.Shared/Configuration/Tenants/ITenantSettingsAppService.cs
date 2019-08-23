using System.Threading.Tasks;
using Abp.Application.Services;
using Dataocean.Venus.Configuration.Tenants.Dto;

namespace Dataocean.Venus.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}

