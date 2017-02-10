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

namespace vko6keT4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Heater finnFryer = new Heater();
        string input;
        float inputNumber;
        public MainWindow()
        {
            InitializeComponent();
        }



        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                input = txbScreen.Text;
                inputNumber = float.Parse(input);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            try
            {
                if (rdbTemp.IsChecked == true)
                {
                    finnFryer.Temperature = inputNumber;
                    txbTempNumber.Text = Convert.ToString(finnFryer.Temperature);
                }

                else if (rdbHum.IsChecked == true)
                {
                    finnFryer.Humidity = inputNumber;
                    txbHumNumber.Text = Convert.ToString(finnFryer.Humidity);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }

        private void AddValue(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txbScreen.Text == "0")
                {
                    txbScreen.Text = "";
                }

                Button button = sender as Button;
                txbScreen.Text += Convert.ToString(button.Content);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string Screentext = txbScreen.Text;
                string NewScreentext = Screentext.Substring(0, Screentext.Length - 1);
                txbScreen.Text = NewScreentext;            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txbScreen.Text = "0";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
