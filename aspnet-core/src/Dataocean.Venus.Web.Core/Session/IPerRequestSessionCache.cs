using System.Threading.Tasks;
using Dataocean.Venus.Sessions.Dto;

namespace Dataocean.Venus.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}

