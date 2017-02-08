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

namespace vko6keT1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnBuy_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((bool)chcMilk.IsChecked)
                {
                    txbList.Text += " milk ";
                }

                if ((bool)chcButter.IsChecked)
                {
                    txbList.Text += " butter ";
                }

                if ((bool)chcBeer.IsChecked)
                {
                    txbList.Text += " beer ";
                }

                if ((bool)chcChicken.IsChecked)
                {
                    txbList.Text += " chicken ";
                }

                if ((bool)chcLemonade.IsChecked)
                {
                    txbList.Text += " lemonade ";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
