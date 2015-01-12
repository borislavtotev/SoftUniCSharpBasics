using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CalculateGCD
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int c = 0;

        if (a < b)
        {
            c = a;
            a = b;
            b = c;
        }

        int remainder;

        do
        {
            remainder = a % b;
            a = b;
            b = remainder;
        } while (remainder != 0);
        Console.WriteLine(a);
    }

}

