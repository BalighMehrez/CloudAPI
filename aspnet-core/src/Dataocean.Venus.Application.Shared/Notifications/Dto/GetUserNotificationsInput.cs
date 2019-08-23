using Abp.Notifications;
using Dataocean.Venus.Dto;

namespace Dataocean.Venus.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }
    }
}
