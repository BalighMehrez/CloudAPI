using System.Threading.Tasks;
using Abp.Application.Services;
using Dataocean.Venus.Install.Dto;

namespace Dataocean.Venus.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}
