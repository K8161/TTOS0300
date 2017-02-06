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

namespace WPF_Hello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //laskuri
        int i = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            textBlock.Text = "Hello " + textBox.Text;
            MessageBox.Show("Terve " + textBox.Text, "Jarko's messut");
            i++;
            textBlock1.Text = Convert.ToString(i);
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            //kutsutaan näkyviin About -niminen ikkuna
            About aboutWin = new About();
            //huom ikkuna voi olla joko modaalinen tai tavallinen
            //aboutWin.ShowDialog(); //modaalinen, modal
            aboutWin.Show(); //tavallinen, regular
        }
    }
}
