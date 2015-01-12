using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;



class CatalanNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger result = 1;

        for (int i = n+1; i <= 2*n; i++)
        {
            result *= i;
        }

        BigInteger result1 = 1;

        for (int i = 1; i <= n+1; i++)
        {
            result1 *= i;
        }

        Console.WriteLine(result / result1);
    }
}

