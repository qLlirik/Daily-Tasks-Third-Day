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
using System.Windows.Shapes;
using ThirdDay.DateBase;

namespace ThirdDay.Windows
{
    /// <summary>
    /// Логика взаимодействия для BindingEmployeesToProjectWindow.xaml
    /// </summary>
    public partial class BindingEmployeesToProjectWindow : Window
    {
        static Entity db = MainWindow.db;

        public BindingEmployeesToProjectWindow()
        {
            InitializeComponent();

            if (db.Projects.Where(w => w.Stop == null).ToList().Count == 0)
            {
                HelpClasses.Messages.ErrorMessage("Действующих проектов не найдено!");
            }
            else
            {
                cbxProjects.ItemsSource = db.Projects.Where(w => w.Stop == null).ToList();
                cbxProjects.DisplayMemberPath = "Name";
                cbxProjects.SelectedIndex = 0;
            }

            foreach (var i in db.Employees.ToList())
                lvOut.Items.Add(i);
            
        }

        private void click_Back(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void click_Add(object sender, RoutedEventArgs e)
        {
            lvIn.Items.Add((Employees)((Button)sender).DataContext);
            lvOut.Items.Remove((Employees)((Button)sender).DataContext);
        }

        private void click_Delete(object sender, RoutedEventArgs e)
        {
            lvOut.Items.Add((Employees)((Button)sender).DataContext);
            lvIn.Items.Remove((Employees)((Button)sender).DataContext);
        }

        private void click_Save(object sender, RoutedEventArgs e)
        {
            if ((lvIn.Items.Count == 0) || (cbxProjects.SelectedIndex == -1))
            {
                HelpClasses.Messages.ErrorMessage("Выберите необходимые данные!");
                return;
            }

            foreach(var i in lvIn.Items)
            {
                var empl = (Employees)i;
                db.EmployeesInProject.Add(new EmployeesInProject {
                    Projects = db.Projects.First(w=>w.ID == cbxProjects.SelectedIndex + 1),
                    Employees = empl,
                    EmployeeStart = DateTime.Now
                });
                db.SaveChanges();

                HelpClasses.Messages.OKMessage("Сотрудники привязаны к проекту!");
                this.Close();
            }
        }
    }
}
