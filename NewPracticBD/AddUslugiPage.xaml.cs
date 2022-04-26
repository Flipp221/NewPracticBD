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

namespace NewPracticBD
{
    /// <summary>
    /// Логика взаимодействия для AddUslugiPage.xaml
    /// </summary>
    public partial class AddUslugiPage : Window
    {
        private uslugi _uslugi = new uslugi();
        public AddUslugiPage()
        {
            InitializeComponent();
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
                shaurmaEntities.GetContext().uslugi.Add(_uslugi);
            }
            try
            {
                shaurmaEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                OsnovaPage wd = new OsnovaPage();
                wd.Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
