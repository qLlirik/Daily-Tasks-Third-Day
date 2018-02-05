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
    /// Логика взаимодействия для EndProjectWindow.xaml
    /// </summary>
    public partial class EndProjectWindow : Window
    {
        Entity db = MainWindow.db;

        public EndProjectWindow()
        {
            InitializeComponent();

            cbxProjects.ItemsSource = db.Projects.Where(w => w.Stop == null).ToList();
            cbxProjects.DisplayMemberPath = "Name";
            cbxProjects.SelectedIndex = 0;
        }

        private void click_Back(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void click_Finishing(object sender, RoutedEventArgs e)
        {
            try
            {
                var proj = (Projects)cbxProjects.SelectedItem;
                proj.Stop = DateTime.Now;

                foreach (var i in db.EmployeesInProject.Where(w => w.ProjectID == proj.ID))
                    i.EmployeeStop = DateTime.Now;

                db.SaveChanges();

                HelpClasses.Messages.OKMessage("Проект завершён!");
                this.Close();
            }
            catch
            {
                HelpClasses.Messages.ErrorMessage("Выберите проект!");
            }
        }
    }
}
