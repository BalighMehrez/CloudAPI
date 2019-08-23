using Abp.AutoMapper;
using Dataocean.Venus.Authorization.Roles.Dto;
using Dataocean.Venus.Web.Areas.AppAreaName.Models.Common;

namespace Dataocean.Venus.Web.Areas.AppAreaName.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class CreateOrEditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool IsEditMode
        {
            get { return Role.Id.HasValue; }
        }

        public CreateOrEditRoleModalViewModel(GetRoleForEditOutput output)
        {
            output.MapTo(this);
        }
    }
}
