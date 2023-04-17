using System;
using System.IO;
using Microsoft.Win32;
using System.Windows;
using System.Windows.Controls;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Paragraph = iTextSharp.text.Paragraph;
using WPF_R_kiper.TableFile.View;
using System.Linq;
using WPF_R_kiper.OrdersFile;
using WPF_R_kiper.OrdersFile.View;

namespace WPF_R_kiper.CheckFile.View
{
    /// <summary>
    /// Interaction logic for Check.xaml
    /// </summary>
    public partial class Check : Window
    {
        private Orders window1;

        public Check()
        {
            InitializeComponent();
            window1 = new Orders();

        }



        private void TotalBtn_Click(object sender, RoutedEventArgs e)
        {

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



            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.FileName = "Save Check.pdf";
            saveFileDialog.Title = "Save PDF File";

            // Show the SaveFileDialog
            if (saveFileDialog.ShowDialog() == true)
            {
                // Call the SaveListBoxAsPdf method with the selected file path
                SaveListBoxAsPdf(saveFileDialog.FileName);
            }

            Application.Current.Shutdown();
        }


        private void SaveListBoxAsPdf(string filePath)
        {
            // Create a new instance of the Document class
            Document document = new Document();

            try
            {
                // Create a new PdfWriter instance with the specified file path
                PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

                // Open the document
                document.Open();

                // Create a new Paragraph instance
                Paragraph paragraph = new Paragraph();

                // Add each ListBoxItem to the Paragraph
                foreach (ListBoxItem item in lbCheck.Items)
                {
                    paragraph.Add(new Chunk(item.Content.ToString()));
                    paragraph.Add(new Chunk("\n"));

                }

                // Add the Paragraph to the document
                document.Add(paragraph);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the document
                document.Close();
            }


        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem clickedItem = sender as MenuItem;
            string header = clickedItem.Header.ToString();

            switch (header)
            {
                case "Sil":
                    lbCheck.Items.Remove(lbCheck.SelectedItem);
                    break;

            }

        }
    }
}