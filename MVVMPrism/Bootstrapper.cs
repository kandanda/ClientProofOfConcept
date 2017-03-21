using Microsoft.Practices.Unity;
using Prism.Unity;
using MVVMPrism.Views;
using System.Windows;

namespace MVVMPrism
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
