using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class TrailingZeroesInN
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger sum = 1;
 
        for (int i = 1; i <= n; i++)
        {
            sum *= i;    
        }

        //Console.WriteLine(sum);
        
        int count = 0;

        while (sum % 10 == 0)
        {
            count++;
            sum /= 10;
        }
        Console.WriteLine(count);
    }
}

