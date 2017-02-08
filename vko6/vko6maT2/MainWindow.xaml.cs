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

namespace vko6maT2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double MoneyValue = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MoneyValue = Convert.ToDouble(textBox.Text);
                    MoneyValue = MoneyValue * 5.94;
                    textBox1.Text = Convert.ToString(MoneyValue);
                }

                else if (textBox.Text == "")
                {
                    MoneyValue = Convert.ToDouble(textBox1.Text);
                    MoneyValue = MoneyValue / 5.94;
                    textBox.Text = Convert.ToString(MoneyValue);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Only numbers allowed", "Error");
            }
           

        }
    }
}
