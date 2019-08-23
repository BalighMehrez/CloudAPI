using System.Threading.Tasks;

namespace Dataocean.Venus.Security
{
    public interface IPasswordComplexitySettingStore
    {
        Task<PasswordComplexitySetting> GetSettingsAsync();
    }
}

