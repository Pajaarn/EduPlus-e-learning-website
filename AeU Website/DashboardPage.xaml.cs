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
    public partial class DashboardPage : Window
    {
        public DashboardPage()
        {
            InitializeComponent();
        }

        private void NavigateToHome(object sender, MouseButtonEventArgs e)
        {
            MainWindow home = new MainWindow();
            home.Show();
            this.Close();
        }
        private void NavigateToMyCourses(object sender, MouseButtonEventArgs e)
        {
            MyCoursesPage myCoursesPage = new MyCoursesPage();
            myCoursesPage.Show();
            this.Close();
        }
    }
}

