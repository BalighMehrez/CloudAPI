using System.Threading.Tasks;

namespace Dataocean.Venus.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}
