using Abp.Application.Services;
using Dataocean.Venus.Dto;
using Dataocean.Venus.Logging.Dto;

namespace Dataocean.Venus.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}

