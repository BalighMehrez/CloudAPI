using System.Collections.Generic;
using Dataocean.Venus.Organizations.Dto;

namespace Dataocean.Venus.Web.Areas.AppAreaName.Models.Common
{
    public interface IOrganizationUnitsEditViewModel
    {
        List<OrganizationUnitDto> AllOrganizationUnits { get; set; }

        List<string> MemberedOrganizationUnits { get; set; }
    }
}
