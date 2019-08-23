using Dataocean.Venus.MultiTenancy.Payments;

namespace Dataocean.Venus.Web.Models.Payment
{
    public class CancelPaymentModel
    {
        public string PaymentId { get; set; }

        public SubscriptionPaymentGatewayType Gateway { get; set; }
    }
}
