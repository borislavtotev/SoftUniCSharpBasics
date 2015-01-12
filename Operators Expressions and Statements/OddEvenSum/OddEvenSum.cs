using System;

using System.Text;

class OddEvenSum
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int SumOdd = new int();
        int SumEven = new int();

        for (int i = 1; i <= 2*n; i++)
        {
            int NewValue = int.Parse(Console.ReadLine());
            if (i % 2 ==0)
            {
                SumEven += NewValue; 
            }
            else
            {
                SumOdd += NewValue;
            }
        }

        if (SumOdd==SumEven)
        {
            Console.WriteLine("Yes, sum="+SumEven);
        }
        else
        {
            Console.WriteLine("No, diff="+Math.Abs(SumEven-SumOdd));
        }
    }
}

