using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading; //säiettä varten
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
using JAMK.IT;

namespace WPFVRtrains
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Train> trains = new List<Train>();
        string selectedStation = "";
        public MainWindow()
        {
            InitializeComponent();
            InitializeMyStuff();
        }
        #region METHODS
        void InitializeMyStuff()
        {
            //omat asetukset kootaan tänne
            //täytetään comboboksi asemilla
            GetStations();
        }
        private void GetStations()
        {
            List<Station> stations = new List<Station>();
            stations.Add(new Station("JY", "Jyväskylä"));
            stations.Add(new Station("HKI", "Helsinki"));
            stations.Add(new Station("TPE", "Tampere"));
            //TODO hakekaa asemapaikat APIn json:sta
            //kiinnitetään stations kokoelma comboboxiin
            cmbStations.DisplayMemberPath = "Name";
            cmbStations.SelectedValuePath = "Code";
            cmbStations.DataContext = stations;
        }
        private void GetTrainsAt()
        {
            try
            {
                //haetaan asemalta lähtevät junat
                string st = cmbStations.SelectedValue.ToString();
                trains = JAMK.IT.TrainsVM.GetTrainsAt(st);
                dgTrains.DataContext = trains;
                txbMessage.Text = string.Format("Löytyi {0} junaa", trains.Count);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void GetTrainsAtAsync()
        {
            //huom eri säikeessä ajettava metodi EI VOI käsitellä GUIta
            //mutta muuttujia voi
            trains = JAMK.IT.TrainsVM.GetTrainsAt(selectedStation);
            UpdateUI();
        }
        private void UpdateUI()
        {
            Action action = () =>
            {
                dgTrains.DataContext = trains;
                txbMessage.Text = string.Format("Löytyi {0} junaa", trains.Count);
            };
            Dispatcher.BeginInvoke(action);
        }
        #endregion

        private void btnGetTrains_Click(object sender, RoutedEventArgs e)
        {
            if (cmbStations.SelectedValue != null)
            {
                //V1: alkuperäinen
                //txbMessage.Text = "Haetaan junat...";
                //GetTrainsAt();
                //V2: asynkroninen omassa säikeessä
                selectedStation = cmbStations.SelectedValue.ToString();
                new Thread(GetTrainsAtAsync).Start();
                txbMessage.Text = "haetaan junia, odota hetki";
            }
        }
    }
}
