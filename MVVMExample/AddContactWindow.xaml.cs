using System.Windows;
using MVVMExample.ViewModels;

namespace MVVMExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class AddContactWindow : Window
    {
        public AddContactWindow()
        {
            InitializeComponent();
            DataContext = new AddContactViewModel();
        }
    }
}
