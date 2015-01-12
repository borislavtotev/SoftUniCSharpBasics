using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CalculateNK
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        long result = 1;

        for (int i = k+1; i <= n; i++)
        {
            result *= i;    
        }
        Console.WriteLine(result);
    }
}

