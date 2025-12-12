using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EduPlus
{
    public partial class MyCoursesPage : Window
    {
        public MyCoursesPage()
        {
            InitializeComponent();
        }

        private void NavigateToHome(object sender, MouseButtonEventArgs e)
        {
            MainWindow home = new MainWindow();
            home.Show();
            this.Close();
        }

        private void NavigateToDashboard(object sender, MouseButtonEventArgs e)
        {
            DashboardPage dashboard = new DashboardPage();
            dashboard.Show();
            this.Close();
        }

        private void NavigateToCourseDetail(object sender, MouseButtonEventArgs e)
        {
            CourseDetailPage courseDetailPage = new CourseDetailPage();
            courseDetailPage.Show();
            this.Close();
        }
    }
}
