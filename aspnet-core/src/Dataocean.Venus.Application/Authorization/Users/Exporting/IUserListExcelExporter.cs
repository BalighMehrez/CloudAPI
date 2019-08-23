using System.Collections.Generic;
using Dataocean.Venus.Authorization.Users.Dto;
using Dataocean.Venus.Dto;

namespace Dataocean.Venus.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}
