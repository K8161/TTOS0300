using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace vko7T3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Workerdata yritys;
        ObservableCollection<Worker> tyolaiset;
        public MainWindow()
        {
            InitializeComponent();
            IniMyStuff();
        }

        private void IniMyStuff()
        {
            //haetaan työntekijät
            yritys = new Workerdata();
            tyolaiset = yritys.GetWorkers();

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lsbTiedot.Items.Clear();
        }

        private void btnGet_Click(object sender, RoutedEventArgs e)
        {
            spLeft.DataContext = tyolaiset;
            spRight.DataContext = tyolaiset;
        }
    }
}
