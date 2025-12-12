using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace EduPlus
{
    public partial class LessonDetailPage : Window
    {
        public LessonDetailPage()
        {
            InitializeComponent();
        }

        // Tab switching logic
        private void OverviewTab_Click(object sender, RoutedEventArgs e)
        {
            SetActiveTab(OverviewTab, OverviewContent);
        }

        private void MaterialsTab_Click(object sender, RoutedEventArgs e)
        {
            SetActiveTab(MaterialsTab, MaterialsContent);
        }

        private void DiscussionTab_Click(object sender, RoutedEventArgs e)
        {
            SetActiveTab(DiscussionTab, DiscussionContent);
        }

        private void SetActiveTab(Button activeButton, StackPanel activeContent)
        {
            // Reset all tabs
            OverviewTab.Background = new SolidColorBrush(Color.FromRgb(224, 224, 224));
            OverviewTab.Foreground = new SolidColorBrush(Color.FromRgb(102, 102, 102));
            MaterialsTab.Background = new SolidColorBrush(Color.FromRgb(224, 224, 224));
            MaterialsTab.Foreground = new SolidColorBrush(Color.FromRgb(102, 102, 102));
            DiscussionTab.Background = new SolidColorBrush(Color.FromRgb(224, 224, 224));
            DiscussionTab.Foreground = new SolidColorBrush(Color.FromRgb(102, 102, 102));

            OverviewContent.Visibility = Visibility.Collapsed;
            MaterialsContent.Visibility = Visibility.Collapsed;
            DiscussionContent.Visibility = Visibility.Collapsed;

            // Set active tab
            activeButton.Background = FindResource("AccentBlue") as SolidColorBrush;
            activeButton.Foreground = Brushes.White;
            activeContent.Visibility = Visibility.Visible;
        }

        // End Lesson button
        private void EndLessonButton_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to end this lesson? Your progress will be saved.",
                "End Lesson",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question
            );

            if (result == MessageBoxResult.Yes)
            {
                // Navigate back to course detail
                CourseDetailPage courseDetail = new CourseDetailPage();
                courseDetail.Show();
                this.Close();
            }
        }

        // Navigation handlers
        private void BackToCourse(object sender, MouseButtonEventArgs e)
        {
            CourseDetailPage courseDetail = new CourseDetailPage();
            courseDetail.Show();
            this.Close();
        }

        private void NavigateToDashboard(object sender, MouseButtonEventArgs e)
        {
            // new Dashboard().Show();
            this.Close();
        }

        private void NavigateToHome(object sender, MouseButtonEventArgs e)
        {
            MainWindow home = new MainWindow();
            home.Show();
            this.Close();
        }

        private void NavigateToMyCourses(object sender, MouseButtonEventArgs e)
        {
            // new MyCoursesPage().Show();
            this.Close();
        }
    }
}
