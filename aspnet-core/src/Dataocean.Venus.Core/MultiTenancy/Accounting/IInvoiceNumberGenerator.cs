using System.Threading.Tasks;
using Abp.Dependency;

namespace Dataocean.Venus.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}
