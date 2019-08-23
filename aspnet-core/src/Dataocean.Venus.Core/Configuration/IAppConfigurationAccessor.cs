using Microsoft.Extensions.Configuration;

namespace Dataocean.Venus.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}

