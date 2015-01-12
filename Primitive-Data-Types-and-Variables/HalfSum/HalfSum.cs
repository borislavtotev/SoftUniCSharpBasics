using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int S = 0;
        int S2 = 0;
        int NewValue = 0;
        for (int i = 1; i < 2*n+1; i++)
        {
            NewValue = 0;
            NewValue = int.Parse(Console.ReadLine());
            if (i<=n)
            {  
                S += NewValue;
            }
            else
            {
                S2 += NewValue;
            }

        }

        if (S==S2)
        {
            Console.WriteLine("Yes, sum={0}",S);
        }
        else
        {
            Console.WriteLine("No, diff={0}",Math.Abs(S-S2));
        }
    }
}

