using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Dataocean.Venus.Configuration.Host.Dto;
using Dataocean.Venus.Editions.Dto;

namespace Dataocean.Venus.Web.Areas.AppAreaName.Models.HostSettings
{
    public class HostSettingsViewModel
    {
        public HostSettingsEditDto Settings { get; set; }

        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }

        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}
