using System.Threading.Tasks;

namespace Dataocean.Venus.Identity
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}
