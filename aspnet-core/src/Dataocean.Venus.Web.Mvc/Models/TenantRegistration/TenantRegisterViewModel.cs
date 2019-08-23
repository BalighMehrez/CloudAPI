using Dataocean.Venus.Editions;
using Dataocean.Venus.Editions.Dto;
using Dataocean.Venus.MultiTenancy.Payments;
using Dataocean.Venus.Security;
using Dataocean.Venus.MultiTenancy.Payments.Dto;

namespace Dataocean.Venus.Web.Models.TenantRegistration
{
    public class TenantRegisterViewModel
    {
        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public int? EditionId { get; set; }

        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }
    }
}

