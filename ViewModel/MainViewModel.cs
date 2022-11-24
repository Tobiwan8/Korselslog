using Kørselslog.Repos;

namespace Kørselslog.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        public CreateUserViewModel CreateUserVM { get; set; }

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
            CurrentView = CreateUserVM;
        }
    }
}