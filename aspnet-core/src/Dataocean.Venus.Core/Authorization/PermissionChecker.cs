using Abp.Authorization;
using Dataocean.Venus.Authorization.Roles;
using Dataocean.Venus.Authorization.Users;

namespace Dataocean.Venus.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}

