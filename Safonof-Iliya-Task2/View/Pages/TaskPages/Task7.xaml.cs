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
using static Safonof_Iliya_Task2.Core.Core;

namespace Safonof_Iliya_Task2.View.Pages.TaskPages
{
    /// <summary>
    /// Логика взаимодействия для Task7.xaml
    /// </summary>
    public partial class Task7 : Page
    {
        public Task7()
        {
            InitializeComponent();
        }

        public void BTN_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(TBa);
                double k = 8.2, x = 5;
                MessageBox.Show($"y = {Math.Pow(Math.Log10(a),3) + Math.Pow(Math.Cos(x), 5)}", " задание 1.1",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.1",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
            }
        }
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new MainPage());
        }
    }
}
