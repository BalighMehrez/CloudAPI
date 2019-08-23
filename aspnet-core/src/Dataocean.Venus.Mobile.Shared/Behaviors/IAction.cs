using Xamarin.Forms.Internals;

namespace Dataocean.Venus.Behaviors
{
    [Preserve(AllMembers = true)]
    public interface IAction
    {
        bool Execute(object sender, object parameter);
    }
}
