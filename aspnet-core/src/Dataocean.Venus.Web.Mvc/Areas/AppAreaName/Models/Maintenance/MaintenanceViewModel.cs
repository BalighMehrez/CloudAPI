using System.Collections.Generic;
using Dataocean.Venus.Caching.Dto;

namespace Dataocean.Venus.Web.Areas.AppAreaName.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}
