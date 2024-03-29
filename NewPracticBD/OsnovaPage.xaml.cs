﻿using System;
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
            DGridKatalog.ItemsSource = Fili_CafeEntities.GetContext().uslugi.ToList();
        }

        public void aa ()
        {
            DGridKatalog.ItemsSource = Fili_CafeEntities.GetContext().uslugi.ToList();
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
            StarsTB_Copy.Visibility = Visibility.Hidden;
            StarsTB_Copy1.Visibility = Visibility.Hidden;
            StarsTB.Visibility = Visibility.Hidden;
            TimesTB_Copy.Visibility = Visibility.Hidden;
            TimesTB_Copy1.Visibility = Visibility.Hidden;
            TimesTB.Visibility = Visibility.Hidden;
            PricedTB.Visibility = Visibility.Hidden;
            PricedTB_Copy.Visibility = Visibility.Hidden;
            PricedTB_Copy1.Visibility = Visibility.Hidden;
            buyBTN_Copy.Visibility = Visibility.Hidden;
            buyBTN_Copy1.Visibility = Visibility.Hidden;
            nameTBH.Visibility = Visibility.Hidden;
            nameTBP.Visibility = Visibility.Hidden;
            nameTBS.Visibility = Visibility.Hidden;
            hot.Visibility = Visibility.Hidden;
            pizza.Visibility = Visibility.Hidden;
            shaurma.Visibility = Visibility.Hidden;
            Lavash.Visibility = Visibility.Hidden;
            buyBTN.Visibility = Visibility.Hidden;
            four.Visibility = Visibility.Hidden;
            twos.Visibility = Visibility.Hidden;
            threes.Visibility = Visibility.Hidden;
            ones.Visibility = Visibility.Hidden;
            sss.Visibility = Visibility.Hidden;
            www.Visibility = Visibility.Hidden;
            oneq.Visibility = Visibility.Hidden;
            twop.Visibility = Visibility.Hidden;
            threep.Visibility = Visibility.Hidden;
            ZakaziTB.Visibility = Visibility.Hidden;
            GridZakazi.Visibility = Visibility.Hidden;
            Prinyato.Visibility = Visibility.Hidden;
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
            StarsTB_Copy.Visibility = Visibility.Hidden;
            StarsTB_Copy1.Visibility = Visibility.Hidden;
            StarsTB.Visibility = Visibility.Hidden;
            TimesTB_Copy.Visibility = Visibility.Hidden;
            TimesTB_Copy1.Visibility = Visibility.Hidden;
            TimesTB.Visibility = Visibility.Hidden;
            PricedTB.Visibility = Visibility.Hidden;
            PricedTB_Copy.Visibility = Visibility.Hidden;
            PricedTB_Copy1.Visibility = Visibility.Hidden;
            buyBTN_Copy.Visibility = Visibility.Hidden;
            buyBTN_Copy1.Visibility = Visibility.Hidden;
            nameTBH.Visibility = Visibility.Hidden;
            nameTBP.Visibility = Visibility.Hidden;
            nameTBS.Visibility = Visibility.Hidden;
            hot.Visibility = Visibility.Hidden;
            pizza.Visibility = Visibility.Hidden;
            shaurma.Visibility = Visibility.Hidden;
            Lavash.Visibility = Visibility.Hidden;
            buyBTN.Visibility = Visibility.Hidden;
            four.Visibility = Visibility.Hidden;
            twos.Visibility = Visibility.Hidden;
            threes.Visibility = Visibility.Hidden;
            ones.Visibility = Visibility.Hidden;
            sss.Visibility = Visibility.Hidden;
            www.Visibility = Visibility.Hidden;
            oneq.Visibility = Visibility.Hidden;
            twop.Visibility = Visibility.Hidden;
            threep.Visibility = Visibility.Hidden;
            ZakaziTB.Visibility = Visibility.Hidden;
            GridZakazi.Visibility = Visibility.Hidden;
            Prinyato.Visibility = Visibility.Hidden;
        }
        private void Mouse_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                Fili_CafeEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(a => a.Reload());
                DGridKatalog.ItemsSource = Fili_CafeEntities.GetContext().uslugi.ToList();
                GridSklad.ItemsSource = Fili_CafeEntities.GetContext().Sklad.ToList();
                GridZakazi.ItemsSource = Fili_CafeEntities.GetContext().Zakazi.ToList();
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
            StarsTB_Copy.Visibility = Visibility.Hidden;
            StarsTB_Copy1.Visibility = Visibility.Hidden;
            StarsTB.Visibility = Visibility.Hidden;
            TimesTB_Copy.Visibility = Visibility.Hidden;
            TimesTB_Copy1.Visibility = Visibility.Hidden;
            TimesTB.Visibility = Visibility.Hidden;
            PricedTB.Visibility = Visibility.Hidden;
            PricedTB_Copy.Visibility = Visibility.Hidden;
            PricedTB_Copy1.Visibility = Visibility.Hidden;
            buyBTN_Copy.Visibility = Visibility.Hidden;
            buyBTN_Copy1.Visibility = Visibility.Hidden;
            nameTBH.Visibility = Visibility.Hidden;
            nameTBP.Visibility = Visibility.Hidden;
            nameTBS.Visibility = Visibility.Hidden;
            hot.Visibility = Visibility.Hidden;
            pizza.Visibility = Visibility.Hidden;
            shaurma.Visibility = Visibility.Hidden;
            Lavash.Visibility = Visibility.Hidden;
            buyBTN.Visibility = Visibility.Hidden;
            four.Visibility = Visibility.Hidden;
            twos.Visibility = Visibility.Hidden;
            threes.Visibility = Visibility.Hidden;
            ones.Visibility = Visibility.Hidden;
            sss.Visibility = Visibility.Hidden;
            www.Visibility = Visibility.Hidden;
            oneq.Visibility = Visibility.Hidden;
            twop.Visibility = Visibility.Hidden;
            threep.Visibility = Visibility.Hidden;
            ZakaziTB.Visibility = Visibility.Hidden;
            GridZakazi.Visibility = Visibility.Hidden;
            Prinyato.Visibility = Visibility.Hidden;
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
                GridSklad.Visibility = Visibility.Hidden;
                RamSklad.Visibility = Visibility.Hidden;
                DobBtn.Visibility = Visibility.Hidden;
                DeleteDtn.Visibility = Visibility.Hidden;
                RedBtn.Visibility = Visibility.Hidden;
            }
            else
            {
                GridSklad.Visibility = Visibility.Hidden;
                RamSklad.Visibility = Visibility.Hidden;
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
                    Fili_CafeEntities.GetContext().uslugi.RemoveRange(MousesForRemoving);
                    Fili_CafeEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");

                    DGridKatalog.ItemsSource = Fili_CafeEntities.GetContext().uslugi.ToList();
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
            if (MainWindow.vhodUser.id_user != 2)
            {
                GridSklad.Visibility = Visibility.Hidden;
                RamSklad.Visibility = Visibility.Hidden;
            }
            else
            {
                GridSklad.Visibility = Visibility.Visible;
                RamSklad.Visibility = Visibility.Visible;
            }
            four.Visibility = Visibility.Visible;
            twos.Visibility = Visibility.Visible;
            threes.Visibility = Visibility.Visible;
            ones.Visibility = Visibility.Visible;
            sss.Visibility = Visibility.Visible;
            www.Visibility = Visibility.Visible;
            oneq.Visibility = Visibility.Visible;
            twop.Visibility = Visibility.Visible;
            threep.Visibility = Visibility.Visible;
            StarsTB_Copy.Visibility = Visibility.Visible;
            StarsTB_Copy1.Visibility = Visibility.Visible;
            StarsTB.Visibility = Visibility.Visible;
            TimesTB_Copy.Visibility = Visibility.Visible;
            TimesTB_Copy1.Visibility = Visibility.Visible;
            TimesTB.Visibility = Visibility.Visible;
            PricedTB.Visibility = Visibility.Visible;
            PricedTB_Copy.Visibility = Visibility.Visible;
            PricedTB_Copy1.Visibility = Visibility.Visible;
            buyBTN.Visibility = Visibility.Visible;
            buyBTN_Copy.Visibility = Visibility.Visible;
            buyBTN_Copy1.Visibility = Visibility.Visible;
            nameTBH.Visibility = Visibility.Visible;
            nameTBP.Visibility = Visibility.Visible;
            nameTBS.Visibility = Visibility.Visible;
            hot.Visibility = Visibility.Visible;
            pizza.Visibility = Visibility.Visible;
            shaurma.Visibility = Visibility.Visible;
            Lavash.Visibility = Visibility.Visible;
            Luck.Visibility = Visibility.Visible;
            Myaso.Visibility = Visibility.Visible;
            Ogurci.Visibility = Visibility.Visible;
            Pomidori.Visibility = Visibility.Visible;
            Sosiska.Visibility = Visibility.Visible;
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
            ZakaziTB.Visibility = Visibility.Hidden;
            GridZakazi.Visibility = Visibility.Hidden;
            Prinyato.Visibility = Visibility.Hidden;
        }

        private void buyBTN_Click(object sender, RoutedEventArgs e)
        {
            var sklad = MainWindow.db.Sklad.FirstOrDefault();
            try
                {
                if (sklad.lavash.kolich == 0 || sklad.Luck.kolich == 0 || sklad.myasko.kolich == 0 || sklad.ogurci.kolich == 0 || sklad.pomidori.kolich == 0)
                {
                    MessageBox.Show("Закончилить продукты");
                }
                else
                {
                    Zakazi zakazi = new Zakazi();
                    zakazi.name = "Заказ №1";
                    zakazi.id_usluga = 4;
                    zakazi.id_price = 6;
                    zakazi.id_time = 3;
                    zakazi.id_image = 1;
                    MainWindow.db.Zakazi.Add(zakazi);
                    MessageBox.Show("Спасибо за заказ!");
                    sklad.lavash.kolich -= 1;
                    sklad.Luck.kolich -= 1;
                    sklad.myasko.kolich -= 1;
                    sklad.ogurci.kolich -= 1;
                    sklad.pomidori.kolich -= 1;
                    MainWindow.db.SaveChanges();
                    GridSklad.ItemsSource = Fili_CafeEntities.GetContext().Sklad.ToList();
                    OsnovaPage osnovaPage = new OsnovaPage();
                    osnovaPage.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            
        }

        private void buyBTN_Copy_Click(object sender, RoutedEventArgs e)
        {
            var sklad = MainWindow.db.Sklad.FirstOrDefault();
            try
            {
                if (sklad.myasko.kolich == 0 || sklad.ogurci.kolich == 0 || sklad.pomidori.kolich == 0)
                {
                    MessageBox.Show("Закончилить продукты");
                }
                else
                {
                    Zakazi zakazi = new Zakazi();
                    zakazi.name = "Заказ №2";
                    zakazi.id_usluga = 5;
                    zakazi.id_price = 3;
                    zakazi.id_time = 5;
                    zakazi.id_image = 2;
                    MainWindow.db.Zakazi.Add(zakazi);
                    MessageBox.Show("Спасибо за заказ!");
                    sklad.myasko.kolich -= 1;
                    sklad.ogurci.kolich -= 1;
                    sklad.pomidori.kolich -= 1;
                    MainWindow.db.SaveChanges();
                    GridSklad.ItemsSource = Fili_CafeEntities.GetContext().Sklad.ToList();
                    OsnovaPage osnovaPage = new OsnovaPage();
                    osnovaPage.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void buyBTN_Copy1_Click(object sender, RoutedEventArgs e)
        {
            var sklad = MainWindow.db.Sklad.FirstOrDefault();
            try
            {
                if (sklad.Luck.kolich == 0 || sklad.ogurci.kolich == 0 || sklad.pomidori.kolich == 0 || sklad.sosiska.kolich == 0)
                {
                    MessageBox.Show("Закончилить продукты");
                }
                else
                {
                    Zakazi zakazi = new Zakazi();
                    zakazi.name = "Заказ №3";
                    zakazi.id_usluga = 6;
                    zakazi.id_price = 2;
                    zakazi.id_time = 3;
                    zakazi.id_image = 3;
                    MainWindow.db.Zakazi.Add(zakazi);
                    MessageBox.Show("Спасибо за заказ!");
                    sklad.Luck.kolich -= 1;
                    sklad.ogurci.kolich -= 1;
                    sklad.pomidori.kolich -= 1;
                    sklad.sosiska.kolich -= 1;
                    MainWindow.db.SaveChanges();
                    GridSklad.ItemsSource = Fili_CafeEntities.GetContext().Sklad.ToList();
                    OsnovaPage osnovaPage = new OsnovaPage();
                    osnovaPage.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var MousesForRemoving = GridZakazi.SelectedItems.Cast<Zakazi>().ToList();
            {
                try
                {
                    Fili_CafeEntities.GetContext().Zakazi.RemoveRange(MousesForRemoving);
                    Fili_CafeEntities.GetContext().SaveChanges();
                    MessageBox.Show("Заказ принят!");

                    GridZakazi.ItemsSource = Fili_CafeEntities.GetContext().Zakazi.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (MainWindow.vhodUser.id_user != 2)
            {
                GridZakazi.Visibility = Visibility.Visible;
            }
            else
            {
                GridZakazi.Visibility = Visibility.Hidden;
            }
            ZakaziTB.Visibility = Visibility.Visible;
            Prinyato.Visibility = Visibility.Visible;
            four.Visibility = Visibility.Hidden;
            twos.Visibility = Visibility.Hidden;
            threes.Visibility = Visibility.Hidden;
            ones.Visibility = Visibility.Hidden;
            sss.Visibility = Visibility.Hidden;
            www.Visibility = Visibility.Hidden;
            oneq.Visibility = Visibility.Hidden;
            twop.Visibility = Visibility.Hidden;
            threep.Visibility = Visibility.Hidden;
            StarsTB_Copy.Visibility = Visibility.Hidden;
            StarsTB_Copy1.Visibility = Visibility.Hidden;
            StarsTB.Visibility = Visibility.Hidden;
            TimesTB_Copy.Visibility = Visibility.Hidden;
            TimesTB_Copy1.Visibility = Visibility.Hidden;
            TimesTB.Visibility = Visibility.Hidden;
            PricedTB.Visibility = Visibility.Hidden;
            PricedTB_Copy.Visibility = Visibility.Hidden;
            PricedTB_Copy1.Visibility = Visibility.Hidden;
            buyBTN.Visibility = Visibility.Hidden;
            buyBTN_Copy.Visibility = Visibility.Hidden;
            buyBTN_Copy1.Visibility = Visibility.Hidden;
            nameTBH.Visibility = Visibility.Hidden;
            nameTBP.Visibility = Visibility.Hidden;
            nameTBS.Visibility = Visibility.Hidden;
            hot.Visibility = Visibility.Hidden;
            pizza.Visibility = Visibility.Hidden;
            shaurma.Visibility = Visibility.Hidden;
            Lavash.Visibility = Visibility.Hidden;
            Luck.Visibility = Visibility.Hidden;
            Myaso.Visibility = Visibility.Hidden;
            Ogurci.Visibility = Visibility.Hidden;
            Pomidori.Visibility = Visibility.Hidden;
            Sosiska.Visibility = Visibility.Hidden;
            RamSklad.Visibility = Visibility.Hidden;
            GridSklad.Visibility = Visibility.Hidden;
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
    }
}
