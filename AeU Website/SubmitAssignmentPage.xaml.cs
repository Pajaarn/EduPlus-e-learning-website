using System.Windows;
using System.Windows.Input;

namespace EduPlus
{
    public partial class SubmitAssignmentPage : Window
    {
        public SubmitAssignmentPage()
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

        // Back to Course Detail (Assignment Tab)
        private void BackToCourseDetail(object sender, MouseButtonEventArgs e)
        {
            CourseDetailPage courseDetailPage = new CourseDetailPage();
            courseDetailPage.Show();
            this.Close();
        }
    }
}
