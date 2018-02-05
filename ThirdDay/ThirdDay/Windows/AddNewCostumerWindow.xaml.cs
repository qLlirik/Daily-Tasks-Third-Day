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
    /// Логика взаимодействия для AddNewCostumerWindow.xaml
    /// </summary>
    public partial class AddNewCostumerWindow : Window
    {
        Entity db = MainWindow.db;

        public AddNewCostumerWindow()
        {
            InitializeComponent();
        }

        private void click_Back(object sender, RoutedEventArgs e)
        {
            new AddNewProjectWindow().Show();
            this.Close();
        }

        private void click_AddNewCostumer(object sender, RoutedEventArgs e)
        {
            if ((tbxName.Text.Length == 0) && (tbxPhone.Text.Length == 0) && (tbxBank.Text.Length == 0) && (tbxAccount.Text.Length == 0) && (tbxINN.Text.Length == 0) && (tbxAddress.Text.Length == 0) && (tbxFioWorker.Text.Length == 0) && (tbxPhone.Text.Length == 0))
            {
                HelpClasses.Messages.ErrorMessage("Введите данные!");
                return;
            }
                db.Costumers.Add(new Costumers {
                    Name = tbxName.Text,
                    Phone = tbxPhone.Text,
                    Bank = tbxBank.Text,
                    Account = tbxAccount.Text,
                    INN = tbxINN.Text,
                    Address = tbxAddress.Text,
                    FioWorker = tbxFioWorker.Text,
                    PhoneWorker = tbxPnoneWorker.Text
                });

                db.SaveChanges();

                HelpClasses.Messages.OKMessage("Добавление нового заказчика прошла успешно!");
                this.Close();
                new AddNewProjectWindow().Show();
        }
    }
}
