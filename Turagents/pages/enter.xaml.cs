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

namespace Turagents.pages
{
    /// <summary>
    /// Логика взаимодействия для enter.xaml
    /// </summary>
    public partial class enter : Page
    {
        public enter()
        {
            InitializeComponent();
        }

        

        private void vhod(object sender, RoutedEventArgs e)
        {
            if (login.Text == "root" && password.Password == "12345")
            
            {
                classes.manager.MainFrame.Navigate(new admin());
            }
        }
    }
}
