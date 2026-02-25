using MVVMLoginApp.ViewModels;
using System.Windows.Controls;

namespace MVVMLoginApp.Views
{
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();

            // When the password changes, push it to the ViewModel
            PasswordInput.PasswordChanged += (s, e) =>
            {
                if (DataContext is LoginViewModel vm)
                    vm.Password = PasswordInput.Password;
            };
        }
    }
}