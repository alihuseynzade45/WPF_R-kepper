using System;
using System.Collections;
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
using WPF_R_kiper.CheckFile;
using WPF_R_kiper.CheckFile.View;


namespace WPF_R_kiper.OrdersFile.View
{
    /// <summary>
    /// Interaction logic for Orders.xaml
    /// </summary>
    public partial class Orders : Window
    {

        public Orders()
        {
            InitializeComponent();
        }



        private void KotletBtn_Click(object sender, RoutedEventArgs e)
        {
            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "ƏT KOTLETLƏRİ | 9 AZN";
            thirdWindow.lbCheck.Items.Add(item);

            thirdWindow.Activate();
        }

        private void TavakabakiBtn_Click(object sender, RoutedEventArgs e)
        {
            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "TAVA KABABI (İKİ NƏFƏRLİK) | 14 AZN";
            thirdWindow.lbCheck.Items.Add(item);

            thirdWindow.Activate();
        }

        private void QuzusoganetBtn_Click(object sender, RoutedEventArgs e)
        {
            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "QUZU SOĞAN İLƏ ƏT SOUSUNDA | 18 AZN";
            thirdWindow.lbCheck.Items.Add(item);

            thirdWindow.Activate();
        }

        private void QuzubaldiriqovurmaBtn_Click(object sender, RoutedEventArgs e)
        {
            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "QUZU BALDIR QOVURMASI | 18 AZN";
            thirdWindow.lbCheck.Items.Add(item);

            thirdWindow.Activate();
        }

        private void FettuciniBtn_Click(object sender, RoutedEventArgs e)
        {
            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "FETTUÇİNİ TOYUQ İLƏ XAMALI-ƏTLİ SOUSDA | 12 AZN";
            thirdWindow.lbCheck.Items.Add(item);

            thirdWindow.Activate();
        }

        private void DanabastirmaBtn_Click(object sender, RoutedEventArgs e)
        {
            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "DANA BASDIRMASI | 12 AZN";
            thirdWindow.lbCheck.Items.Add(item);

            thirdWindow.Activate();
        }

        private void XankebabiBtn_Click(object sender, RoutedEventArgs e)
        {
            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "XAN KABABI | 7 AZN";
            thirdWindow.lbCheck.Items.Add(item);

            thirdWindow.Activate();
        }
        
        private void LulekebabBtn_Click(object sender, RoutedEventArgs e)
        {
            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "LÜLƏ KABAB | 7 AZN";
            thirdWindow.lbCheck.Items.Add(item);

            thirdWindow.Activate();
        }

        private void QuzuantrikorBtn_Click(object sender, RoutedEventArgs e)
        {
            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "QUZU ANTREKOTU | 9 AZN";
            thirdWindow.lbCheck.Items.Add(item);

            thirdWindow.Activate();
        }

        private void QuzukebabiBtn_Click(object sender, RoutedEventArgs e)
        {
            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "QUZU KABABI | 7 AZN";
            thirdWindow.lbCheck.Items.Add(item);

            thirdWindow.Activate();
        }

        private void ToyuqlulesiBtn_Click(object sender, RoutedEventArgs e)
        {
            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "TOYUQ LÜLƏSİ | 7 AZN";
            thirdWindow.lbCheck.Items.Add(item);

            thirdWindow.Activate();
        }

        private void DusbereBtn_Click(object sender, RoutedEventArgs e)
        {
            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "DÜŞBƏRƏ | 5 AZN";
            thirdWindow.lbCheck.Items.Add(item);

            thirdWindow.Activate();
        }






        private void GobeleksorbasiBtn_Click(object sender, RoutedEventArgs e)
        {
            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "ACILI GÖBƏLƏK ŞORBASI | 5 AZN";
            thirdWindow.lbCheck.Items.Add(item);

            thirdWindow.Activate();
        }

        private void GurzesorbasiBtn_Click(object sender, RoutedEventArgs e)
        {
            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "GÜRZƏ ŞORBASI | 8 AZN";
            thirdWindow.lbCheck.Items.Add(item);

            thirdWindow.Activate();
        }

        private void Gobeleksorbasi2Btn_Click(object sender, RoutedEventArgs e)
        {
            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "GÖBƏLƏK ŞORBASI | 5 AZN";
            thirdWindow.lbCheck.Items.Add(item);

            thirdWindow.Activate();
        }

        private void KoksorbasiBtn_Click(object sender, RoutedEventArgs e)
        {
            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "KÖK ŞORBASI | 4 AZN";
            thirdWindow.lbCheck.Items.Add(item);

            thirdWindow.Activate();
        }

        private void KartofsorbasiBtn_Click(object sender, RoutedEventArgs e)
        {
            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "KARTOF ŞORBASI | 4 AZN";
            thirdWindow.lbCheck.Items.Add(item);

            thirdWindow.Activate();
        }







        private void TunabaligisalatiBtn_Click(object sender, RoutedEventArgs e)
        {
            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "TUNA BALIĞI SALATI | 9 AZN";
            thirdWindow.lbCheck.Items.Add(item);

            thirdWindow.Activate();
        }

        private void SezarsalatiBtn_Click(object sender, RoutedEventArgs e)
        {
            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "SEZAR SALATI | 15 AZN";
            thirdWindow.lbCheck.Items.Add(item);

            thirdWindow.Activate();
        }

        private void CikenbluzBtn_Click(object sender, RoutedEventArgs e)
        {
            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "ÇİKEN BLUZ | 10 AZN";
            thirdWindow.lbCheck.Items.Add(item);

            thirdWindow.Activate();
        }

        private void CugundursalatiBtn_Click(object sender, RoutedEventArgs e)
        {
            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "ÇUĞUNDUR SALATI | 11 AZN";
            thirdWindow.lbCheck.Items.Add(item);

            thirdWindow.Activate();
        }

        private void CobansalatiBtn_Click(object sender, RoutedEventArgs e)
        {
            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "ÇOBAN SALATI | 6 AZN";
            thirdWindow.lbCheck.Items.Add(item);

            thirdWindow.Activate();
        }

        private void YunansalatiBtn_Click(object sender, RoutedEventArgs e)
        {
            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "YUNAN SALATI | 7 AZN";
            thirdWindow.lbCheck.Items.Add(item);

            thirdWindow.Activate();
        }






        private void TursularBtn_Click(object sender, RoutedEventArgs e)
        {
            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "TURŞU ÇEŞİDİ | 5 AZN";
            thirdWindow.lbCheck.Items.Add(item);

            thirdWindow.Activate();

        }

        private void TerevezlerBtn_Click(object sender, RoutedEventArgs e)
        {
            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "TƏRƏVƏZ ÇEŞİDİ | 5 AZN";
            thirdWindow.lbCheck.Items.Add(item);

            thirdWindow.Activate();
        }

        private void PendirlerBtn_Click(object sender, RoutedEventArgs e)
        {
            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "PENDİR ÇEŞİDİ | 7 AZN";
            thirdWindow.lbCheck.Items.Add(item);

            thirdWindow.Activate();
        }

        private void ToyuqruletiBtn_Click(object sender, RoutedEventArgs e)
        {
            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "TOYUQ RULETİ | 5 AZN";
            thirdWindow.lbCheck.Items.Add(item);

            thirdWindow.Activate();

        }

        private void HumusBtn_Click(object sender, RoutedEventArgs e)
        {
            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "HUMUS | 5 AZN";
            thirdWindow.lbCheck.Items.Add(item);

            thirdWindow.Activate();

        }

        private void BruskettaBtn_Click(object sender, RoutedEventArgs e)
        {
            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "BRUSKETTA \"KAPREZE\" | 8 AZN";
            thirdWindow.lbCheck.Items.Add(item);

            thirdWindow.Activate();

        }






        private void WatermelonslushieBtn_Click(object sender, RoutedEventArgs e)
        {
            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "WATERMELON SLUSHIE | 5 AZN";
            thirdWindow.lbCheck.Items.Add(item);

            thirdWindow.Activate();
        }

        private void LechemilkshakeBtn_Click(object sender, RoutedEventArgs e)
        {
            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "LECHE MILKSHAKE | 6 AZN";
            thirdWindow.lbCheck.Items.Add(item);

            thirdWindow.Activate();
        }

        private void MojitoBtn_Click(object sender, RoutedEventArgs e)
        {
            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "MOJITO | 6 AZN";
            thirdWindow.lbCheck.Items.Add(item);

            thirdWindow.Activate();
        }

        private void WiskyBtn_Click(object sender, RoutedEventArgs e)
        {
            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "WISKY | 10 AZN";
            thirdWindow.lbCheck.Items.Add(item);

            thirdWindow.Activate();
        }

        private void WhineBtn_Click(object sender, RoutedEventArgs e)
        {
            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "WHINE | 15 AZN";
            thirdWindow.lbCheck.Items.Add(item);

            thirdWindow.Activate();
        }

        private void MartiniBtn_Click(object sender, RoutedEventArgs e)
        {
            Check thirdWindow = Application.Current.Windows.OfType<Check>().FirstOrDefault();
            if (thirdWindow == null)
            {
                thirdWindow = new Check();
                thirdWindow.Show();
            }

            ListBoxItem item = new ListBoxItem();
            item.Content = "MARTINI | 9 AZN";
            thirdWindow.lbCheck.Items.Add(item);

            thirdWindow.Activate();
        }
    }
}
