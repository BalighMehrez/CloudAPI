using System.Collections.Generic;
using Dataocean.Venus.Authorization.Permissions.Dto;

namespace Dataocean.Venus.Web.Areas.AppAreaName.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}
