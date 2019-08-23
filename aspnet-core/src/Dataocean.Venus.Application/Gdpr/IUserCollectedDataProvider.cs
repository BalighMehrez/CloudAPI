using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using Dataocean.Venus.Dto;

namespace Dataocean.Venus.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}

