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
    /// Логика взаимодействия для AddNewProjectWindow.xaml
    /// </summary>
    public partial class AddNewProjectWindow : Window
    {
        Entity db = MainWindow.db;

        public AddNewProjectWindow()
        {
            InitializeComponent();

            cbxCosumer.ItemsSource = db.Costumers.ToList();
            cbxCosumer.DisplayMemberPath = "Name";
            cbxCosumer.SelectedIndex = 0;
        }

        private void click_Back(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void click_Save(object sender, RoutedEventArgs e)
        {
            try
            {
                db.Projects.Add(new Projects {
                    Name = tbxName.Text,
                    Start = dpStart.SelectedDate.Value,
                    Costumers = db.Costumers.First(w => w.ID == cbxCosumer.SelectedIndex + 1),
                    Cost = decimal.Parse(tbxCost.Text),
                    BonusAll = int.Parse(tbxBonus.Text)
                });
                db.SaveChanges();

                HelpClasses.Messages.OKMessage("Добавление нового проекта прошло успешно!");
                this.Close();
            }
            catch
            {
                HelpClasses.Messages.ErrorMessage("Введите корректно данные!");
            }
        }

        private void click_AddNewCostumer(object sender, RoutedEventArgs e)
        {
            new AddNewCostumerWindow().Show();
            this.Close();
        }
    }
}
