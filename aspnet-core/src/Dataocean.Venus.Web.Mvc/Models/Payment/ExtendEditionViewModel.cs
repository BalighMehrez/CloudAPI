using System.Collections.Generic;
using Dataocean.Venus.Editions.Dto;
using Dataocean.Venus.MultiTenancy.Payments;

namespace Dataocean.Venus.Web.Models.Payment
{
    public class ExtendEditionViewModel
    {
        public EditionSelectDto Edition { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}
