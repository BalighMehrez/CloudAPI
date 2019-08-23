using Abp.AutoMapper;
using Dataocean.Venus.Editions;
using Dataocean.Venus.MultiTenancy.Payments.Dto;

namespace Dataocean.Venus.Web.Areas.AppAreaName.Models.SubscriptionManagement
{
    [AutoMapTo(typeof(ExecutePaymentDto))]
    public class PaymentResultViewModel : SubscriptionPaymentDto
    {
        public EditionPaymentType EditionPaymentType { get; set; }
    }
}
