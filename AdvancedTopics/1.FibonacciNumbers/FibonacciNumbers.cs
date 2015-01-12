using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FibonacciNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Fib(n);
    }
    static void Fib(int n)
    {
        List<int> FibValues = new List<int>();

        FibValues.Add(1);
        FibValues.Add(1);
        
        for (int i = 2; i <= n; i++)
        {
            FibValues.Add(FibValues[i-1]+FibValues[i-2]);
        }
    
        Console.WriteLine(FibValues.Last());
    }
}

