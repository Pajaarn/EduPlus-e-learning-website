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
        private void GetStarted_Click(object sender, RoutedEventArgs e)
        {
            DashboardPage dashboard = new DashboardPage();
            dashboard.Show();
            this.Close();
        }

        // Event handler untuk navigation menu items (optional)
        private void NavigateToHome(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Navigating to Home...", "Navigation", MessageBoxButton.OK);
        }

        private void NavigateToDashboard(object sender, MouseButtonEventArgs e)
        {
            DashboardPage dashboard = new DashboardPage();
            dashboard.Show();
            this.Close();
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

        private void NavigateToDashboardPage()
        {
            // Buat instance DashboardPage baru
            DashboardPage dashboardPage = new DashboardPage();

            // Show dashboard
            dashboardPage.Show();

            // Close current MainWindow
            this.Close();
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
