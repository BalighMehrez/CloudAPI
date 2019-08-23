using System.Threading.Tasks;
using Dataocean.Venus.Security.Recaptcha;

namespace Dataocean.Venus.Tests.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}

