using Safonof_Iliya_Task2.View.Pages.TaskPages;
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

namespace Safonof_Iliya_Task2.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MANEpage.xaml
    /// </summary>
    public partial class MANEpage : Page
    {
        public MANEpage()
        {
            InitializeComponent();
        }

        private void Main_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new MainPage());
        }
    }
}
