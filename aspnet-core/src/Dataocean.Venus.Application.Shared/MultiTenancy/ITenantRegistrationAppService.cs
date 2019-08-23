using System.Threading.Tasks;
using Abp.Application.Services;
using Dataocean.Venus.Editions.Dto;
using Dataocean.Venus.MultiTenancy.Dto;

namespace Dataocean.Venus.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}
