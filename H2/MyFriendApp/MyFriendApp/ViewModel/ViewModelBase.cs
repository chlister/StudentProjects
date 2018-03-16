using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.UI.Core;
using Windows.UI.Xaml;

public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        private static CoreDispatcher dispatcher = Window.Current.Dispatcher;

        protected async virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            await Windows.ApplicationModel.Core.CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal,
     () =>
     {
         PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
     });
        }
    }