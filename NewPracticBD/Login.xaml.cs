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
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
                foreach (var number_User in MainWindow.db.number_user)
                    foreach (var users in MainWindow.db.users)
                    {
                        if (number_User.password == PassTB.Password.Trim())
                            if (users.email == loginTB.Text.Trim())
                                {
                                if (number_User.password == PassTB.Password.Trim() && number_User.id_user != 2)
                                {
                                    MessageBox.Show($"Привет Пользователь  ваш персональный Id - {number_User.id_user}");
                                    MainWindow.vhodUser = number_User;
                                    MainWindow.User = users;
                                }
                                if (number_User.password == PassTB.Password.Trim() && number_User.id_user == 2)
                                {
                                    MessageBox.Show($"Привет админ  ваш персональный Id -  {number_User.id_user}");
                                    MainWindow.User = users;
                                    MainWindow.vhodUser = number_User;
                                }
                                OsnovaPage wd = new OsnovaPage();
                                wd.Show();
                                this.Close();
                                }
                    }  
        }
    }
}
