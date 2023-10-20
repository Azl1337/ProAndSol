using ProjectAndSolutions.Frames;
using ProjectAndSolutions.Models;
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

namespace ProjectAndSolutions
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new WorkersPage());
            Manager.mainFrame = MainFrame;
        }

        private void BtnDevisionsClick(object sender, RoutedEventArgs e)
        {
            Manager.mainFrame.Navigate(new DivisionsPage());
            BtnDevisions.Visibility=Visibility.Collapsed;
            BtnWorkers.Visibility=Visibility.Visible;
        }

        private void BtnWorkersClick(object sender, RoutedEventArgs e)
        {
            Manager.mainFrame.Navigate(new WorkersPage());
            BtnDevisions.Visibility = Visibility.Visible;
            BtnWorkers.Visibility = Visibility.Collapsed;
        }
    }
}
