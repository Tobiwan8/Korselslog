using Kørselslog.Repos;

namespace Kørselslog.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        public RelayCommand CreateUserViewCommand { get; set; }
        public RelayCommand EditUserViewCommand { get; set; }
        public RelayCommand CreateCarViewCommand { get; set; }
        public RelayCommand EditCarViewCommand { get; set; }
        public RelayCommand DataUserViewCommand { get; set; }
        public RelayCommand DataCarViewCommand { get; set; }
        public RelayCommand EditUserCompleteViewCommand { get; set; }

        public CreateUserViewModel CreateUserVM { get; set; }
        public EditUserViewModel EditUserVM { get; set; }
        public CreateCarViewModel CreateCarVM { get; set; }
        public EditCarViewModel EditCarVM { get; set; }
        public DataUserViewModel DataUserVM { get; set; }
        public DataCarViewModel DataCarVM { get; set; }
        public EditUserCompleteViewModel EditUserCompleteVM { get; set; }

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
            CreateCarVM = new CreateCarViewModel();
            EditCarVM = new EditCarViewModel();
            DataUserVM = new DataUserViewModel();
            DataCarVM = new DataCarViewModel();
            EditUserCompleteVM = new EditUserCompleteViewModel();

            CreateUserViewCommand = new RelayCommand(o =>
            {
                CurrentView = CreateUserVM;
            });

            EditUserViewCommand = new RelayCommand(o =>
            {
                CurrentView = EditUserVM;
            });

            CreateCarViewCommand = new RelayCommand(o =>
            {
                CurrentView = CreateCarVM;
            });

            EditCarViewCommand = new RelayCommand(o =>
            {
                CurrentView = EditCarVM;
            });

            DataUserViewCommand = new RelayCommand(o =>
            {
                CurrentView = DataUserVM;
            });

            DataCarViewCommand = new RelayCommand(o =>
            {
                CurrentView = DataCarVM;
            });

            EditUserCompleteViewCommand = new RelayCommand(o =>
            {
                CurrentView = EditUserCompleteVM;
            });
        }
    }
}