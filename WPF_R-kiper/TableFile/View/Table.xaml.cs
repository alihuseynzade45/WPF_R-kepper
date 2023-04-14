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
using WPF_R_kiper.CheckFile.View;
using WPF_R_kiper.OrdersFile.View;
using WPF_R_kiper.TableFile.View;

namespace WPF_R_kiper.TableFile.View
{
    /// <summary>
    /// Interaction logic for Table.xaml
    /// </summary>
    public partial class Table : Window
    {
        public Table()
        {
            InitializeComponent();
        }

        private void Table1Btn_Click(object sender, RoutedEventArgs e)
        {
            Orders ordersWindow = new Orders();
            ordersWindow.Show();
            Check checkWindow = new Check();
            checkWindow.Show();
       

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

        private void Table2Btn_Click(object sender, RoutedEventArgs e)
        {
            Orders ordersWindow = new Orders();
            ordersWindow.Show();
            Check checkWindow = new Check();
            checkWindow.Show();

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

        private void Table3Btn_Click(object sender, RoutedEventArgs e)
        {
            Orders ordersWindow = new Orders();
            ordersWindow.Show();
            Check checkWindow = new Check();
            checkWindow.Show();

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

        private void Table4Btn_Click(object sender, RoutedEventArgs e)
        {
            Orders ordersWindow = new Orders();
            ordersWindow.Show();
            Check checkWindow = new Check();
            checkWindow.Show();

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

        private void Table5Btn_Click(object sender, RoutedEventArgs e)
        {
            Orders ordersWindow = new Orders();
            ordersWindow.Show();
            Check checkWindow = new Check();
            checkWindow.Show();

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

        private void Table6Btn_Click(object sender, RoutedEventArgs e)
        {
            Orders ordersWindow = new Orders();
            ordersWindow.Show();
            Check checkWindow = new Check();
            checkWindow.Show();

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

