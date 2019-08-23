using System.Threading.Tasks;
using Abp.Application.Services;
using Dataocean.Venus.Sessions.Dto;

namespace Dataocean.Venus.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}

