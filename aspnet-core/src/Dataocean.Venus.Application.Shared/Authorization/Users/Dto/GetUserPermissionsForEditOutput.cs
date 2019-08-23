using System.Collections.Generic;
using Dataocean.Venus.Authorization.Permissions.Dto;

namespace Dataocean.Venus.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}
