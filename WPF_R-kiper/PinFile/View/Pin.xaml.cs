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
using System.Windows.Threading;
using WPF_R_kiper.TableFile;
using WPF_R_kiper.TableFile.View;
using Table = WPF_R_kiper.TableFile.View.Table;

namespace WPF_R_kiper.PinFile.View
{
    /// <summary>
    /// Interaction logic for Pin.xaml
    /// </summary>
    public partial class Pin : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        public Pin()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            timeLabel.Content = currentTime.ToString("HH:mm:ss");
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            passwordBox.Password = string.Empty;
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password.Length < 4)
            {
                Button button = sender as Button;
                passwordBox.Password += button.Content.ToString();
            }



        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password.Length < 4)
            {
                Button button = sender as Button;
                passwordBox.Password += button.Content.ToString();
            }

           
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {

            if (passwordBox.Password.Length < 4)
            {
                Button button = sender as Button;
                passwordBox.Password += button.Content.ToString();
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password.Length < 4)
            {
                Button button = sender as Button;
                passwordBox.Password += button.Content.ToString();
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password.Length < 4)
            {
                Button button = sender as Button;
                passwordBox.Password += button.Content.ToString();
            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password.Length < 4)
            {
                Button button = sender as Button;
                passwordBox.Password += button.Content.ToString();
            }
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password.Length < 4)
            {
                Button button = sender as Button;
                passwordBox.Password += button.Content.ToString();
            }
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password.Length < 4)
            {
                Button button = sender as Button;
                passwordBox.Password += button.Content.ToString();
            }
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password.Length < 4)
            {
                Button button = sender as Button;
                passwordBox.Password += button.Content.ToString();
            }
        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password.Length < 4)
            {
                Button button = sender as Button;
                passwordBox.Password += button.Content.ToString();
            }
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            string password = passwordBox.Password;
            if (password == "2004")
            {
                Table tableWindows = new Table();
                tableWindows.Show();
            }
            else
            {
                MessageBox.Show("PIN Yanlışdır");
            }


        }
    }
}
