using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Dataocean.Venus.Authorization.Permissions.Dto;

namespace Dataocean.Venus.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}

