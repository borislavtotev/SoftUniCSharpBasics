using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrintADeckof52Cards
{
    static void Main(string[] args)
    {
        string[] Cards = new string[] {"2","3","4","5","6","7","8","9","10","J","Q","K","A" };
        string[] Boi = new string[] { "♥", "♦", "♠", "♣" };

        for (int i = 0; i < Cards.Length; i++)
        {
            for (int j = 0; j < Boi.Length; j++)
            {
                if (j!=(Boi.Length-1))
                {
                    Console.Write("{0}{1} ",Cards[i],Boi[j]);
                }
                else
                {
                    Console.Write("{0}{1}", Cards[i], Boi[j]);
                }
            }

            Console.WriteLine();
        }
    }

}

