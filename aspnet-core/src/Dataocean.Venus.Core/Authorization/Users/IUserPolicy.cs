using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace Dataocean.Venus.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}

