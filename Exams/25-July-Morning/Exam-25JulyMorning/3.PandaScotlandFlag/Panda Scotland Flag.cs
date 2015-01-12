using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PandaScotlandFlag
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        char Start = 'A';
        char NextStart = 'B';
 
        int change = 1;
        int i = 0;

        if (N == 1)
        {
            Console.WriteLine("A");
        }
        else
        {
            for (int row = 0; row < N; row++)
            {
                if (i == (N - 1) / 2)
                {
                    Console.Write("-".PadRight((N - 1) / 2, '-'));
                    Console.Write((char)(Start));
                    Console.Write("-".PadRight((N - 1) / 2, '-'));
                    Start = NextStart;
                    change = -1;
                }
                else
                {
                    Console.Write("".PadRight(i, '~'));
                    Console.Write((char)Start);
                    Console.Write("".PadRight(N - 2 * i - 2, '#'));
                    Console.Write(NextStart);
                    Console.Write("".PadRight(i, '~'));
                    Start = (char)(NextStart + 1);
                }

                i = i + change;

                if ((char)(Start) == 'Z')
                {
                    NextStart = 'A';

                }
                else if (Start == (int)('Z' + 1))
                {
                    Start = 'A';
                    NextStart = 'B';
                }
                else
                {
                    NextStart = (char)(Start + 1);
                }

                Console.WriteLine();
            }
        }

    }
}

