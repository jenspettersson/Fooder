using System.Windows.Input;

namespace Fooder.ViewModels
{
    public interface IShellViewModel
    {
        ICommand SayHelloCommand { get; }

        string Message { get; set; }
    }
}