using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BitKiller
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine()); ;
        int [] IntValues = new int[n];
        int j = 0;

        for (int i = 0; i < n; i++)
        {
            IntValues[j] = int.Parse(Console.ReadLine());
            j++;
        }

        int lastremoveposition = 1;

        string[] ResultChars = new string[n * 8];
        int k = 0;

        for (int i = 0; i < n*8; i++)
        {
            //string Value = Convert.ToString(IntValues[i/8], 2).PadLeft(8, '0');
            //Console.WriteLine(Value);

            if (i != 1 && i != lastremoveposition + step)
            {
                ResultChars[k] = GetBit(IntValues[i / 8], i - 8 * (int)(i / 8));
                k++;
            }
            else
            {
                lastremoveposition = i;
            }
        }

        string NewStr = "";

        //Console.WriteLine(k);

        for (int i = 0; i < k; i++)
        {
            NewStr = NewStr + ResultChars[i];

            if (i>0 && ((i+1) % 8 == 0))
            {
                Console.WriteLine(Convert.ToInt32(NewStr, 2));
                NewStr = "";
            }

            //Console.WriteLine(NewStr);
        }

        if (k % 8 != 0)
        {
            //Console.WriteLine((NewStr.PadRight(8, '0')));
            Console.WriteLine(Convert.ToInt32(NewStr.PadRight(8, '0'), 2));
        }
    }
    private static string GetBit(int NewInt, int position)
    {
        int NewDummy = NewInt >> (8 - position - 1);
        //Console.WriteLine(Convert.ToString(NewDummy, 2).PadLeft(8, '0'));

        int NewValue = NewDummy & 1;
        //Console.WriteLine("{0}:{1}", position, Convert.ToString(NewValue));
        return Convert.ToString(NewValue);
    }
}
