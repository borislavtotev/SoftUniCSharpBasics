using System;

class FibonacciNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many Fibonacci Numbers you want to see?");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Here are the first {0} Fibonacci Numbers:",n);

        int FibonacciLast = 0;
        int FibonacciPrevious = 0;
        int FibonacciCurrent = 0;

        for (int i = 0; i < n; i++)
        {
            if (i == 0 || i == 1 )
            {
                Console.Write(i+" ");
                FibonacciPrevious = FibonacciLast;
                FibonacciLast = i;
            }
            else
            {
                FibonacciCurrent = FibonacciLast + FibonacciPrevious;
                FibonacciPrevious = FibonacciLast;
                FibonacciLast = FibonacciCurrent;
                Console.Write(FibonacciCurrent + " ");
            }
        }
        Console.WriteLine();
    }
}

