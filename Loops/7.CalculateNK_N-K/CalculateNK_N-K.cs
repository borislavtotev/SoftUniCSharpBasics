using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class CalculateNK_N
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        BigInteger result = 1;

        for (int i = k + 1; i <= n; i++)
        {
            result *= i;
        }

        BigInteger result1 = 1;

        for (int i = 1; i <= n-k; i++)
        {
            result1 *= i;
        }

        Console.WriteLine(result/result1);
    }
}

