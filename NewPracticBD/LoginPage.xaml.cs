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
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (name.Text == "")
            {
                MessageBox.Show("Введите все данные");
            }
            else
            {
                users user = new users();
                user.name = name.Text;
                user.sname = lname.Text;
                user.phone = phone.Text;
                user.email = mail.Text;
                user.id_roll = 3;


                number_user number_User = new number_user();
                number_User.password = password.Password;
                number_User.id_user = user.id_user;
                MainWindow.db.users.Add(user);
                MainWindow.db.number_user.Add(number_User);
                try
                {
                    MainWindow.db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Такое имя пользователя или логин уже существует");
                }
                MessageBox.Show("Успешно!");
            }
        }
    }
}
