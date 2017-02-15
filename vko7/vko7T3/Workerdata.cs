using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko7T3
{
    class Workerdata
    {
        ObservableCollection<Worker> workers = new ObservableCollection<Worker>();
        //Constructor
        public Workerdata()
        {
            workers.Add(new Worker("324dc", "Alfred", "Nobel", "Toimitusjohtaja", 1, 5000));
            workers.Add(new Worker("313", "Aku", "Ankka", "Liukuhihnatyöntekijä", 2, 2000));
            workers.Add(new Worker("423t", "Teppo", "Tulppu", "Siivoaja", 3, 1500));
            workers.Add(new Worker("k344", "Pelle", "Peloton", "Keksijä", 4, 1700));
        }
        //Methods
        public ObservableCollection<Worker> GetWorkers()
        {
            return workers;
        }
    }
}
