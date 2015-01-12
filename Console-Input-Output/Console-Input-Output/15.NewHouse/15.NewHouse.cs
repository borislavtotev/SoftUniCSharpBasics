using System;
using System.Text;
using System.Threading;
using System.Runtime.InteropServices;



class NewHouse
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < (int)(N / 2); i++)
        {
            Console.Write("-".PadRight((int)(N / 2) - i, '-'));
            Console.Write("*".PadRight(2 * i + 1, '*'));
            Console.WriteLine("-".PadRight((int)(N / 2) - i, '-'));
        }

        Console.WriteLine("*".PadRight(N,'*'));

        for (int i1 = 0; i1 < N; i1++)
        {
            Console.WriteLine("|".PadRight(N - 1, '*') + "|");
        }
    }
}

