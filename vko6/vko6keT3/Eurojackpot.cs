using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko6keT3
{
    class Eurojackpot
    {
        public string s;
        int eurojackpotnumber;
        int eurojackpotstarnumber;
        int holder;

        Random rnd = new Random();

        public void lottomachine()
        {
            try
            {
                List<int> eurojackpotrow = new List<int>();
                s = "";
                do
                {
                    eurojackpotnumber = rnd.Next(1, 50);
                    if (!eurojackpotrow.Contains(eurojackpotnumber)) eurojackpotrow.Add(eurojackpotnumber);
                } while (eurojackpotrow.Count < 5);

                eurojackpotrow.Sort();

                

                //add starnumbers to the end of row
                do
                {
                    eurojackpotstarnumber = rnd.Next(1, 11);
                    if (!eurojackpotrow.Contains(eurojackpotstarnumber)) eurojackpotrow.Add(eurojackpotstarnumber);
                } while (eurojackpotrow.Count < 7);

         /*       if (eurojackpotrow[7] > eurojackpotrow[6])
                {
                    holder = eurojackpotrow[7];
                    eurojackpotrow[7] = eurojackpotrow[6];
                    eurojackpotrow[6] = holder;
                } */

                for (int x = 0; x < eurojackpotrow.Count - 1; x++)
                {
                    s += eurojackpotrow[x] + ", ";
                }
                s += eurojackpotrow[6];
                s += "\n";


            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
