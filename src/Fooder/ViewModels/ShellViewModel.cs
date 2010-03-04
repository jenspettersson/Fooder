using System;
using System.Windows.Input;
using Caliburn.Core;

namespace Fooder.ViewModels
{
    public class ShellViewModel : PropertyChangedBase, IShellViewModel
    {
        private ICommand _sayHelloCommand;
        private string _message;

        public ICommand SayHelloCommand
        {
            get
            {
                if (_sayHelloCommand == null)
                    _sayHelloCommand = new DelegateCommand(SayHello);

                return _sayHelloCommand;
            }
        }

        private void SayHello(object obj)
        {
            Message = "Let's feed on Caliburn!";
            
        }

        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                NotifyOfPropertyChange("Message");
            }
        }
    }

    public class DelegateCommand : ICommand
    {
        private readonly Predicate<object> _canExecute;
        private readonly Action<object> _execute;

        public event EventHandler CanExecuteChanged;

        public DelegateCommand(Action<object> execute)
            : this(execute, null)
        {
        }

        public DelegateCommand(Action<object> execute,
                       Predicate<object> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            if (_canExecute == null)
            {
                return true;
            }

            return _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        public void RaiseCanExecuteChanged()
        {
            if (CanExecuteChanged != null)
            {
                CanExecuteChanged(this, EventArgs.Empty);
            }
        }
    }

}