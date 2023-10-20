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

namespace ProjectAndSolutions.Frames
{
    /// <summary>
    /// Логика взаимодействия для AddOrEditWorker.xaml
    /// </summary>
    public partial class AddOrEditWorker : Page
    {
        private Worker _currentWorker = new Worker();
        public AddOrEditWorker(Worker selectWorker)
        {
            InitializeComponent();
            
            if (selectWorker != null)
            {
                _currentWorker = selectWorker;
            }

            DataContext = _currentWorker;
            CBoxWorkerDevision.ItemsSource = ProAndSolEntities.GetContext().Devision.ToList();
        }

        private void PageIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                ProAndSolEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            }
        }

        private void BtnOkClick(object sender, RoutedEventArgs e)
        {
            StringBuilder s = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentWorker.FIO))
                s.AppendLine("Поле ФИО пустое");
            if (string.IsNullOrWhiteSpace(_currentWorker.ServiceNum))
                s.AppendLine("Поле Табельный номер пустое");
            if (string.IsNullOrWhiteSpace(_currentWorker.Position))
                s.AppendLine("Поле Должность пустое");
            if (_currentWorker.ID_Devision == 0)
                s.AppendLine("Подразделение не выбрано");
            if (string.IsNullOrWhiteSpace(_currentWorker.Email))
                s.AppendLine("Поле Email пустое");
            if (string.IsNullOrWhiteSpace(_currentWorker.TelephoneNum))
                s.AppendLine("Поле Телефон пустое");


            if (s.Length > 0)
            {
                MessageBox.Show(s.ToString(), "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (_currentWorker.ID_Worker == 0)
            {
                _currentWorker.DateOfAdd = DateTime.Now;
                _currentWorker.Status = true;
                ProAndSolEntities.GetContext().Worker.Add(_currentWorker);
            }

            try
            {
                ProAndSolEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!", "Сохранение", MessageBoxButton.OK, MessageBoxImage.Information);
                Manager.mainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult x = MessageBox.Show("Создание (/изменения) не будут применены. Вы действительно хотите выйти?",
                                                    "Выйти", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (x == MessageBoxResult.OK)
                Manager.mainFrame.GoBack();

        }
    }
}
