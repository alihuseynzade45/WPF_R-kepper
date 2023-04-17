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
            ordersWindow.Left = 200;
            ordersWindow.Top = 170;
            checkWindow.Left = 1097;
            checkWindow.Top = 170;


            if (sender is Button button)
            {
                Border buttonBorder = (Border)button.Template.FindName("buttonBorder", button);
                if (buttonBorder != null)
                {
                    buttonBorder.BorderBrush = Brushes.Red;
                }
            }



            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "\t        Masa 1";
            thirdWindow.lbTable.Items.Add(item);


            WindowState = WindowState.Minimized;
           
        }

        private void Table2Btn_Click(object sender, RoutedEventArgs e)
        {
            Orders ordersWindow = new Orders();
            ordersWindow.Show();
            Check checkWindow = new Check();
            checkWindow.Show();
            ordersWindow.Left = 200;
            ordersWindow.Top = 170;
            checkWindow.Left = 1097;
            checkWindow.Top = 170;



            if (sender is Button button)
            {
                Border buttonBorder = (Border)button.Template.FindName("buttonBorder", button);
                if (buttonBorder != null)
                {
                    buttonBorder.BorderBrush = Brushes.Red;
                }
            }


            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "\t        Masa 2";
            thirdWindow.lbTable.Items.Add(item);
            WindowState = WindowState.Minimized;
        }

        private void Table3Btn_Click(object sender, RoutedEventArgs e)
        {
            Orders ordersWindow = new Orders();
            ordersWindow.Show();
            Check checkWindow = new Check();
            checkWindow.Show();
            ordersWindow.Left = 200;
            ordersWindow.Top = 170;
            checkWindow.Left = 1097;
            checkWindow.Top = 170;


            if (sender is Button button)
            {
                Border buttonBorder = (Border)button.Template.FindName("buttonBorder", button);
                if (buttonBorder != null)
                {
                    buttonBorder.BorderBrush = Brushes.Red;
                }
            }


            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "\t        Masa 3";
            thirdWindow.lbTable.Items.Add(item);
            WindowState = WindowState.Minimized;
        }

        private void Table4Btn_Click(object sender, RoutedEventArgs e)
        {
            Orders ordersWindow = new Orders();
            ordersWindow.Show();
            Check checkWindow = new Check();
            checkWindow.Show();
            ordersWindow.Left = 200;
            ordersWindow.Top = 170;
            checkWindow.Left = 1097;
            checkWindow.Top = 170;


            if (sender is Button button)
            {
                Border buttonBorder = (Border)button.Template.FindName("buttonBorder", button);
                if (buttonBorder != null)
                {
                    buttonBorder.BorderBrush = Brushes.Red;
                }
            }



            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "\t        Masa 4";
            thirdWindow.lbTable.Items.Add(item);
            WindowState = WindowState.Minimized;
        }

        private void Table5Btn_Click(object sender, RoutedEventArgs e)
        {
            Orders ordersWindow = new Orders();
            ordersWindow.Show();
            Check checkWindow = new Check();
            checkWindow.Show();
            ordersWindow.Left = 200;
            ordersWindow.Top = 170;
            checkWindow.Left = 1097;
            checkWindow.Top = 170;


            if (sender is Button button)
            {
                Border buttonBorder = (Border)button.Template.FindName("buttonBorder", button);
                if (buttonBorder != null)
                {
                    buttonBorder.BorderBrush = Brushes.Red;
                }
            }


            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "\t        Masa 5";
            thirdWindow.lbTable.Items.Add(item);
            WindowState = WindowState.Minimized;
        }

        private void Table6Btn_Click(object sender, RoutedEventArgs e)
        {
            Orders ordersWindow = new Orders();
            ordersWindow.Show();
            Check checkWindow = new Check();
            checkWindow.Show();
            ordersWindow.Left = 200;
            ordersWindow.Top = 170;
            checkWindow.Left = 1097;
            checkWindow.Top = 170;

            if (sender is Button button)
            {
                Border buttonBorder = (Border)button.Template.FindName("buttonBorder", button);
                if (buttonBorder != null)
                {
                    buttonBorder.BorderBrush = Brushes.Red;
                }
            }


            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "\t        Masa 6";
            thirdWindow.lbTable.Items.Add(item);
            WindowState = WindowState.Minimized;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = false;
        }
    }
}

