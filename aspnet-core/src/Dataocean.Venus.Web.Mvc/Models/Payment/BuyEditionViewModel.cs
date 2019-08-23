using System.Collections.Generic;
using Dataocean.Venus.Editions;
using Dataocean.Venus.Editions.Dto;
using Dataocean.Venus.MultiTenancy.Payments;
using Dataocean.Venus.MultiTenancy.Payments.Dto;

namespace Dataocean.Venus.Web.Models.Payment
{
    public class BuyEditionViewModel
    {
        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public decimal? AdditionalPrice { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}

