using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace EduPlus
{
    public partial class LoginPage : Window
    {
        private bool isPasswordVisible = false;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            string email = EmailTextBox.Text.Trim();
            string password = PasswordBox.Password;

            // Basic validation
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email.", "Validation Error",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your password.", "Validation Error",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // TODO: Add authentication logic here
            // For now, just navigate to MainWindow
            MessageBox.Show("Login successful!", "Success",
                MessageBoxButton.OK, MessageBoxImage.Information);

            // Navigate to MainWindow
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void TogglePassword_Click(object sender, MouseButtonEventArgs e)
        {
            if (isPasswordVisible)
            {
                // Hide password
                PasswordBox.Password = PasswordTextBox.Text;
                PasswordBox.Visibility = Visibility.Visible;
                PasswordTextBox.Visibility = Visibility.Collapsed;
                PasswordToggleIcon.Text = "👁";
                isPasswordVisible = false;
            }
            else
            {
                // Show password
                PasswordTextBox.Text = PasswordBox.Password;
                PasswordBox.Visibility = Visibility.Collapsed;
                PasswordTextBox.Visibility = Visibility.Visible;
                PasswordToggleIcon.Text = "👁‍🗨";
                isPasswordVisible = true;
            }
        }

        private void ForgotPassword_Click(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Password reset feature coming soon!", "Info",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        
    }
}
