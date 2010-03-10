using System;
using Caliburn.PresentationFramework;
using Caliburn.PresentationFramework.ApplicationModel;
using Fooder.Client.Infrastructure;
using Fooder.Client.ViewModels.Interfaces;
using Microsoft.Practices.ServiceLocation;

namespace Fooder.Client.ViewModels
{
    public class ShellViewModel : Navigator, IShellViewModel
    {
        private IPresenter _menuPresenter;

        private readonly IServiceLocator _serviceLocator;

        public ShellViewModel(IServiceLocator serviceLocator)
        {
            _serviceLocator = serviceLocator;
        }

        public override void Initialize()
        {
            base.Initialize();
            if(_menuPresenter != null)
                _menuPresenter.Initialize();

            IsInitialized = true;

        }

        public void Open<T>() where T : IPresenter
        {
            var presenter = _serviceLocator.GetInstance<T>();
            this.Open(presenter);
        }

        public void ShowDialog<T>(T presenter) where T : IPresenter, ILifecycleNotifier
        {
            throw new NotImplementedException();
        }

        protected override void OnActivate()
        {
            base.OnActivate();

            _menuPresenter = _serviceLocator.GetInstance<IMenuViewModel>();

            Open<IHomeViewModel>();
        }

        public virtual IPresenter MenuPresenter
        {
            get { return _menuPresenter; }
            set
            {
                if (value != null && value.Equals(_menuPresenter))
                    return;

                ShutdownCurrent(
                    isShutdownSuccess =>
                    {
                        if (isShutdownSuccess)
                        {
                            Open(
                                value,
                                isOpenSuccess =>
                                {
                                    NotifyOfPropertyChange("CurrentPresenter");
                                });
                        }
                        else
                        {
                            NotifyOfPropertyChange("CurrentPresenter");
                        }
                    });
            }
        }

    }
}