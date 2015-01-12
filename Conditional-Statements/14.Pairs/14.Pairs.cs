using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Pairs
{
    static void Main(string[] args)
    {
        string Input = Console.ReadLine();
        string[] NumbersStr = Input.Split(' ');

        int maxdiff = 0;
        int pressum = Convert.ToInt32(NumbersStr[0]) + Convert.ToInt32(NumbersStr[1]);
        int samesum = 0;

        for (int i = 0; i < NumbersStr.Length; i=i+2)
        {
            int sum = Convert.ToInt32(NumbersStr[i]) + Convert.ToInt32(NumbersStr[i + 1]);
            //Console.WriteLine("sum=" + sum);

            if (sum == pressum)
            {
                samesum++;
            }
            else
            {
                int diff = Math.Abs(sum - pressum);
                //Console.WriteLine("diff=" + diff);

                if (diff > maxdiff)
                {
                    maxdiff = diff;
                }
            }
            pressum = sum;
        }

        if (samesum == NumbersStr.Length/2)
        {
            Console.WriteLine("Yes, value={0}",pressum);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", maxdiff);
        }


    }
}

