using System;

class ExchangeIfGreater
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        if (a>b)
        {
            Console.WriteLine("{0} {1}",b,a);
        }
        else
        {
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}

