using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko7T3
{
    class Worker : Person
    {
        public string Title { get; set; }
        public int WorkerId { get; set; }
        public DateTime StartDate { get; set; }
        public float Pay { get; set; }

        virtual public float CountPay()
        {
            return Pay;
        }

        public Worker(string socialId, string firstName, string lastName, string title, int workerId, float pay)
        {
            SocialId = socialId;
            FirstName = firstName;
            LastName = lastName;
            title = Title;
            workerId = WorkerId;
            pay = Pay;
        }

 /*       ObservableCollection<Worker> workers = new ObservableCollection<Worker>();
        //Constructor
        public Worker()
        {
            workers.Add(new Worker ("324dc", "Alfred", "Nobel", "Toimitusjohtaja", 1, 5000));
        }
        //Methods
        public ObservableCollection<Worker> GetWorkers()
        {
            return workers;
        } */

        public override string ToString()
        {
            return WorkerId + " = " + base.ToString() + ", " + Title;
        }
    }
}
