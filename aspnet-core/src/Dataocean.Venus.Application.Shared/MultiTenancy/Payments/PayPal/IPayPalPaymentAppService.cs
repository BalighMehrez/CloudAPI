using System.Threading.Tasks;
using Abp.Application.Services;
using Dataocean.Venus.MultiTenancy.Payments.Dto;
using Dataocean.Venus.MultiTenancy.Payments.PayPal.Dto;

namespace Dataocean.Venus.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalPaymentId, string paypalPayerId);

        PayPalConfigurationDto GetConfiguration();

        Task CancelPayment(CancelPaymentDto input);
    }
}

