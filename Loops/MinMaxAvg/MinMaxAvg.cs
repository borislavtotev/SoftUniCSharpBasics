using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MinMaxAvg
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int min = int.MaxValue;
        int max = int.MinValue;
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            int newValue = int.Parse(Console.ReadLine());
            sum += newValue;

            if (newValue > max)
            {
                max = newValue;
            }

            if (newValue < min)
            {
                min = newValue;
            }
        }

        Console.WriteLine("min={0}",min);
        Console.WriteLine("max={0}", max);
        Console.WriteLine("sum={0}", sum);
        Console.WriteLine("avg={0:0.00}",(decimal)sum/n);
    }
}

