using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace EduPlus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Event handler untuk Get Started button (optional)
        private void GetStartedButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Welcome to EduPlus! Let's get started with your learning journey.",
                "Get Started",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }

        // Event handler untuk navigation menu items (optional)
        private void NavigateToHome(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Navigating to Home...", "Navigation", MessageBoxButton.OK);
        }

        private void NavigateToDashboard(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Navigating to Dashboard...", "Navigation", MessageBoxButton.OK);
        }

        private void NavigateToAnnouncements(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Navigating to Announcements...", "Navigation", MessageBoxButton.OK);
        }

        // Event handler untuk Login/Register (optional)
        private void LoginRegister_Click(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Opening Login/Register page...", "Login/Register", MessageBoxButton.OK);
        }

        // Event handler untuk course card click (optional)
        private void CourseCard_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Border card = sender as Border;
            if (card != null)
            {
                MessageBox.Show("Opening course details...", "Course", MessageBoxButton.OK);
            }
        }

        // Event handler untuk announcement card click (optional)
        private void AnnouncementCard_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Border card = sender as Border;
            if (card != null)
            {
                MessageBox.Show("Opening announcement details...", "Announcement", MessageBoxButton.OK);
            }
        }

        // Hover effect untuk cards (optional - untuk visual feedback)
        private void Card_MouseEnter(object sender, MouseEventArgs e)
        {
            Border card = sender as Border;
            if (card != null)
            {
                card.Background = new SolidColorBrush(Color.FromRgb(248, 248, 248));
            }
        }

        private void Card_MouseLeave(object sender, MouseEventArgs e)
        {
            Border card = sender as Border;
            if (card != null)
            {
                card.Background = Brushes.White;
            }
        }
    }
}
