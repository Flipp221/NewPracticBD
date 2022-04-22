﻿using System;
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
        }
        private void Fillipp()
        {
            infoTB.Text = MainWindow.User.name;
            InfTB.Text = MainWindow.User.sname;
        }
    }
}