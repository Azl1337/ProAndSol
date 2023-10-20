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
using ProjectAndSolutions.Models;

namespace ProjectAndSolutions.Frames
{
    /// <summary>
    /// Логика взаимодействия для DivisionsPage.xaml
    /// </summary>
    public partial class DivisionsPage : Page
    {
        public DivisionsPage()
        {
            InitializeComponent();
        }
        private void PageIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                ProAndSolEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                List<Devision> devisions = ProAndSolEntities.GetContext().Devision.OrderBy(p => p.ID_Devision).ToList();
                DGridDevision.ItemsSource = devisions;
            }
        }
    }
}
