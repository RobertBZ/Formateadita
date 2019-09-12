using ExceptionCore;
using ExceptionCore.Critical;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace ProjectInit
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Dispatcher.UnhandledException += OnThrowedException;
        }
        private void OnThrowedException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            AbstractException catched;
            if ( e.Exception is AbstractException)
            {
                catched = e.Exception as AbstractException;
            }
            else
            {
                catched = new CriticalException(e.Exception);
            }
            MessageBox.Show(catched.FriendlyMessage, "MyProject", MessageBoxButton.OK, MessageBoxImage.Error);
            catched.LogException();
            e.Handled = true;
        }
    }
}
