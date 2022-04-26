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
            Fillipp();
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            timer.Tick += Timer_Tick;
            panelWidth = sidePanel.Width;
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
        }
        private void Mouse_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                shaurmaEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(a => a.Reload());
                DGridKatalog.ItemsSource = shaurmaEntities.GetContext().uslugi.ToList();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
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
        }

        private void DobBtn_Click(object sender, RoutedEventArgs e)
        {
            AddUslugiPage page = new AddUslugiPage();
            page.Show();
        }
    }
}
