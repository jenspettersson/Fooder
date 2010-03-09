using Caliburn.PresentationFramework.ApplicationModel;

namespace Fooder.Client.ViewModels.Interfaces
{
    public interface IShellViewModel : INavigator
    {
        void Open<T>() where T : IPresenter;
        void ShowDialog<T>(T presenter) where T : IPresenter, ILifecycleNotifier;
    }
}