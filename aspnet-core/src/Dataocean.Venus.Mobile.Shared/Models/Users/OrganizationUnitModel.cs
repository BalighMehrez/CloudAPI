using Abp.AutoMapper;
using Dataocean.Venus.Organizations.Dto;

namespace Dataocean.Venus.Models.Users
{
    [AutoMapFrom(typeof(OrganizationUnitDto))]
    public class OrganizationUnitModel : OrganizationUnitDto
    {
        public bool IsAssigned { get; set; }
    }
}
