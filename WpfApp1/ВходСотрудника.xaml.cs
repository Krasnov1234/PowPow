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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для ВходСотрудника.xaml
    /// </summary>
    public partial class ВходСотрудника : Window
    {
        gr691_koyEntities1 db = new gr691_koyEntities1();
        Поварята Isotr = new Поварята();

        public ВходСотрудника()
        {
            InitializeComponent();
        }
        private void GlMeny(object sender, RoutedEventArgs e)
        {
            Hide();
            MainWindow meny = new MainWindow();
            meny.Show();
            Close();
        }


        private void Sotr(object sender, RoutedEventArgs e)
        {


            if (txt_Логин.Text == "2" && txt_Пароль.Password == "2")
            {

                MessageBox.Show("Всё заполнено", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);

                Доб_Сотрудником.Доб_Сотруд DSotr = new Доб_Сотрудником.Доб_Сотруд();
                DSotr.Show();
                Close();
                // Hide();
            }
            gr691_koyEntities1 db = new gr691_koyEntities1();


            // Поварята User = db.Поварята.FirstOrDefault(i => i.Имя == txt_Логин.Text);  ///////////////////////// необходимо открыть прни использовании
            // Поварята Password = db.Поварята.FirstOrDefault(i => i.Пароль == txt_Пароль.Password);


            //else if (txt_Логин.Text == "" || txt_Пароль.Password == "")
            // {
            //     MessageBox.Show("Не всё заполнено", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            // }
            // else if (txt_Логин.Text != User.Имя )
            // {
            //     MessageBox.Show("Неправильй логин", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            // }
            // else if (Password.Пароль != txt_Пароль.Password)
            // {
            //     MessageBox.Show("Неправильй пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            // }
            // else if (User.Имя == txt_Логин.Text && Password.Пароль == txt_Пароль.Password)
            // {

            //     MessageBox.Show("Всё заполнено", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);

            //     Доб_Сотрудником.Доб_Сотруд DSotr = new Доб_Сотрудником.Доб_Сотруд();
            //     DSotr.Show();
            //     Close();
            //    // Hide();


            // }

        }
    }
}
