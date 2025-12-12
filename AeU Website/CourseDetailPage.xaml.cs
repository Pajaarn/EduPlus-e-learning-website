using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace EduPlus
{
    public partial class CourseDetailPage : Window
    {
        public CourseDetailPage()
        {
            InitializeComponent();
        }

        // Navigate to Lesson Detail (INI YANG KURANG)
        private void NavigateToLesson(object sender, MouseButtonEventArgs e)
        {
            LessonDetailPage lessonDetailPage = new LessonDetailPage();
            lessonDetailPage.Show();
            this.Close();
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

        // Tab Navigation - FIXED
        private void ShowLessons(object sender, MouseButtonEventArgs e)
        {
            // Show Lessons, Hide Assignment & Quiz
            LessonsSection.Visibility = Visibility.Visible;
            AssignmentSection.Visibility = Visibility.Collapsed;
            QuizSection.Visibility = Visibility.Collapsed;

            // Update Tab Background
            LessonsTab.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#6B7FD7"));
            AssignmentTab.Background = Brushes.Transparent;
            QuizTab.Background = Brushes.Transparent;

            // Update Text Color
            ((TextBlock)LessonsTab.Child).Foreground = Brushes.White;
            ((TextBlock)AssignmentTab.Child).Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#666666"));
            ((TextBlock)QuizTab.Child).Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#666666"));
        }

        private void ShowAssignment(object sender, MouseButtonEventArgs e)
        {
            // Show Assignment, Hide Lessons & Quiz
            LessonsSection.Visibility = Visibility.Collapsed;
            AssignmentSection.Visibility = Visibility.Visible;
            QuizSection.Visibility = Visibility.Collapsed;

            // Update Tab Background
            LessonsTab.Background = Brushes.Transparent;
            AssignmentTab.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#6B7FD7"));
            QuizTab.Background = Brushes.Transparent;

            // Update Text Color
            ((TextBlock)LessonsTab.Child).Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#666666"));
            ((TextBlock)AssignmentTab.Child).Foreground = Brushes.White;
            ((TextBlock)QuizTab.Child).Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#666666"));
        }

        private void ShowQuiz(object sender, MouseButtonEventArgs e)
        {
            // Show Quiz, Hide Lessons & Assignment
            LessonsSection.Visibility = Visibility.Collapsed;
            AssignmentSection.Visibility = Visibility.Collapsed;
            QuizSection.Visibility = Visibility.Visible;

            // Update Tab Background
            LessonsTab.Background = Brushes.Transparent;
            AssignmentTab.Background = Brushes.Transparent;
            QuizTab.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#6B7FD7"));

            // Update Text Color
            ((TextBlock)LessonsTab.Child).Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#666666"));
            ((TextBlock)AssignmentTab.Child).Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#666666"));
            ((TextBlock)QuizTab.Child).Foreground = Brushes.White;
        }

        // Navigation to Submit Assignment
        private void NavigateToSubmitAssignment(object sender, RoutedEventArgs e)
        {
            SubmitAssignmentPage submitAssignmentPage = new SubmitAssignmentPage();
            submitAssignmentPage.Show();
            this.Close();
        }

        private void NavigateToQuiz(object sender, RoutedEventArgs e)
        {
            QuizPage quizPage = new QuizPage();
            quizPage.Show();
            this.Close();
        }
    }
}
