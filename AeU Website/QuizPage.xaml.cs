using System.Windows;
using System.Windows.Input;

namespace EduPlus
{
    public partial class QuizPage : Window
    {
        public QuizPage()
        {
            InitializeComponent();
        }

        private void NavigateToDashboard(object sender, MouseButtonEventArgs e)
        {
            DashboardPage dashboardPage = new DashboardPage();
            dashboardPage.Show();
            this.Close();
        }

        private void NavigateToHome(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void NavigateToMyCourses(object sender, MouseButtonEventArgs e)
        {
            MyCoursesPage myCoursesPage = new MyCoursesPage();
            myCoursesPage.Show();
            this.Close();
        }

        private void BackToCourseDetail(object sender, MouseButtonEventArgs e)
        {
            CourseDetailPage courseDetailPage = new CourseDetailPage();
            courseDetailPage.Show();
            this.Close();
        }

        private void EndQuizButton_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to end this quiz? Your answers will be submitted.",
                "End Quiz",
                MessageBoxButton.YesNo,
                MessageBoxImage.Warning
            );

            if (result == MessageBoxResult.Yes)
            {
                CourseDetailPage courseDetail = new CourseDetailPage();
                courseDetail.Show();
                this.Close();
            }
        }
    }
}
