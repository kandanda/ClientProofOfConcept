using Microsoft.Practices.Unity;
using Prism.Unity;
using MVVMApp.Views;
using System.Windows;

namespace MVVMApp
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }
    }
}
