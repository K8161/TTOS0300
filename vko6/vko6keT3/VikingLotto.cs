using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko6keT3
{
    class VikingLotto
    {
        public string s;
        int vikinglottonumber;

        Random rnd = new Random();

        public void lottomachine()
        {
            try
            {
                List<int> vikinglottorow = new List<int>();
                s = "";
                do
                {
                    vikinglottonumber = rnd.Next(1, 49);
                    if (!vikinglottorow.Contains(vikinglottonumber)) vikinglottorow.Add(vikinglottonumber);
                } while (vikinglottorow.Count < 6);

                vikinglottorow.Sort();

                for (int x = 0; x < vikinglottorow.Count - 1; x++)
                {
                    s += vikinglottorow[x] + ", ";
                }
                s += vikinglottorow[5];
                s += "\n";

            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
