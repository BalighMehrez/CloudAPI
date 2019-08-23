using System.Threading.Tasks;
using Abp.Application.Services;
using Dataocean.Venus.Configuration.Host.Dto;

namespace Dataocean.Venus.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}

