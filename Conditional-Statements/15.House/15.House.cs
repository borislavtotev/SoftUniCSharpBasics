using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class House
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine(".".PadRight((N - 1) / 2, '.') + "*" + ".".PadRight((N - 1) / 2, '.'));

        for (int i = 0; i < (N/2 - 1); i++)
        {
            Console.WriteLine(".".PadRight((N/2-1-i), '.') + "*" + ".".PadRight(2*i + 1,'.')+ "*" + ".".PadRight((N/2-1-i), '.'));
        }

        Console.WriteLine("*".PadRight(N,'*'));

        for (int i = 0; i < ((N-1)/2-1); i++)
        {
            Console.WriteLine( ".".PadRight(N/4, '.') + "*" + ".".PadRight((N - N/4 - N/4 - 2), '.') + "*" + ".".PadRight(N/4, '.') );
        }

        Console.WriteLine(".".PadRight(N / 4, '.') + "*".PadRight(N - N/4 - N/4, '*') + ".".PadRight(N / 4, '.'));
    }
}

