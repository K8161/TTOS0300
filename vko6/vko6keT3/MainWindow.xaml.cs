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

namespace vko6keT3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string lotterytype;
        int amount;
        public MainWindow()
        {
            InitializeComponent();
            cmbChoose.Items.Add("Lotto");
            cmbChoose.Items.Add("Viking Lotto");
            cmbChoose.Items.Add("EuroJackpot");
        }

        private void btnDraw_Click(object sender, RoutedEventArgs e)
        {
              lotterytype = cmbChoose.SelectedValue.ToString();
         //   lotterytype = "EuroJackpot";
            amount = Convert.ToInt32(txtDraw.Text);
            txbResult.Text += "\n";

            // Basic lottery type
            if (lotterytype == "Lotto")
            {
                try
                {
                    Lotto basiclotto = new Lotto(); // create basiclotto object
                    int rowNumber = 1;              
                    for (int y = 0; y < amount; y++)
                    {
                        basiclotto.lottomachine(); // times method is used is dependant on user input

                        txbResult.Text += "Row " + rowNumber + ": " + basiclotto.s; // print lotteryrow
                        rowNumber++;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

            //Viking lotto, works basically just like basic lottery but little difference in numbers
            if (lotterytype == "Viking Lotto")
            {
                try
                {
                    VikingLotto vikinglotto = new VikingLotto(); // create viking lotto object
                    int rowNumber = 1;
                    for (int y = 0; y < amount; y++)
                    {
                        vikinglotto.lottomachine();

                        txbResult.Text += "Row " + rowNumber + ": " + vikinglotto.s;
                        rowNumber++;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

            //Eurojackpot, works basically just like basic lottery but little difference in numbers plus has two star numbers
            if (lotterytype == "EuroJackpot")
            {
                try
                {
                    Eurojackpot eurojackpot = new Eurojackpot(); // create eurojackpot object
                    int rowNumber = 1;
                    for (int y = 0; y < amount; y++)
                    {
                        eurojackpot.lottomachine();

                        txbResult.Text += "Row " + rowNumber + ": " + eurojackpot.s;
                        rowNumber++;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txbResult.Text = "";
        }
    }
}
