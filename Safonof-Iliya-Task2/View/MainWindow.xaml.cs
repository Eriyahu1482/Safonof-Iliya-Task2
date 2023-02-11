using Safonof_Iliya_Task2.View.Pages;
using System.Windows;
using static Safonof_Iliya_Task2.Core.Core;

namespace Safonof_Iliya_Task2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CoreNavigate.MyCore = MainFrame;
            MainFrame.Navigate(new MANEpage());
        }
    }
}
