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

namespace vko6maT3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double heigth = 0;
        double width = 0;
        double wWidth = 0;
        double wArea = 0;
        double gArea = 0;
        double circum = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // convert inputs to doubles
            heigth = Convert.ToDouble(windowHeight.Text);
            width = Convert.ToDouble(windowWidth.Text);
            wWidth = Convert.ToDouble(woodWidth.Text);

            //count values for area & circumference
            wArea = heigth * width / 10;
            gArea = (heigth - wWidth) * (width - wWidth) / 10;
            circum = heigth + width * 2 / 10;

            //print data
            windowArea.Text = Convert.ToString(wArea) + "cm²";
            glassArea.Text = Convert.ToString(gArea) + "cm²";
            woodCircumference.Text = Convert.ToString(circum) + "cm²";

        }
    }
}
