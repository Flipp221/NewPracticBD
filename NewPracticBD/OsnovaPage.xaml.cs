using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace NewPracticBD
{
    /// <summary>
    /// Логика взаимодействия для OsnovaPage.xaml
    /// </summary>
    public partial class OsnovaPage : Window
    {
        public static number_user vhodUser;
        DispatcherTimer timer;
        double panelWidth;
        
        bool hidden;
        public OsnovaPage()
        {
            InitializeComponent();
            Visible();
            Fillipp();
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            timer.Tick += Timer_Tick;
            panelWidth = sidePanel.Width;
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            DGridKatalog.ItemsSource = shaurmaEntities.GetContext().uslugi.ToList();
        }

        public void aa ()
        {
            DGridKatalog.ItemsSource = shaurmaEntities.GetContext().uslugi.ToList();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                sidePanel.Width += 1;
                if (sidePanel.Width >= panelWidth)
                {
                    timer.Stop();
                    hidden = false;
                }
            }
            else
            {
                sidePanel.Width -= 1;
                if (sidePanel.Width <= 35)
                {
                    timer.Stop();
                    hidden = true;
                }
            }
        }
        private void Panel_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }
        private void PanelHeader_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void RegBut_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DeleteDtn.Visibility = Visibility.Hidden;
            DobBtn.Visibility = Visibility.Hidden;
            glavphoto.Visibility = Visibility.Visible;
            glavbTB.Visibility = Visibility.Visible;
            glavTB.Visibility = Visibility.Visible;
            dan.Visibility = Visibility.Hidden;
            name.Visibility = Visibility.Hidden;
            fam.Visibility = Visibility.Hidden;
            mail.Visibility = Visibility.Hidden;
            phone.Visibility = Visibility.Hidden;
            DGridKatalog.Visibility = Visibility.Hidden;
            RamBTN.Visibility = Visibility.Hidden;
            uslugithTB.Visibility = Visibility.Hidden;
            UslugiOTB.Visibility = Visibility.Hidden;
            UslugiTTB.Visibility = Visibility.Hidden;
            RamSklad.Visibility = Visibility.Hidden;
            GridSklad.Visibility = Visibility.Hidden;
            Lavash.Visibility = Visibility.Hidden;
            Luck.Visibility = Visibility.Hidden;
            Myaso.Visibility = Visibility.Hidden;
            Ogurci.Visibility = Visibility.Hidden;
            Pomidori.Visibility = Visibility.Hidden;
            Sosiska.Visibility = Visibility.Hidden;
        }
        private void Fillipp()
        {
            infoTB.Text = MainWindow.User.name;
            InfTB.Text = MainWindow.User.sname;
            nameTB.Text = MainWindow.User.name;
            FamTB.Text = MainWindow.User.sname;
            MailTB.Text = MainWindow.User.email;
            PhoneTB.Text = MainWindow.User.phone;
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DeleteDtn.Visibility = Visibility.Hidden;
            DobBtn.Visibility = Visibility.Hidden;
            dan.Visibility = Visibility.Visible;
            name.Visibility = Visibility.Visible;
            fam.Visibility = Visibility.Visible;
            mail.Visibility = Visibility.Visible;
            phone.Visibility = Visibility.Visible;
            glavphoto.Visibility = Visibility.Hidden;
            glavbTB.Visibility = Visibility.Hidden;
            glavTB.Visibility = Visibility.Hidden;
            DGridKatalog.Visibility = Visibility.Hidden;
            RamBTN.Visibility = Visibility.Hidden;
            uslugithTB.Visibility = Visibility.Hidden;
            UslugiOTB.Visibility = Visibility.Hidden;
            UslugiTTB.Visibility = Visibility.Hidden;
            RamSklad.Visibility = Visibility.Hidden;
            GridSklad.Visibility = Visibility.Hidden;
            Lavash.Visibility = Visibility.Hidden;
            Luck.Visibility = Visibility.Hidden;
            Myaso.Visibility = Visibility.Hidden;
            Ogurci.Visibility = Visibility.Hidden;
            Pomidori.Visibility = Visibility.Hidden;
            Sosiska.Visibility = Visibility.Hidden;
        }
        private void Mouse_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                shaurmaEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(a => a.Reload());
                DGridKatalog.ItemsSource = shaurmaEntities.GetContext().uslugi.ToList();
                GridSklad.ItemsSource = shaurmaEntities.GetContext().Sklad.ToList();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (MainWindow.vhodUser.id_user != 2)
            {
                RedBtn.Visibility = Visibility.Hidden;
                DobBtn.Visibility = Visibility.Hidden;
                DeleteDtn.Visibility = Visibility.Hidden;
            }
            else
            {
                RedBtn.Visibility = Visibility.Visible;
                DobBtn.Visibility = Visibility.Visible;
                DeleteDtn.Visibility = Visibility.Visible;
            }
            uslugithTB.Visibility = Visibility.Visible;
            UslugiOTB.Visibility = Visibility.Visible;
            UslugiTTB.Visibility = Visibility.Visible;
            RamBTN.Visibility = Visibility.Visible;
            DGridKatalog.Visibility = Visibility.Visible;
            dan.Visibility = Visibility.Hidden;
            name.Visibility = Visibility.Hidden;
            fam.Visibility = Visibility.Hidden;
            mail.Visibility = Visibility.Hidden;
            phone.Visibility = Visibility.Hidden;
            glavphoto.Visibility = Visibility.Hidden;
            glavbTB.Visibility = Visibility.Hidden;
            glavTB.Visibility = Visibility.Hidden;
            RamSklad.Visibility = Visibility.Hidden;
            GridSklad.Visibility = Visibility.Hidden;
            Lavash.Visibility = Visibility.Hidden;
            Luck.Visibility = Visibility.Hidden;
            Myaso.Visibility = Visibility.Hidden;
            Ogurci.Visibility = Visibility.Hidden;
            Pomidori.Visibility = Visibility.Hidden;
            Sosiska.Visibility = Visibility.Hidden;
        }

        private void DobBtn_Click(object sender, RoutedEventArgs e)
        {
            AddUslugiPage page = new AddUslugiPage(null);
            page.Show();
            
        }
        public void Visible()
        {
            if (MainWindow.vhodUser.id_user != 2)
            {
                DobBtn.Visibility = Visibility.Hidden;
                DeleteDtn.Visibility = Visibility.Hidden;
                RedBtn.Visibility = Visibility.Hidden;
            }
            else
            {
                RedBtn.Visibility = Visibility.Hidden;
                DobBtn.Visibility = Visibility.Hidden;
                DeleteDtn.Visibility = Visibility.Hidden;
            }
        }

        private void DeleteDtn_Click(object sender, RoutedEventArgs e)
        {
            var MousesForRemoving = DGridKatalog.SelectedItems.Cast<uslugi>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить сдедующие{MousesForRemoving.Count()} элементов?", "Внимение",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    shaurmaEntities.GetContext().uslugi.RemoveRange(MousesForRemoving);
                    shaurmaEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");

                    DGridKatalog.ItemsSource = shaurmaEntities.GetContext().uslugi.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Red_Click(object sender, RoutedEventArgs e)
        {
            AddUslugiPage page = new AddUslugiPage((sender as Button).DataContext as uslugi);
            page.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Lavash.Visibility = Visibility.Visible;
            Luck.Visibility = Visibility.Visible;
            Myaso.Visibility = Visibility.Visible;
            Ogurci.Visibility = Visibility.Visible;
            Pomidori.Visibility = Visibility.Visible;
            Sosiska.Visibility = Visibility.Visible;
            RamSklad.Visibility = Visibility.Visible;
            GridSklad.Visibility = Visibility.Visible;
            DeleteDtn.Visibility = Visibility.Hidden;
            DobBtn.Visibility = Visibility.Hidden;
            glavphoto.Visibility = Visibility.Hidden;
            glavbTB.Visibility = Visibility.Hidden;
            glavTB.Visibility = Visibility.Hidden;
            dan.Visibility = Visibility.Hidden;
            name.Visibility = Visibility.Hidden;
            fam.Visibility = Visibility.Hidden;
            mail.Visibility = Visibility.Hidden;
            phone.Visibility = Visibility.Hidden;
            DGridKatalog.Visibility = Visibility.Hidden;
            RamBTN.Visibility = Visibility.Hidden;
            uslugithTB.Visibility = Visibility.Hidden;
            UslugiOTB.Visibility = Visibility.Hidden;
            UslugiTTB.Visibility = Visibility.Hidden;
        }

        private void buyBTN_Click(object sender, RoutedEventArgs e)
        {
            var sklad = MainWindow.db.Sklad.FirstOrDefault();
            try
                {
                MessageBox.Show("Спасибо за заказ!");
                sklad.lavash.kolich -= 1;
                MainWindow.db.Sklad.Add(sklad);
                MainWindow.db.SaveChanges();
                GridSklad.ItemsSource = shaurmaEntities.GetContext().Sklad.ToList();
            }
            catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            
        }

        private void buyBTN_Copy_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
