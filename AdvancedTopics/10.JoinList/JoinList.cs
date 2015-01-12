using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.JoinList
{
    class JoinList
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            List<string> ListInput1 = new List<string>(input1.Split(' '));
            List<string> ListInput2 = new List<string>(input2.Split(' '));

            foreach (var item in ListInput2)
            {
                ListInput1.Add(item);
            }

            ListInput1.Sort();

            for (int i = 0; i < ListInput1.Count; i++)
            {
                if (i >= 1)
                {
                    if (ListInput1[i]!=ListInput1[i-1])
                    {
                        Console.Write(ListInput1[i] + " ");
                    }
                }
                else
                {
                    Console.Write(ListInput1[i] + " ");
                }
            }
        }
    }
}
