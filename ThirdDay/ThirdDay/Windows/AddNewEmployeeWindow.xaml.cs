using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для AddNewEmployeeWindow.xaml
    /// </summary>
    public partial class AddNewEmployeeWindow : Window
    {
        Entity db = MainWindow.db;

        public AddNewEmployeeWindow()
        {
            InitializeComponent();

            cbxDistrict.ItemsSource = db.Districts.ToList();
            cbxDistrict.DisplayMemberPath = "Name";
            cbxDistrict.SelectedIndex = 0;

            cbxLanguage.ItemsSource = db.Languages.ToList();
            cbxLanguage.DisplayMemberPath = "Name";
            cbxLanguage.SelectedIndex = 0;
        }

        private void click_Back(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void click_SelectImage(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Images|*.png;*.bmp;*.jpg";
            if (ofd.ShowDialog() == true)
                tbxImage.Text = ofd.FileName;
        }

        private void click_Save(object sender, RoutedEventArgs e)
        {
            try
            {
                db.Employees.Add(new Employees {
                    Name = tbxName.Text,
                    Address = tbxAddress.Text,
                    Districts = db.Districts.First(w=>w.ID == cbxDistrict.SelectedIndex + 1),
                    Experience = byte.Parse(tbxExperience.Text),
                    Year = short.Parse(tbxYear.Text),
                    Languages = db.Languages.First(w=>w.ID == cbxLanguage.SelectedIndex + 1),
                    Base = tbxBase.Text,
                    Salary = decimal.Parse(tbxSalary.Text),
                    Bonus = decimal.Parse(tbxBonus.Text),
                    GrossSalary = decimal.Parse(tbxSalary.Text) + decimal.Parse(tbxBonus.Text),
                    Exempt = decimal.Parse(tbxExempt.Text),
                    Picture = ImageToBute(tbxImage.Text)
                });
                db.SaveChanges();

                HelpClasses.Messages.OKMessage("Регистрация нового сотрудника прошла успешно!");
                this.Close();
            }
            catch 
            {
                HelpClasses.Messages.ErrorMessage("Введите корректные данные!");
            }
        }

        private byte[] ImageToBute(string uri)
        {
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(new BitmapImage(new Uri(uri, UriKind.Absolute))));
            MemoryStream ms = new MemoryStream();
            encoder.Save(ms);
            return ms.ToArray();
        }
    }
}
