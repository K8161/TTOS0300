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
        double Course = 5.94;
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
                    MoneyValue = MoneyValue * Course;
                    textBox1.Text = Convert.ToString(string.Format("{0:0.00}", MoneyValue));
                }

                else if (textBox.Text == "")
                {
                    MoneyValue = Convert.ToDouble(textBox1.Text);
                    MoneyValue = MoneyValue / Course;
                    textBox.Text = Convert.ToString(string.Format("{0:0.00}", MoneyValue));
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Only numbers allowed", "Error");
            }
           

        }
    }
}
