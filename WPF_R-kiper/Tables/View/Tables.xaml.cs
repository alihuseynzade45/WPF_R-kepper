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
using WPF_R_kiper.OrdersFile.View;

namespace WPF_R_kiper.View
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {

            Orders ordersWindow = new Orders();
            ordersWindow.Show();
            //OrdersFile ordersWindow = new OrdersFile();
            //ordersWindow.Show();

            if (sender is Button button)
            {
                Border buttonBorder = (Border)button.Template.FindName("buttonBorder", button);
                if (buttonBorder != null)
                {
                    buttonBorder.BorderBrush = Brushes.Red;
                }
            }
        }

    }
}
