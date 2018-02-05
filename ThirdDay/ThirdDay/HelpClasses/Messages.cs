using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ThirdDay.HelpClasses
{
    class Messages
    {

        static public void ErrorMessage(string error)
        {
            MessageBox.Show(error, "Error",MessageBoxButton.OK,MessageBoxImage.Error);
        }

        static public void OKMessage(string error)
        {
            MessageBox.Show(error, "Perfect", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
