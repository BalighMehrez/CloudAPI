using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Dataocean.Venus.Editions.Dto;

namespace Dataocean.Venus.Web.Areas.AppAreaName.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}
