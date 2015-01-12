using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Car
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine(".".PadLeft(N, '.') + "*".PadLeft(N, '*') + ".".PadLeft(N, '.'));

        for (int i = 1; i <= (N/2-1); i++)
        {
            Console.WriteLine(".".PadLeft(N-i, '.') + "*" + ".".PadLeft(3*N-N+i-N+i-2, '.') + "*" +".".PadLeft(N-i, '.'));
        }

        Console.WriteLine("*".PadLeft(N / 2 + 1, '*') + ".".PadLeft(3*N-N-2,'.') + "*".PadLeft(N / 2 + 1, '*'));

        for (int i = 0; i < N/2-2; i++)
        {
            Console.WriteLine("*" + ".".PadRight(3*N-2,'.') + "*");
        }

        Console.WriteLine("*".PadRight(3*N,'*'));

        for (int i = 0; i < N / 2 - 2; i++)
        {
            Console.WriteLine(".".PadRight(N / 2, '.') + "*".PadRight(N / 2, '.') + "*".PadRight(N - 1, '.') + "*".PadRight(N / 2, '.') + "*".PadRight(N / 2+1, '.'));
        }

        Console.WriteLine(".".PadRight(N / 2, '.') + "*".PadRight(N / 2, '*') + "*".PadRight(N - 1, '.') + "*".PadRight(N / 2, '*') + "*".PadRight(N / 2 + 1, '.'));


    }
}

