using Dataocean.Venus.Dto;

namespace Dataocean.Venus.Common.Dto
{
    public class FindUsersInput : PagedAndFilteredInputDto
    {
        public int? TenantId { get; set; }
    }
}
