using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Dataocean.Venus.Editions.Dto;

namespace Dataocean.Venus.MultiTenancy.Dto
{
    public class GetTenantFeaturesEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}
