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
using JAMK.ICT;

namespace WPF_Demo_X3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // koska useampi metodi=tapahtumakäsittelijä tulee käyttämään näitä muuttujia -->
        //määritellään luokan tasolle luokan jäsenmuuttujiksi
        JAMK.ICT.HockeyLeague liiga;
        ObservableCollection<JAMK.ICT.HockeyTeam> joukkueet;
        int counter = 0;
        public MainWindow()
        {
            InitializeComponent();
            IniMyStuff();
        }
        private void IniMyStuff()
        {
            //tänne kootusti omien kontrollien alustukset
            List<string> muuvit = new List<string>();
            muuvit.Add("Halloween");
            muuvit.Add("Jaws");
            muuvit.Add("Star Wars");
            cmbMovies.ItemsSource = muuvit;

            //haetaan SM-Liiga-joukkueet
            liiga = new JAMK.ICT.HockeyLeague();
            joukkueet = liiga.GetTeams();
            cmbTeams.ItemsSource = joukkueet;
            
        }

        private void btnBind_Click(object sender, RoutedEventArgs e)
        {
            //määritellään Stackpanelin DataContext
            //Demo1: Datacontextina on olio
            HockeyTeam tiimi = new HockeyTeam("KeuPa", "Keuruu");
            //spRight.DataContext = tiimi;
            //Demo2: kytketään olio-kokoelman 1. olioon
            spRight.DataContext = joukkueet[counter];
        }

        private void btnForward_Click(object sender, RoutedEventArgs e)
        {
            if (counter > joukkueet.Count)
            {
                counter = 0;
            }
            counter++;
            spRight.DataContext = joukkueet[counter];
        }

        private void btnBackward_Click(object sender, RoutedEventArgs e)
        {
            if (counter < 0)
            {
                counter = joukkueet.Count;
            }
            counter--;
            spRight.DataContext = joukkueet[counter];
        }
    }
}
