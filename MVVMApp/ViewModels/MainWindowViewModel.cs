using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using Prism.Interactivity.InteractionRequest;
using Prism.Mvvm;

namespace MVVMApp.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public ICommand LaunchWebsiteCommand { get; set; }
        public ICommand SaveContactCommand { get; set; }
        public InteractionRequest<INotification> NotificationRequest { get; set; }

        public MainWindowViewModel()
        {
            LaunchWebsiteCommand = new DelegateCommand(LaunchWebsite, () => !IsBusy).ObservesProperty(() => IsBusy);
            SaveContactCommand = new DelegateCommand(SaveContact,() => !IsBusy).ObservesProperty(() => IsBusy);
            NotificationRequest = new InteractionRequest<INotification>();
        }

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                SetProperty(ref _name, value);
                OnPropertyChanged(() => DisplayMessage);
            }
        }

        public bool IsBestFriend
        {
            get { return _isBestFriend; }
            set
            {
                SetProperty(ref _isBestFriend, value);
                OnPropertyChanged(() => DisplayMessage);
            }
        }

        public string Website
        {
            get { return _website; }
            set { SetProperty(ref _website, value); }
        }

        public string DisplayMessage => $"Your new friend is named {Name} and " +
                                        $"{(IsBestFriend ? "is" : "is not")} your best friend.";

        public bool IsBusy
        {
            get { return _isBusy; }
            set { SetProperty(ref _isBusy, value); }
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
            NotificationRequest.Raise(new Notification {Title = "Succcessful Save", Content = "Contact was saved"});
        }
        
        private string _title = "Add Contact";
        private string _name = "Victor Ruch";
        private bool _isBestFriend = true;
        private string _website = "https://viru.ch";
        private bool _isBusy;
    }
}
