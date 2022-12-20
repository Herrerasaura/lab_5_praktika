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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab_5_praktika
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button is clicked");
        }

        private void ChangeBack(object sender, RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush(Color.FromRgb(0, 0, 255));
        }

        private void Info(object sender, RoutedEventArgs e)
        {
            info.Content = "Разработчик этого WPF приложения - стуент группы ПР-31 Савостенко Дарья";
        }

        private void CloseWind(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ChangeEnter(object sender, MouseEventArgs e)
        {
            status.Text = "Изменить цвет фона окна";
        }

        private void InfoEnter(object sender, MouseEventArgs e)
        {
            status.Text = "Получить информацию о разработчике";
        }

        private void CloseEnter(object sender, MouseEventArgs e)
        {
            status.Text = "Закрыть окно";
        }
    }
}
