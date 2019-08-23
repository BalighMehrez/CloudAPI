using System.Threading.Tasks;
using Dataocean.Venus.Views;
using Xamarin.Forms;

namespace Dataocean.Venus.Services.Modal
{
    public interface IModalService
    {
        Task ShowModalAsync(Page page);

        Task ShowModalAsync<TView>(object navigationParameter) where TView : IXamarinView;

        Task<Page> CloseModalAsync();
    }
}

