using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MVVMExample.Annotations;

namespace MVVMExample.ViewModels
{
    public class AddContactViewModel: INotifyPropertyChanged
    {
        public AddContactViewModel()
        {
            LaunchWebsiteCommand = new Command(LaunchWebsite, () => !IsBusy);
            SaveContactCommand = new Command(SaveContact, () => !IsBusy);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        /* 
         * Command does not exist in WPF Framework I copied the implementation from Xamarin.Forms. 
         */
        public Command LaunchWebsiteCommand { get; }
        public Command SaveContactCommand { get; }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(DisplayMessage));
            }
        }

        public bool IsBestFriend
        {
            get { return _isBestFriend; }
            set
            {
                _isBestFriend = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(DisplayMessage));
            }
        }

        public string Website
        {
            get { return _website; }
            set
            {
                _website = value;
                OnPropertyChanged();
            }
        }

        public string DisplayMessage => $"Your new friend is named {Name} and " +
                                        $"{(IsBestFriend ? "is": "is not")} your best friend.";

        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value; 
                OnPropertyChanged();
                LaunchWebsiteCommand.ChangeCanExecute();
                SaveContactCommand.ChangeCanExecute();
            }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private void LaunchWebsite()
        {
            /* Ugly the View Model should be independent from the system */
            System.Diagnostics.Process.Start(Website);
        }

        private async void SaveContact()
        {
            IsBusy = true;
            await Task.Delay(4000);
            IsBusy = false;
            /* Ugly the View Model should be independent from the system */
            System.Windows.MessageBox.Show("User Saved");
        }

        private string _name = "Victor Ruch";
        private bool _isBestFriend = true;
        private string _website = "https://viru.ch";
        private bool _isBusy;
    }
}
