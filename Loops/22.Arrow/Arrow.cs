using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Arrow
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(".".PadRight((n - 1) / 2, '.') + "#".PadRight(n, '#') + ".".PadRight((n - 1) / 2, '.'));

        for (int i = 1; i < n-1; i++)
        {
            Console.WriteLine(".".PadRight((n - 1) / 2, '.') + "#".PadRight(n-1, '.') + "#" +  ".".PadRight((n - 1) / 2, '.'));    
        }

        Console.WriteLine("#".PadRight((n - 1) / 2, '#') + "#".PadRight(n - 1, '.') + "#" + "#".PadRight((n - 1) / 2, '#'));

        for (int i = 1; i < n-1; i++)
        {
            Console.WriteLine(".".PadRight(i, '.') + "#".PadRight((2*n-2*i-2), '.') + "#" + ".".PadRight(i, '.'));
        }

        Console.WriteLine(".".PadRight(n-1, '.') + "#" + ".".PadRight(n-1, '.'));
    }
}

