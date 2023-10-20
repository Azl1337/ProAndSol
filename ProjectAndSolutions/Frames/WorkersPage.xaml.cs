using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
using ProjectAndSolutions.Models;

namespace ProjectAndSolutions.Frames
{
    /// <summary>
    /// Логика взаимодействия для WorkersPage.xaml
    /// </summary>
    public partial class WorkersPage : Page
    {
        private Worker _currentWorker = new Worker();
        public WorkersPage()
        {
            InitializeComponent();

            var devisions = ProAndSolEntities.GetContext().Devision.OrderBy(p => p.DevName).ToList();
            devisions.Insert(0, new Devision
            {
                DevName = "Все подразделения"
            });
            ComboDevisions.ItemsSource = devisions;
            ComboDevisions.SelectedIndex = 0;
        }

        private void BtnAddClick(object sender, RoutedEventArgs e)
        {
            Manager.mainFrame.Navigate(new AddOrEditWorker(null));
        }

        private void BtnDeleteClick(object sender, RoutedEventArgs e)
        {
            FireWorker((sender as Button).DataContext as Worker);
        }

        private void BtnEditClick(object sender, RoutedEventArgs e)
        {
            Manager.mainFrame.Navigate(new AddOrEditWorker((sender as Button).DataContext as Worker));
        }

        private void PageIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                ProAndSolEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                List<Worker> workers = ProAndSolEntities.GetContext().Worker.OrderBy(p => p.ID_Worker).ToList();
                DGridWorkers.ItemsSource = workers;
            }
        }
        private void TBoxSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateData();
        }

        private void ComboDevisionsSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateData();
        }

        private void DPickerSelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateData();
        }

        private void FireWorker(Worker selectWorker)
        {
            if (selectWorker != null)
            {
                _currentWorker = selectWorker;
                if (_currentWorker.DateOfDis == null)
                { 
                    _currentWorker.DateOfDis = DateTime.Now;
                    _currentWorker.Status = false;
                    ProAndSolEntities.GetContext().SaveChanges();
                    MessageBox.Show("Cотрудник уволен!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    Manager.mainFrame.Navigate(new WorkersPage());
                }
                else
                    MessageBox.Show("Cотрудник уже был уволен!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
                MessageBox.Show("Cотрудник не выбран!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void BtnClearDateClick(object sender, RoutedEventArgs e)
        {
            DPickerFrom.SelectedDate = null;
            DPickerTo.SelectedDate = null;
        }

        private void UpdateData()
        {
            var currentWorker = ProAndSolEntities.GetContext().Worker.OrderBy(p => p.FIO).ToList();
            var currentWorkerNum = ProAndSolEntities.GetContext().Worker.OrderBy(p => p.ServiceNum).ToList(); ;
            var currentId = ProAndSolEntities.GetContext().Worker.OrderBy(p => p.ID_Worker).ToList();
            if ((DPickerFrom.SelectedDate >= _currentWorker.DateOfAdd) || 
                (DPickerFrom.SelectedDate <= _currentWorker.DateOfDis) ||
                (DPickerFrom.SelectedDate >= _currentWorker.DateOfAdd & DPickerFrom.SelectedDate <= _currentWorker.DateOfDis))
            {
                currentWorker = currentWorker.Where(p => (ChBoxEmployment.IsChecked == true && (p.DateOfAdd >= DPickerFrom.SelectedDate && p.DateOfAdd <= DPickerTo.SelectedDate)) || 
                                                         (ChBoxEmployment.IsChecked == true && (p.DateOfAdd >= DPickerFrom.SelectedDate && DPickerTo.SelectedDate == null)) || 
                                                         (ChBoxFire.IsChecked == true && (p.DateOfDis >= DPickerFrom.SelectedDate && p.DateOfDis <= DPickerTo.SelectedDate && p.DateOfDis != null)) ||
                                                         (ChBoxFire.IsChecked == true && (p.DateOfDis >= DPickerFrom.SelectedDate && DPickerTo.SelectedDate == null && p.DateOfDis != null))
                                                         ).ToList();
                DGridWorkers.ItemsSource = currentWorker;
            }
            else if (string.IsNullOrEmpty(TBoxSearch.Text))
                DGridWorkers.ItemsSource = currentId;
            else
            {
                if (int.TryParse(TBoxSearch.Text, out int number))
                {
                    currentWorkerNum = currentWorkerNum.Where(p => p.ServiceNum.Contains(TBoxSearch.Text)).ToList();
                    DGridWorkers.ItemsSource = currentWorkerNum;
                    if (ComboDevisions.SelectedIndex > 0)
                    {
                        currentWorkerNum = currentWorkerNum.Where(p => p.ID_Devision == (ComboDevisions.SelectedItem as Devision).ID_Devision).ToList();
                        DGridWorkers.ItemsSource = currentWorkerNum;
                    }

                }
                else if (string.IsNullOrEmpty(TBoxSearch.Text))
                    DGridWorkers.ItemsSource = currentId;
                else
                {
                    currentWorker = currentWorker.Where(p => p.FIO.ToLower().Contains(TBoxSearch.Text.ToLower())).ToList();
                    DGridWorkers.ItemsSource = currentWorker;
                    if (ComboDevisions.SelectedIndex > 0)
                    {
                        currentWorker = currentWorker.Where(p => p.ID_Devision == (ComboDevisions.SelectedItem as Devision).ID_Devision).ToList();
                        DGridWorkers.ItemsSource = currentWorker;
                    }

                }
            }
        }


    }
}
