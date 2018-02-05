using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ThirdDay.DateBase;

namespace ThirdDay
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static public Entity db = new Entity();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void click_AddNewEmployees(object sender, RoutedEventArgs e)
        {
            new Windows.AddNewEmployeeWindow().Show();
        }

        private void click_AddNewProject(object sender, RoutedEventArgs e)
        {
            new Windows.AddNewProjectWindow().Show();
        }

        private void click_BindingEmployeesToProject(object sender, RoutedEventArgs e)
        {
            new Windows.BindingEmployeesToProjectWindow().Show();
        }

        private void click_EndProject(object sender, RoutedEventArgs e)
        {
            new Windows.EndProjectWindow().Show();
        }
    }
}
