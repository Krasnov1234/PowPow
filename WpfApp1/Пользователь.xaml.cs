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
    /// Логика взаимодействия для Пользователь.xaml
    /// </summary>
    public partial class Пользователь : Window
    {
        public Пользователь()
        {
            InitializeComponent();
        }
        private void DobSotr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            gr691_koyEntities1 db = new gr691_koyEntities1();
            Рецепты.ItemsSource = db.Справочник_рецептов.ToList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //gr691_koyEntities1 db = new gr691_koyEntities1();     ///////////////////////// необходимо открыть прни использовании
            //Рецепты.ItemsSource = db.Справочник_рецептов.ToList();
        }



        private void Пользователь_Рецепт(object sender, RoutedEventArgs e)
        {
            Close();
            Hide();
            MainWindow meny = new MainWindow();
            meny.Show();

        }
    }
}
