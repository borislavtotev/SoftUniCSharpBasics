using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MelonsWatermelons
{
    static void Main(string[] args)
    {
        int s = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());

        long sumMelon = 0;
        long sumWaterMelon = 0;
        int newd = s;

        for (int i = 0; i < d; i++)
        {
            switch (newd)
            {
                case 1: sumWaterMelon++; break;
                case 2: sumMelon += 2; break;
                case 3: sumMelon++; sumWaterMelon++; break;
                case 4: sumWaterMelon += 2; break;
                case 5: sumWaterMelon += 2; sumMelon += 2; break;
                case 6: sumWaterMelon++; sumMelon += 2; break;
                default:
                    break;
            }

            if (newd == 7)
            {
                newd = 1;
            }
            else
            {
                newd++;
            }
        }

        if (sumMelon == sumWaterMelon) 
        {
            Console.WriteLine("Equal amount: {0}",sumMelon);
        }
        else if (sumMelon > sumWaterMelon)
        {
            Console.WriteLine("{0} more melons",(sumMelon-sumWaterMelon));
        }
        else
        {
            Console.WriteLine("{0} more watermelons",(sumWaterMelon-sumMelon));
        }
    }
}

