using System.Collections.Generic;
using Dataocean.Venus.Authorization.Users.Dto;

namespace Dataocean.Venus.Web.Areas.AppAreaName.Models.Users
{
    public class UserLoginAttemptModalViewModel
    {
        public List<UserLoginAttemptDto> LoginAttempts { get; set; }
    }
}
