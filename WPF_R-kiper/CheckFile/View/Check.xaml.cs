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


namespace WPF_R_kiper.CheckFile.View
{
    /// <summary>
    /// Interaction logic for Check.xaml
    /// </summary>
    public partial class Check : Window
    {


        public Check()
        {
            InitializeComponent();

        }

        private void TotalBtn_Click(object sender, RoutedEventArgs e)
        {
            //ListBoxItem newItem = new ListBoxItem();

            //// Öğe metnini ayarla
            //newItem.Content = "Corba | 25TL";

            //// ListBox'a öğe ekle
            //lbCheck.Items.Add(newItem);

            //===============================================================


            //// Tüm düğmelerin içeriğini topla
            //int sum = int.Parse(sorba.Content.ToString()) +
            //          int.Parse(kebab.Content.ToString());


            //// Öğe metnini ayarla
            //string itemText = $"{sum}";

            //// ListBox'a öğe ekle
            //lbCheck.Items.Add(itemText);
            //===============================================================

            //int total = 0;
            //foreach (string item in lbCheck.Items)
            //{
            //    int price = int.Parse(item.Split('|')[1].Trim().Replace("AZN", ""));
            //    total += price;
            //}
            //lbTotal.Items.Add($"Toplam: {total} AZN");

            int total = 0;
            foreach (object item in lbCheck.Items)
            {
                ListBoxItem listBoxItem = (ListBoxItem)item;
                string content = listBoxItem.Content as string;
                if (content != null)
                {
                    string[] parts = content.Split('|');
                    if (parts.Length > 1 && int.TryParse(parts[1].Trim().Replace("AZN", ""), out int price))
                    {
                        total += price;
                    }
                }
            }
            lbTotal.Items.Add($"Toplam: {total} AZN");


        }

    }
}
