using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class PrimeChecker
{
    static void Main(string[] args)
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());

        Boolean prime = false;
        if (n >= 2)
        {
            prime = IsPrime(n);    
        }

        Console.WriteLine(prime);
    }

    private static bool IsPrime(BigInteger n)
    {
        Boolean isPrime = true;

        for (int i = 2; i <= Math.Sqrt((double)n); i++)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        return isPrime;
    }
}

