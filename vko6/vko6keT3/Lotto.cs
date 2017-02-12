using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko6keT3
{
     public class Lotto
    {
        public string s;
        int lottonumber;

        Random rnd = new Random();

        public void lottomachine()
        {
            try
            {
                List<int> lottorow = new List<int>();
                s = "";
                do
                {
                    lottonumber = rnd.Next(1, 40);
                    if (!lottorow.Contains(lottonumber)) lottorow.Add(lottonumber);
                } while (lottorow.Count < 7);

                lottorow.Sort();

                for (int x = 0; x < lottorow.Count - 1; x++)
                {
                    s += lottorow[x] + ", ";
                }
                s += lottorow[6];
                s += "\n";


            }
            catch (Exception ex)
            {

                throw;
            }
            
        }   
    }
}