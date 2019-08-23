using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Dataocean.Venus.MultiTenancy.Accounting.Dto;

namespace Dataocean.Venus.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}

