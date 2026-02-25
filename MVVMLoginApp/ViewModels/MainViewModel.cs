using MVVMLoginApp.Models;

namespace MVVMLoginApp.ViewModels
{
    // MainViewModel controls which page is currently shown.
    // MainWindow binds its ContentControl to CurrentView.
    public class MainViewModel : BaseViewModel
    {
        private readonly AuthService _authService;

        private BaseViewModel? _currentView;
        public BaseViewModel? CurrentView
        {
            get => _currentView;
            set => SetProperty(ref _currentView, value);
        }

        public MainViewModel()
        {
            _authService = new AuthService();

            // Start on the Login page
            NavigateToLogin();
        }

        private void NavigateToLogin()
        {
            CurrentView = new LoginViewModel(_authService, OnLoginSuccess);
        }

        private void OnLoginSuccess(User user)
        {
            // Switch to Dashboard when login succeeds
            CurrentView = new DashboardViewModel(user, NavigateToLogin);
        }
    }
}