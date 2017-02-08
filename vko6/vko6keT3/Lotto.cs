using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko6keT3
{
     public class Lotto
    {

        public void lottomachine()
        {
            int[] lottoline = new int[7]; /*Alkiot 0-6*/
            int x, i, j, help, amount, linenumber = 0;
            string s;
            bool arvottu = false;
            Random rand = new Random();

            Console.WriteLine("Montako riviä arvotaan?");
            amount = Convert.ToInt32(Console.ReadLine());

            for (help = 0; amount > 0; amount--)
            {

                // Ensin arvotaan
                for (i = 0; i < 7; i++)
                {
                    x = rand.Next(1, 40);

                    // PITÄÄ tarkistaa, että kelpaako arvottu numero
                    // Käydään aiemmin arvotut numerot läpi:
                    for (j = 0; j < i; j++)
                    {
                        if (lottoline[j] == x)
                        {
                            arvottu = true;
                        }
                    }

                    if (arvottu)
                    {
                        // PITÄÄ arpoa uudestaan
                        x = rand.Next(1, 40);
                        i--;
                        arvottu = false;
                    }
                    else
                    { // KELPAA:
                        lottoline[i] = x;
                    }
                }

                for (i = 6; i >= 1; i--)
                {

                    for (j = 0; j <= i - 1; j++)
                    {
                        // Vertaa kahta peräkkäistä, vaihda isompi oikealle
                        if (lottoline[j] > lottoline[j + 1])
                        {
                            help = lottoline[j];
                            lottoline[j] = lottoline[j + 1];
                            lottoline[j + 1] = help;

                        }
                    }
                }

                linenumber++;
                s = "";
                for (i = 0; i < 7; i++)
                {
                    if (i <= 5)
                        //   cout << lottorivi[i] << endl;
                        s += lottoline[i] + ", ";

                    else
                        s += lottoline[i] + "\n\n";
                }
            }
        }
    }
}