using System;

class SumOfNNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Please write how many numbers you want to sum:");
        int n = int.Parse(Console.ReadLine());

        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            double NewValue = double.Parse(Console.ReadLine());
            sum += NewValue;
        }
        Console.WriteLine("The sum of all values is:" + sum);
    }
}

