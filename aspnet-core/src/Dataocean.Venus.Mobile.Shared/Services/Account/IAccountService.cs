using System.Threading.Tasks;
using Dataocean.Venus.ApiClient.Models;

namespace Dataocean.Venus.Services.Account
{
    public interface IAccountService
    {
        AbpAuthenticateModel AbpAuthenticateModel { get; set; }
        AbpAuthenticateResultModel AuthenticateResultModel { get; set; }
        Task LoginUserAsync();
    }
}

