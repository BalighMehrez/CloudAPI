using System.Collections.Generic;
using MvvmHelpers;
using Dataocean.Venus.Models.NavigationMenu;

namespace Dataocean.Venus.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}
