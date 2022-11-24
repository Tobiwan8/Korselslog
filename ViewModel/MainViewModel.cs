using Kørselslog.Repos;

namespace Kørselslog.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        public RelayCommand CreateUserViewCommand { get; set; }
        public RelayCommand EditUserViewCommand { get; set; }

        public CreateUserViewModel CreateUserVM { get; set; }
        public EditUserViewModel EditUserVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            CreateUserVM = new CreateUserViewModel();
            EditUserVM = new EditUserViewModel();

            CurrentView = CreateUserVM;

            CreateUserViewCommand = new RelayCommand(o =>
            {
                CurrentView = CreateUserVM;
            });

            EditUserViewCommand = new RelayCommand(o =>
            {
                CurrentView = EditUserVM;
            });
        }
    }
}