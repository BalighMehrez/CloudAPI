using System.Threading.Tasks;
using Dataocean.Venus.ApiClient.Models;

namespace Dataocean.Venus.ApiClient
{
    public interface IAccessTokenManager
    {
        Task<string> GetAccessTokenAsync();
         
        Task<AbpAuthenticateResultModel> LoginAsync();

        void Logout();

        bool IsUserLoggedIn { get; }
    }
}
