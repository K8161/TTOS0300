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
                if ((bool)chkMilk.IsChecked)
                {
                    txbList.Text += " milk ";
                }

                if ((bool)chkButter.IsChecked)
                {
                    txbList.Text += " butter ";
                }

                if ((bool)chkBeer.IsChecked)
                {
                    txbList.Text += " beer ";
                }

                if ((bool)chkChicken.IsChecked)
                {
                    txbList.Text += " chicken ";
                }

                if ((bool)chkLemonade.IsChecked)
                {
                    txbList.Text += " lemonade ";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            /*    

               foreach (object control in StackPanel.Children)
                   {
                       if (control is CheckBox)
                       {
                           CheckBox checkbox = (CheckBox)control;
                           if ((bool)checkbox.IsChecked) ItemsControl += checkbox.Content + " ";
                       }
                   }
                   //display
                   txbList.Text = items; */
        }
    }
}
