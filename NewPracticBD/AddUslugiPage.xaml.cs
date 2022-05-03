using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Microsoft.Win32;

namespace NewPracticBD
{
    /// <summary>
    /// Логика взаимодействия для AddUslugiPage.xaml
    /// </summary>
    public partial class AddUslugiPage : Window
    {
        OpenFileDialog ofdImage1 = new OpenFileDialog();
        private uslugi _uslugi = new uslugi();
        public AddUslugiPage(uslugi selected)
        {
            InitializeComponent();
            if (selected != null)
                _uslugi = selected;

            DataContext = _uslugi;
            PriceCB.ItemsSource = shaurmaEntities.GetContext().price.ToList();
            TimeCB.ItemsSource = shaurmaEntities.GetContext().time.ToList();
            SPriceCB.ItemsSource = shaurmaEntities.GetContext().sprice.ToList();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(NameTB.Text))
                errors.AppendLine("укажите название блюда");
            if (_uslugi.price == null)
                errors.AppendLine("Укажите цену");
            if (_uslugi.time == null)
                errors.AppendLine("Укажите время");
            if (_uslugi.sprice == null)
                errors.AppendLine("Укажите себестоимость");


            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_uslugi.id_usluga == 0)
            {
                _uslugi.image = File.ReadAllBytes(ofdImage1.FileName);
                shaurmaEntities.GetContext().uslugi.Add(_uslugi);
            }
            try
            {
                shaurmaEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofdImage = new OpenFileDialog();
            ofdImage.Filter = "Image files|*.bmp;*.jpg;*.png|All files|*.*";
            ofdImage.FilterIndex = 1;
            if (ofdImage.ShowDialog() == true)
            {
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri(ofdImage.FileName);
                image.EndInit();
                ofdImage1 = ofdImage;
                img.Source = image;
            }
        }
    }
}
