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

                for (int x = 0; x < eurojackpotrow.Count; x++)
                {
                    s += eurojackpotrow[x] + ", ";
                }

                List<int> eurojackpotstarnumbers = new List<int>();
                do
                {
                    eurojackpotstarnumber = rnd.Next(1, 11);
                    if (!eurojackpotstarnumbers.Contains(eurojackpotstarnumber)) eurojackpotrow.Add(eurojackpotstarnumber);
                } while (eurojackpotstarnumbers.Count < 2);

                eurojackpotstarnumbers.Sort();

                for (int y = 0; y < eurojackpotstarnumbers.Count - 1; y++)
                {
                    s += eurojackpotrow[y] + ", ";
                }
                s += eurojackpotrow[1];
                s += "\n";


            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
