using System.Threading.Tasks;
using Abp.Application.Services;
using Dataocean.Venus.MultiTenancy.Payments.Stripe.Dto;

namespace Dataocean.Venus.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        Task CreateSubscription(StripeCreateSubscriptionInput input);

        Task UpdateSubscription(StripeUpdateSubscriptionInput input);
        
        StripeConfigurationDto GetConfiguration();
    }
}
